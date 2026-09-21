namespace Diz.Ui.Winforms.dialogs
{
    partial class BsnesTraceLogBinaryMonitorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BsnesTraceLogBinaryMonitorForm));
            btnStart = new Button();
            label1 = new Label();
            lblQueueSize = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            btnFinish = new Button();
            lblTotalProcessed = new Label();
            label4 = new Label();
            lblStatus = new Label();
            label5 = new Label();
            lblNumberModified = new Label();
            label3 = new Label();
            lblModifiedXFlags = new Label();
            label6 = new Label();
            lblModifiedMFlags = new Label();
            label8 = new Label();
            lblModifiedDPs = new Label();
            label10 = new Label();
            lblModifiedDBs = new Label();
            label12 = new Label();
            lblModifiedFlags = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            lblResultStatus = new Label();
            label7 = new Label();
            pictureSpinnerResult = new PictureBox();
            button1 = new Button();
            chkAddTLComments = new CheckBox();
            chkRemoveTLComments = new CheckBox();
            txtTracelogComment = new TextBox();
            label2 = new Label();
            label11 = new Label();
            chkCaptureLabelsOnly = new CheckBox();
            textBoxConnectionHost = new TextBox();
            label13 = new Label();
            label18 = new Label();
            numericUpDownConnectionPort = new NumericUpDown();
            label19 = new Label();
            pictureSpinnerStatus = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureSpinnerResult).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownConnectionPort).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureSpinnerStatus).BeginInit();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.Location = new Point(661, 14);
            btnStart.Margin = new Padding(4, 3, 4, 3);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(75, 44);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start Capture";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 153);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 1;
            label1.Text = "Queue size";
            // 
            // lblQueueSize
            // 
            lblQueueSize.AutoSize = true;
            lblQueueSize.Location = new Point(174, 153);
            lblQueueSize.Margin = new Padding(4, 0, 4, 0);
            lblQueueSize.Name = "lblQueueSize";
            lblQueueSize.Size = new Size(17, 15);
            lblQueueSize.TabIndex = 2;
            lblQueueSize.Text = "--";
            // 
            // timer1
            // 
            timer1.Interval = 250;
            timer1.Tick += timer1_Tick;
            // 
            // btnFinish
            // 
            btnFinish.Enabled = false;
            btnFinish.Location = new Point(585, 14);
            btnFinish.Margin = new Padding(4, 3, 4, 3);
            btnFinish.Name = "btnFinish";
            btnFinish.Size = new Size(69, 44);
            btnFinish.TabIndex = 3;
            btnFinish.Text = "Stop Capture";
            btnFinish.UseVisualStyleBackColor = true;
            btnFinish.Click += btnFinish_Click;
            // 
            // lblTotalProcessed
            // 
            lblTotalProcessed.AutoSize = true;
            lblTotalProcessed.Location = new Point(490, 127);
            lblTotalProcessed.Margin = new Padding(4, 0, 4, 0);
            lblTotalProcessed.Name = "lblTotalProcessed";
            lblTotalProcessed.Size = new Size(17, 15);
            lblTotalProcessed.TabIndex = 6;
            lblTotalProcessed.Text = "--";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(344, 127);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(130, 15);
            label4.TabIndex = 5;
            label4.Text = "# Instructions Analyzed";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(174, 127);
            lblStatus.Margin = new Padding(4, 0, 4, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(17, 15);
            lblStatus.TabIndex = 8;
            lblStatus.Text = "--";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 127);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 7;
            label5.Text = "Status";
            // 
            // lblNumberModified
            // 
            lblNumberModified.AutoSize = true;
            lblNumberModified.Location = new Point(490, 153);
            lblNumberModified.Margin = new Padding(4, 0, 4, 0);
            lblNumberModified.Name = "lblNumberModified";
            lblNumberModified.Size = new Size(17, 15);
            lblNumberModified.TabIndex = 10;
            lblNumberModified.Text = "--";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(344, 153);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(130, 15);
            label3.TabIndex = 9;
            label3.Text = "# Instructions Modified";
            // 
            // lblModifiedXFlags
            // 
            lblModifiedXFlags.AutoSize = true;
            lblModifiedXFlags.Location = new Point(174, 234);
            lblModifiedXFlags.Margin = new Padding(4, 0, 4, 0);
            lblModifiedXFlags.Name = "lblModifiedXFlags";
            lblModifiedXFlags.Size = new Size(17, 15);
            lblModifiedXFlags.TabIndex = 12;
            lblModifiedXFlags.Text = "--";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 234);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(44, 15);
            label6.TabIndex = 11;
            label6.Text = "X Flags";
            // 
            // lblModifiedMFlags
            // 
            lblModifiedMFlags.AutoSize = true;
            lblModifiedMFlags.Location = new Point(174, 262);
            lblModifiedMFlags.Margin = new Padding(4, 0, 4, 0);
            lblModifiedMFlags.Name = "lblModifiedMFlags";
            lblModifiedMFlags.Size = new Size(17, 15);
            lblModifiedMFlags.TabIndex = 14;
            lblModifiedMFlags.Text = "--";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(18, 262);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(48, 15);
            label8.TabIndex = 13;
            label8.Text = "M Flags";
            // 
            // lblModifiedDPs
            // 
            lblModifiedDPs.AutoSize = true;
            lblModifiedDPs.Location = new Point(174, 288);
            lblModifiedDPs.Margin = new Padding(4, 0, 4, 0);
            lblModifiedDPs.Name = "lblModifiedDPs";
            lblModifiedDPs.Size = new Size(17, 15);
            lblModifiedDPs.TabIndex = 16;
            lblModifiedDPs.Text = "--";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(18, 288);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(67, 15);
            label10.TabIndex = 15;
            label10.Text = "Direct Page";
            // 
            // lblModifiedDBs
            // 
            lblModifiedDBs.AutoSize = true;
            lblModifiedDBs.Location = new Point(174, 315);
            lblModifiedDBs.Margin = new Padding(4, 0, 4, 0);
            lblModifiedDBs.Name = "lblModifiedDBs";
            lblModifiedDBs.Size = new Size(17, 15);
            lblModifiedDBs.TabIndex = 18;
            lblModifiedDBs.Text = "--";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(18, 315);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(60, 15);
            label12.TabIndex = 17;
            label12.Text = "Data Bank";
            // 
            // lblModifiedFlags
            // 
            lblModifiedFlags.AutoSize = true;
            lblModifiedFlags.Location = new Point(174, 208);
            lblModifiedFlags.Margin = new Padding(4, 0, 4, 0);
            lblModifiedFlags.Name = "lblModifiedFlags";
            lblModifiedFlags.Size = new Size(17, 15);
            lblModifiedFlags.TabIndex = 20;
            lblModifiedFlags.Text = "--";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(18, 208);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(139, 15);
            label14.TabIndex = 19;
            label14.Text = "# Instructions Uncovered";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            label15.Location = new Point(14, 184);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(194, 13);
            label15.TabIndex = 21;
            label15.Text = "Data Uncovered (#modifications)";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            label16.Location = new Point(14, 103);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(124, 13);
            label16.TabIndex = 22;
            label16.Text = "Emulator Connection";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            label17.Location = new Point(340, 103);
            label17.Margin = new Padding(4, 0, 4, 0);
            label17.Name = "label17";
            label17.Size = new Size(57, 13);
            label17.TabIndex = 23;
            label17.Text = "Summary";
            // 
            // lblResultStatus
            // 
            lblResultStatus.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblResultStatus.Location = new Point(70, 14);
            lblResultStatus.Margin = new Padding(4, 0, 4, 0);
            lblResultStatus.Name = "lblResultStatus";
            lblResultStatus.Size = new Size(379, 75);
            lblResultStatus.TabIndex = 26;
            lblResultStatus.Text = resources.GetString("lblResultStatus.Text");
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            label7.Location = new Point(15, 14);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(43, 13);
            label7.TabIndex = 25;
            label7.Text = "Result";
            // 
            // pictureSpinnerResult
            // 
            pictureSpinnerResult.Image = Properties.Resources._1603231497loading_green;
            pictureSpinnerResult.Location = new Point(67, 9);
            pictureSpinnerResult.Margin = new Padding(4, 3, 4, 3);
            pictureSpinnerResult.Name = "pictureSpinnerResult";
            pictureSpinnerResult.Size = new Size(41, 25);
            pictureSpinnerResult.SizeMode = PictureBoxSizeMode.Zoom;
            pictureSpinnerResult.TabIndex = 27;
            pictureSpinnerResult.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(517, 14);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(61, 44);
            button1.TabIndex = 28;
            button1.Text = "Help";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnTracelogHelpClick;
            // 
            // chkAddTLComments
            // 
            chkAddTLComments.AutoSize = true;
            chkAddTLComments.Location = new Point(22, 490);
            chkAddTLComments.Name = "chkAddTLComments";
            chkAddTLComments.Size = new Size(284, 19);
            chkAddTLComments.TabIndex = 30;
            chkAddTLComments.Text = "Add below comment to any instruction executed";
            chkAddTLComments.UseVisualStyleBackColor = true;
            chkAddTLComments.CheckedChanged += chkAddTLComments_CheckedChanged;
            // 
            // chkRemoveTLComments
            // 
            chkRemoveTLComments.AutoSize = true;
            chkRemoveTLComments.Location = new Point(22, 449);
            chkRemoveTLComments.Name = "chkRemoveTLComments";
            chkRemoveTLComments.Size = new Size(358, 19);
            chkRemoveTLComments.TabIndex = 31;
            chkRemoveTLComments.Text = "Remove ANY tracelog comment from any executed instruction";
            chkRemoveTLComments.UseVisualStyleBackColor = true;
            chkRemoveTLComments.CheckedChanged += chkRemoveTLComments_CheckedChanged;
            // 
            // txtTracelogComment
            // 
            txtTracelogComment.Location = new Point(22, 515);
            txtTracelogComment.Name = "txtTracelogComment";
            txtTracelogComment.Size = new Size(348, 23);
            txtTracelogComment.TabIndex = 32;
            txtTracelogComment.TextChanged += txtTracelogComment_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(394, 448);
            label2.Name = "label2";
            label2.Size = new Size(307, 90);
            label2.TabIndex = 33;
            label2.Text = resources.GetString("label2.Text");
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(24, 471);
            label11.Name = "label11";
            label11.Size = new Size(68, 15);
            label11.TabIndex = 35;
            label11.Text = "(and then..)";
            // 
            // chkCaptureLabelsOnly
            // 
            chkCaptureLabelsOnly.AutoSize = true;
            chkCaptureLabelsOnly.Location = new Point(22, 424);
            chkCaptureLabelsOnly.Name = "chkCaptureLabelsOnly";
            chkCaptureLabelsOnly.Size = new Size(200, 19);
            chkCaptureLabelsOnly.TabIndex = 36;
            chkCaptureLabelsOnly.Text = "Capture labels only (ignore flags)";
            chkCaptureLabelsOnly.UseVisualStyleBackColor = true;
            chkCaptureLabelsOnly.CheckedChanged += chkCaptureLabelsOnly_CheckedChanged;
            // 
            // textBoxConnectionHost
            // 
            textBoxConnectionHost.Location = new Point(59, 391);
            textBoxConnectionHost.Name = "textBoxConnectionHost";
            textBoxConnectionHost.Size = new Size(174, 23);
            textBoxConnectionHost.TabIndex = 37;
            textBoxConnectionHost.Text = "localhost";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(18, 394);
            label13.Name = "label13";
            label13.Size = new Size(35, 15);
            label13.TabIndex = 39;
            label13.Text = "Host:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(253, 394);
            label18.Name = "label18";
            label18.Size = new Size(32, 15);
            label18.TabIndex = 40;
            label18.Text = "Port:";
            // 
            // numericUpDownConnectionPort
            // 
            numericUpDownConnectionPort.Location = new Point(291, 392);
            numericUpDownConnectionPort.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            numericUpDownConnectionPort.Name = "numericUpDownConnectionPort";
            numericUpDownConnectionPort.Size = new Size(75, 23);
            numericUpDownConnectionPort.TabIndex = 41;
            numericUpDownConnectionPort.Value = new decimal(new int[] { 27015, 0, 0, 0 });
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Underline);
            label19.Location = new Point(11, 366);
            label19.Margin = new Padding(4, 0, 4, 0);
            label19.Name = "label19";
            label19.Size = new Size(66, 20);
            label19.TabIndex = 42;
            label19.Text = "Settings";
            // 
            // pictureSpinnerStatus
            // 
            pictureSpinnerStatus.Image = Properties.Resources._1603231497loading_green;
            pictureSpinnerStatus.Location = new Point(155, 123);
            pictureSpinnerStatus.Margin = new Padding(4, 3, 4, 3);
            pictureSpinnerStatus.Name = "pictureSpinnerStatus";
            pictureSpinnerStatus.Size = new Size(16, 25);
            pictureSpinnerStatus.SizeMode = PictureBoxSizeMode.Zoom;
            pictureSpinnerStatus.TabIndex = 43;
            pictureSpinnerStatus.TabStop = false;
            // 
            // BsnesTraceLogBinaryMonitorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(749, 557);
            Controls.Add(pictureSpinnerStatus);
            Controls.Add(label19);
            Controls.Add(numericUpDownConnectionPort);
            Controls.Add(label18);
            Controls.Add(label13);
            Controls.Add(textBoxConnectionHost);
            Controls.Add(chkCaptureLabelsOnly);
            Controls.Add(label11);
            Controls.Add(label2);
            Controls.Add(txtTracelogComment);
            Controls.Add(chkRemoveTLComments);
            Controls.Add(chkAddTLComments);
            Controls.Add(button1);
            Controls.Add(pictureSpinnerResult);
            Controls.Add(lblResultStatus);
            Controls.Add(label7);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(lblModifiedFlags);
            Controls.Add(label14);
            Controls.Add(lblModifiedDBs);
            Controls.Add(label12);
            Controls.Add(lblModifiedDPs);
            Controls.Add(label10);
            Controls.Add(lblModifiedMFlags);
            Controls.Add(label8);
            Controls.Add(lblModifiedXFlags);
            Controls.Add(label6);
            Controls.Add(lblNumberModified);
            Controls.Add(label3);
            Controls.Add(lblStatus);
            Controls.Add(label5);
            Controls.Add(lblTotalProcessed);
            Controls.Add(label4);
            Controls.Add(btnFinish);
            Controls.Add(lblQueueSize);
            Controls.Add(label1);
            Controls.Add(btnStart);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 3, 4, 3);
            Name = "BsnesTraceLogBinaryMonitorForm";
            Text = "Emulator Live Tracelog Capture";
            Load += BSNESTraceLogBinaryMonitorForm_Load;
            Shown += BSNESTraceLogBinaryMonitorForm_Shown;
            ((System.ComponentModel.ISupportInitialize)pictureSpinnerResult).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownConnectionPort).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureSpinnerStatus).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblQueueSize;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Label lblTotalProcessed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblNumberModified;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblModifiedXFlags;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblModifiedMFlags;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblModifiedDPs;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblModifiedDBs;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblModifiedFlags;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblResultStatus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureSpinnerResult;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox chkAddTLComments;
        private System.Windows.Forms.CheckBox chkRemoveTLComments;
        private System.Windows.Forms.TextBox txtTracelogComment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox chkCaptureLabelsOnly;
        private TextBox textBoxConnectionHost;
        private Label label13;
        private Label label18;
        private NumericUpDown numericUpDownConnectionPort;
        private Label label19;
        private PictureBox pictureSpinnerStatus;
        // private LiveCharts.WinForms.CartesianChart cartesianChart1;
    }
}