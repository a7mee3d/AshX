namespace AshX
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.GroupBox grpCharacters;
        private System.Windows.Forms.ComboBox cmbMain;
        private System.Windows.Forms.ComboBox cmbSecond;
        private System.Windows.Forms.Button btnSetMain;
        private System.Windows.Forms.Button btnSetSecond;
        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.Label lblSecond;

        private System.Windows.Forms.GroupBox grpOptions;
        private System.Windows.Forms.CheckBox chkEnableMirroring;
        private System.Windows.Forms.CheckBox chkEnableDelay;
        private System.Windows.Forms.Label lblDelay;
        private System.Windows.Forms.NumericUpDown numDelayMs;
        private System.Windows.Forms.CheckBox chkBlockChat;

        private System.Windows.Forms.GroupBox grpBlockedKeys;
        private System.Windows.Forms.ListBox lstBlockedKeys;
        private System.Windows.Forms.TextBox txtAddKey;
        private System.Windows.Forms.Button btnAddKey;
        private System.Windows.Forms.Button btnRemoveKey;

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lblStatus;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.grpCharacters = new System.Windows.Forms.GroupBox();
            this.cmbMain = new System.Windows.Forms.ComboBox();
            this.cmbSecond = new System.Windows.Forms.ComboBox();
            this.btnSetMain = new System.Windows.Forms.Button();
            this.btnSetSecond = new System.Windows.Forms.Button();
            this.lblMain = new System.Windows.Forms.Label();
            this.lblSecond = new System.Windows.Forms.Label();

            this.grpOptions = new System.Windows.Forms.GroupBox();
            this.chkEnableMirroring = new System.Windows.Forms.CheckBox();
            this.chkEnableDelay = new System.Windows.Forms.CheckBox();
            this.numDelayMs = new System.Windows.Forms.NumericUpDown();
            this.chkBlockChat = new System.Windows.Forms.CheckBox();

            this.grpBlockedKeys = new System.Windows.Forms.GroupBox();
            this.lstBlockedKeys = new System.Windows.Forms.ListBox();
            this.txtAddKey = new System.Windows.Forms.TextBox();
            this.btnAddKey = new System.Windows.Forms.Button();
            this.btnRemoveKey = new System.Windows.Forms.Button();

            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();

            // ============================================================
            // grpCharacters
            // ============================================================
            this.grpCharacters.Text = "Characters";
            this.grpCharacters.Location = new System.Drawing.Point(20, 20);
            this.grpCharacters.Size = new System.Drawing.Size(300, 150);

            this.lblMain.Text = "Main Window:";
            this.lblMain.Location = new System.Drawing.Point(15, 30);

            this.cmbMain.Location = new System.Drawing.Point(120, 27);
            this.cmbMain.Size = new System.Drawing.Size(150, 25);

            this.btnSetMain.Text = "Set Main";
            this.btnSetMain.Location = new System.Drawing.Point(120, 60);
            this.btnSetMain.Click += new System.EventHandler(this.btnSetMain_Click);

            this.lblSecond.Text = "Second Window:";
            this.lblSecond.Location = new System.Drawing.Point(15, 95);

            this.cmbSecond.Location = new System.Drawing.Point(120, 92);
            this.cmbSecond.Size = new System.Drawing.Size(150, 25);

            this.btnSetSecond.Text = "Set Second";
            this.btnSetSecond.Location = new System.Drawing.Point(120, 125);
            this.btnSetSecond.Click += new System.EventHandler(this.btnSetSecond_Click);

            this.grpCharacters.Controls.Add(this.lblMain);
            this.grpCharacters.Controls.Add(this.cmbMain);
            this.grpCharacters.Controls.Add(this.btnSetMain);
            this.grpCharacters.Controls.Add(this.lblSecond);
            this.grpCharacters.Controls.Add(this.cmbSecond);
            this.grpCharacters.Controls.Add(this.btnSetSecond);

            // ============================================================
            // grpOptions
            // ============================================================
            this.grpOptions.Text = "Options";
            this.grpOptions.Location = new System.Drawing.Point(20, 180);
            this.grpOptions.Size = new System.Drawing.Size(300, 150);

            this.chkEnableMirroring.Text = "Enable Mirroring";
            this.chkEnableMirroring.Location = new System.Drawing.Point(15, 30);

            this.chkEnableDelay.Text = "Enable Delay";
            this.chkEnableDelay.Location = new System.Drawing.Point(15, 60);

            this.numDelayMs.Location = new System.Drawing.Point(150, 60);
            this.numDelayMs.Maximum = 5000;
            this.numDelayMs.Minimum = 0;

            this.chkBlockChat.Text = "Block Chat (Enter)";
            this.chkBlockChat.Location = new System.Drawing.Point(15, 95);

            this.grpOptions.Controls.Add(this.chkEnableMirroring);
            this.grpOptions.Controls.Add(this.chkEnableDelay);
            this.grpOptions.Controls.Add(this.numDelayMs);
            this.grpOptions.Controls.Add(this.chkBlockChat);

            // ============================================================
            // grpOptions
            // ============================================================
            this.grpOptions = new System.Windows.Forms.GroupBox();
            this.chkEnableMirroring = new System.Windows.Forms.CheckBox();
            this.chkEnableDelay = new System.Windows.Forms.CheckBox();
            this.lblDelay = new System.Windows.Forms.Label();
            this.numDelayMs = new System.Windows.Forms.NumericUpDown();
            this.chkBlockChat = new System.Windows.Forms.CheckBox();

            this.grpOptions.Text = "Options";
            this.grpOptions.Location = new System.Drawing.Point(20, 180);
            this.grpOptions.Size = new System.Drawing.Size(300, 170);

            // Enable Mirroring
            this.chkEnableMirroring.Text = "Enable Mirroring";
            this.chkEnableMirroring.Location = new System.Drawing.Point(15, 30);
            this.chkEnableMirroring.Size = new System.Drawing.Size(200, 25);

            // Enable Delay
            this.chkEnableDelay.Text = "Enable Delay";
            this.chkEnableDelay.Location = new System.Drawing.Point(15, 60);
            this.chkEnableDelay.Size = new System.Drawing.Size(200, 25);

            // Delay Label
            this.lblDelay.Text = "Delay (seconds):";
            this.lblDelay.Location = new System.Drawing.Point(15, 95);
            this.lblDelay.Size = new System.Drawing.Size(120, 25);

            // Delay Numeric Box
            this.numDelayMs.Location = new System.Drawing.Point(150, 95);
            this.numDelayMs.Maximum = 10;
            this.numDelayMs.Minimum = 0;
            this.numDelayMs.DecimalPlaces = 1;   // allows 0.5 seconds
            this.numDelayMs.Increment = 0.1M;    // smooth control
            this.numDelayMs.Size = new System.Drawing.Size(80, 25);

            // Block Chat
            this.chkBlockChat.Text = "Block Chat (Enter)";
            this.chkBlockChat.Location = new System.Drawing.Point(15, 130);
            this.chkBlockChat.Size = new System.Drawing.Size(200, 25);

            // Add controls
            this.grpOptions.Controls.Add(this.chkEnableMirroring);
            this.grpOptions.Controls.Add(this.chkEnableDelay);
            this.grpOptions.Controls.Add(this.lblDelay);
            this.grpOptions.Controls.Add(this.numDelayMs);
            this.grpOptions.Controls.Add(this.chkBlockChat);


            // ============================================================
            // Start / Stop Buttons
            // ============================================================
            this.btnStart.Text = "Start";
            this.btnStart.Location = new System.Drawing.Point(20, 350);
            this.btnStart.Size = new System.Drawing.Size(140, 40);
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);

            this.btnStop.Text = "Stop";
            this.btnStop.Location = new System.Drawing.Point(180, 350);
            this.btnStop.Size = new System.Drawing.Size(140, 40);
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);

            // ============================================================
            // Status Label
            // ============================================================
            this.lblStatus.Text = "Status: Idle";
            this.lblStatus.Location = new System.Drawing.Point(20, 400);
            this.lblStatus.Size = new System.Drawing.Size(400, 30);
            this.lblStatus.ForeColor = System.Drawing.Color.White;

            // ============================================================
            // MainForm
            // ============================================================
            this.ClientSize = new System.Drawing.Size(620, 450);
            this.Controls.Add(this.grpCharacters);
            this.Controls.Add(this.grpOptions);
            this.Controls.Add(this.grpBlockedKeys);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.lblStatus);

            this.Text = "AshX — Multibox Controller";
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            ((System.ComponentModel.ISupportInitialize)(this.numDelayMs)).EndInit();
        }
    }
}
