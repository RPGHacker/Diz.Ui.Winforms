using ByteSizeLib;
using Diz.Import.bsnes.tracelog;

// NOTE: upgrading .net versions, lots of this is temporarily disabled. re-enable it if you want.
//using System.Windows.Media;
//using LiveCharts;
//using LiveCharts.Wpf;

namespace Diz.Ui.Winforms.dialogs;

public partial class BsnesTraceLogBinaryMonitorForm
{
    private bool initializedChart;
    // private readonly ChartValues<long> chartValuesBytesModified = new ChartValues<long>();
    private long chartValueBytesModified_previous = 0;

    private const int refreshGraphEveryNDataPoints = 100;
    private int dataPointsIn = -1;

    private void AppendToChart((BsnesTraceLogImporter.Stats stats, int bytesInQueue) currentStats)
    {
        InitChart();

        if (dataPointsIn == -1 || ++dataPointsIn >= refreshGraphEveryNDataPoints)
            dataPointsIn = 0;

        if (dataPointsIn != 0)
            return;

        var diffBytes = currentStats.stats.NumRomBytesModified - chartValueBytesModified_previous;
        chartValueBytesModified_previous = currentStats.stats.NumRomBytesModified;
        //chartValuesBytesModified.Add(diffBytes);
    }

    private void InitChart()
    {
        if (initializedChart)
            return;

        /*cartesianChart1.Series = new SeriesCollection
        {
            new LineSeries
            {
                Title = "Instructions Modified",
                Values = chartValuesBytesModified,
                PointGeometry = Geometry.Empty,
            },
        };

        cartesianChart1.DisableAnimations = true;*/

        initializedChart = true;
    }

    private void UpdateUi()
    {
        var running = captureController?.Running ?? false;
        var finishing = captureController?.Finishing ?? false;
        var connecting = captureController?.EstablishingConnection ?? false;

        bool showStatusSpinner = false;
        bool showResultSpinner = false;

        lblStatus.Text = "Not running";
        lblStatus.ForeColor = Color.Red;
        if (running)
        {
            if (connecting)
            {
                lblStatus.Text = "Connecting...";
                lblStatus.ForeColor = Color.DodgerBlue;
                showStatusSpinner = true;
            }
            else if (finishing)
            {
                lblStatus.Text = "Stopping...";
                showStatusSpinner = true;
            }
            else
            {
                lblStatus.Text = "Running";
                lblStatus.ForeColor = Color.ForestGreen;
                showResultSpinner = true;
            }
        }

        btnFinish.Enabled = !finishing && running;
        btnStart.Enabled = !running;

        pictureSpinnerStatus.Visible = pictureSpinnerStatus.Enabled = showStatusSpinner;
        pictureSpinnerResult.Visible = pictureSpinnerResult.Enabled = showResultSpinner;

        if (running)
        {
            lblResultStatus.Text = "";
        }
        else if (lastError != "")
        {
            lblResultStatus.Text = lastError;
            lblResultStatus.ForeColor = Color.Red;
        }
        else
        {
            lblResultStatus.Text = "Success!";
            lblResultStatus.ForeColor = Color.ForestGreen;
        }

        if (captureController == null)
            return;

        var currentStats = captureController.GetStats();
        var (stats, totalQueueBytes) = currentStats;

        AppendToChart(currentStats);

        var qItemCount = captureController.BlocksToProcess.ToString();
        var qByteCount = ByteSize.FromBytes(totalQueueBytes).ToString("0.0");

        lblQueueSize.Text = $"{qByteCount} (num groups: {qItemCount})";

        // TODO: use databinding?

        lblTotalProcessed.Text = ByteSize.FromBytes(stats.NumRomBytesAnalyzed).ToString("0.00");
        lblNumberModified.Text = ByteSize.FromBytes(stats.NumRomBytesModified).ToString("0.00");
        lblModifiedDBs.Text = ByteSize.FromBytes(stats.NumDbModified).ToString("0.00");
        lblModifiedDPs.Text = ByteSize.FromBytes(stats.NumDpModified).ToString("0.00");
        lblModifiedFlags.Text = ByteSize.FromBytes(stats.NumMarksModified).ToString("0.00");
        lblModifiedXFlags.Text = ByteSize.FromBytes(stats.NumXFlagsModified).ToString("0.00");
        lblModifiedMFlags.Text = ByteSize.FromBytes(stats.NumMFlagsModified).ToString("0.00");

        // TODO: implement me. this one will also go up and down.
        // lblNumCommentsMarked.Text = ByteSize.FromBytes(stats.NumCommentsMarked).ToString("0.00");
    }

    private void btnTracelogHelpClick(object sender, EventArgs e)
    {
        MessageBox.Show("What is this? \r\n" +
                        "Connect via socket to a supported emulator and capture live tracelog as you play the game " +
                        "in realtime or play back a movie/recording/TAS.\r\n\r\n" +
                        "As each instruction is visited by the CPU, info like X, M, DB, D and flags are capture and " +
                        "logged in Diz. This will greatly aid in dissasembly.\r\n\r\n" +
                        "If you're just starting a ROM hacking project from scratch, you want to see this " +
                        "capture a lot of modified data for X, M, DP, DB and marking bytes as Opcode/Operands.\r\n\r\n" +
                        "If you're far into a ROM hacking project, you will start seeing fewer NEWLY DISCOVERED " +
                        "modifications here. Try playing through different parts of the game, menus, every " +
                        "combination of searching you can do to allow this tool to discover as much as it can.\r\n\r\n" +
                        "When you close this window, try exporting your disassembly and see how much you uncovered!\r\n\r\n" +
                        "At this time, known supported emulators are a custom build of BSNES-plus and MesenCE.\r\n\r\n" +
                        "NOTE: The emulator might buffer trace data for performance reasons, so once you're done capturing, " +
                        "it's recommend to close the connection from the emulator side first so that it " +
                        "can flush any remaining buffers. Otherwise some data might get lost.\r\n");
    }
    

    // This one is in "Leave" rather than "TextChanged" so that whenever we change the comment
    // while a capture is running, the unfinished string won't affect what the capture writes
    // to our output.
    private void txtTracelogComment_Leave(object sender, EventArgs e)
    {
        settings.CommentTextToAdd = txtTracelogComment.Text;
    }

    private void chkAddTLComments_CheckedChanged(object sender, EventArgs e)
    {
        settings.AddTracelogLabel = chkAddTLComments.Checked;
        txtTracelogComment.Enabled = chkAddTLComments.Checked;
    }

    private void chkRemoveTLComments_CheckedChanged(object sender, EventArgs e)
    {
        settings.RemoveTracelogLabels = chkRemoveTLComments.Checked;
    }

    private void chkCaptureLabelsOnly_CheckedChanged(object sender, EventArgs e)
    {
        settings.CaptureLabelsOnly = chkCaptureLabelsOnly.Checked;
    }

    private void BSNESTraceLogBinaryMonitorForm_Load(object sender, EventArgs e) => UpdateUi();
    private void BSNESTraceLogBinaryMonitorForm_Shown(object sender, EventArgs e) => UpdateUi();
    private void timer1_Tick(object sender, EventArgs e) => UpdateUi();
}