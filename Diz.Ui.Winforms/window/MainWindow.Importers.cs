using Diz.Cpu._65816;
using Diz.Import.bsnes.tracelog;
using Diz.Ui.Winforms.dialogs;

namespace Diz.Ui.Winforms.window;

public partial class MainWindow
{
    private BsnesTraceLogBinaryMonitorForm? liveCaptureDialog = null;

    private BsnesTraceLogCaptureController? captureController = null;

    private void ImportBizhawkCDL()
    {
        var filename = PromptOpenBizhawkCDLFile();
        if (filename != null && filename == "") return;
        ImportBizHawkCdl(filename);
        UpdateSomeUI2();
    }

    private void ImportBizHawkCdl(string filename)
    {
        try
        {
            ProjectController.ImportBizHawkCdl(filename);
        }
        catch (Exception ex)
        {
            ShowError(ex.Message, "Error");
        }
    }

    private void ImportBsnesTraceLogText()
    {
        if (!PromptForImportBSNESTraceLogFile()) 
            return;
            
        var (numModifiedFlags, numFiles) = ImportBsnesTraceLogs();
            
        RefreshUi();
        ReportNumberFlagsModified(numModifiedFlags, numFiles);
    }

    private void UiImportBsnesUsageMap()
    {
        if (openUsageMapFile.ShowDialog() != DialogResult.OK)
            return;

        var numModifiedFlags = ProjectController.ImportBsnesUsageMap(openUsageMapFile.FileName);
            
        RefreshUi();
        ShowInfo($"Modified total {numModifiedFlags} flags!", "Done");
    }

    private (long numBytesModified, int numFiles) ImportBsnesTraceLogs()
    {
        var numBytesModified = ProjectController.ImportBsnesTraceLogs(openTraceLogDialog.FileNames);
        return (numBytesModified, openTraceLogDialog.FileNames.Length);
    }

    private void ImportBsnesBinaryTraceLog()
    {
        if (liveCaptureDialog != null)
        {
            liveCaptureDialog.Focus();
            return;
        }

        var snesData = Project.Data.GetSnesApi();
        if (snesData == null)
            return;

        timerLifeCaptureUpdate.Enabled = true;

        captureController = new BsnesTraceLogCaptureController(snesData, Project.ProjectUserSettings.LiveCaptureSettings);
        liveCaptureDialog = new BsnesTraceLogBinaryMonitorForm(captureController, Project.ProjectUserSettings.LiveCaptureSettings);
        liveCaptureDialog.Show();
        liveCaptureDialog.Disposed += LiveCaptureDialog_Disposed;

        RefreshUi();
    }

    private void LiveCaptureDialog_Disposed(object? sender, EventArgs e)
    {
        liveCaptureDialog.Disposed -= LiveCaptureDialog_Disposed;
        liveCaptureDialog = null;
        captureController = null;

        timerLifeCaptureUpdate.Enabled = false;

        RefreshUi();
    }

    private void timerLifeCaptureUpdate_Tick(object sender, EventArgs e)
    {
        if (captureController == null)
        {
            return;
        }

        if (captureController.Running)
        {
            RefreshUi();
        }
    }

    private void OnImportedProjectSuccess()
    {
        UpdateSaveOptionStates(saveEnabled: false, saveAsEnabled: true, closeEnabled: true);
        RefreshUi();
    }
}