namespace ATM_App
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            this.panelAccount = new System.Windows.Forms.Panel();
            this.bAccount = new System.Windows.Forms.Button();
            this.panelPutMoney = new System.Windows.Forms.Panel();
            this.bPutMoney = new System.Windows.Forms.Button();
            this.panelCashOut = new System.Windows.Forms.Panel();
            this.bCashOut = new System.Windows.Forms.Button();
            this.panelHistory = new System.Windows.Forms.Panel();
            this.listBoxHistory = new System.Windows.Forms.ListBox();
            this.flowLayoutPanelAccountSettings = new System.Windows.Forms.FlowLayoutPanel();
            this.panelChangePin = new System.Windows.Forms.Panel();
            this.bChangePin = new System.Windows.Forms.Button();
            this.panelExit = new System.Windows.Forms.Panel();
            this.bExit = new System.Windows.Forms.Button();
            this.labelTitleCardNumber = new System.Windows.Forms.Label();
            this.labelTitleBalance = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelCardNumber = new System.Windows.Forms.Label();
            this.labelBalance = new System.Windows.Forms.Label();
            this.panelAccount.SuspendLayout();
            this.panelPutMoney.SuspendLayout();
            this.panelCashOut.SuspendLayout();
            this.panelHistory.SuspendLayout();
            this.flowLayoutPanelAccountSettings.SuspendLayout();
            this.panelChangePin.SuspendLayout();
            this.panelExit.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAccount
            // 
            this.panelAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelAccount.Controls.Add(this.bAccount);
            this.panelAccount.Location = new System.Drawing.Point(0, 0);
            this.panelAccount.Margin = new System.Windows.Forms.Padding(0);
            this.panelAccount.Name = "panelAccount";
            this.panelAccount.Size = new System.Drawing.Size(131, 121);
            this.panelAccount.TabIndex = 0;
            // 
            // bAccount
            // 
            this.bAccount.BackgroundImage = global::ATM_App.Properties.Resources.ed_6shutterstock_151265393;
            this.bAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bAccount.Location = new System.Drawing.Point(0, 0);
            this.bAccount.Name = "bAccount";
            this.bAccount.Size = new System.Drawing.Size(131, 121);
            this.bAccount.TabIndex = 0;
            this.bAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bAccount.UseVisualStyleBackColor = true;
            this.bAccount.Click += new System.EventHandler(this.bAccount_Click);
            // 
            // panelPutMoney
            // 
            this.panelPutMoney.Controls.Add(this.bPutMoney);
            this.panelPutMoney.Location = new System.Drawing.Point(0, 1);
            this.panelPutMoney.Name = "panelPutMoney";
            this.panelPutMoney.Size = new System.Drawing.Size(472, 316);
            this.panelPutMoney.TabIndex = 1;
            // 
            // bPutMoney
            // 
            this.bPutMoney.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bPutMoney.Location = new System.Drawing.Point(0, 0);
            this.bPutMoney.Name = "bPutMoney";
            this.bPutMoney.Size = new System.Drawing.Size(472, 316);
            this.bPutMoney.TabIndex = 0;
            this.bPutMoney.Text = "PUT MONEY";
            this.bPutMoney.UseVisualStyleBackColor = true;
            this.bPutMoney.Click += new System.EventHandler(this.bPutMoney_Click);
            // 
            // panelCashOut
            // 
            this.panelCashOut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelCashOut.Controls.Add(this.bCashOut);
            this.panelCashOut.Location = new System.Drawing.Point(0, 323);
            this.panelCashOut.Name = "panelCashOut";
            this.panelCashOut.Size = new System.Drawing.Size(472, 298);
            this.panelCashOut.TabIndex = 2;
            // 
            // bCashOut
            // 
            this.bCashOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bCashOut.Location = new System.Drawing.Point(0, 0);
            this.bCashOut.Name = "bCashOut";
            this.bCashOut.Size = new System.Drawing.Size(472, 298);
            this.bCashOut.TabIndex = 1;
            this.bCashOut.Text = "CASH OUT";
            this.bCashOut.UseVisualStyleBackColor = true;
            this.bCashOut.Click += new System.EventHandler(this.bCashOut_Click);
            // 
            // panelHistory
            // 
            this.panelHistory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelHistory.Controls.Add(this.listBoxHistory);
            this.panelHistory.Location = new System.Drawing.Point(478, 323);
            this.panelHistory.Name = "panelHistory";
            this.panelHistory.Size = new System.Drawing.Size(880, 288);
            this.panelHistory.TabIndex = 3;
            // 
            // listBoxHistory
            // 
            this.listBoxHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxHistory.FormattingEnabled = true;
            this.listBoxHistory.Location = new System.Drawing.Point(0, 0);
            this.listBoxHistory.Name = "listBoxHistory";
            this.listBoxHistory.Size = new System.Drawing.Size(880, 288);
            this.listBoxHistory.TabIndex = 0;
            // 
            // flowLayoutPanelAccountSettings
            // 
            this.flowLayoutPanelAccountSettings.AllowDrop = true;
            this.flowLayoutPanelAccountSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelAccountSettings.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanelAccountSettings.Controls.Add(this.panelAccount);
            this.flowLayoutPanelAccountSettings.Controls.Add(this.panelChangePin);
            this.flowLayoutPanelAccountSettings.Controls.Add(this.panelExit);
            this.flowLayoutPanelAccountSettings.ForeColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanelAccountSettings.Location = new System.Drawing.Point(1227, 12);
            this.flowLayoutPanelAccountSettings.MaximumSize = new System.Drawing.Size(131, 305);
            this.flowLayoutPanelAccountSettings.MinimumSize = new System.Drawing.Size(131, 119);
            this.flowLayoutPanelAccountSettings.Name = "flowLayoutPanelAccountSettings";
            this.flowLayoutPanelAccountSettings.Size = new System.Drawing.Size(131, 119);
            this.flowLayoutPanelAccountSettings.TabIndex = 4;
            // 
            // panelChangePin
            // 
            this.panelChangePin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelChangePin.Controls.Add(this.bChangePin);
            this.panelChangePin.Location = new System.Drawing.Point(0, 121);
            this.panelChangePin.Margin = new System.Windows.Forms.Padding(0);
            this.panelChangePin.Name = "panelChangePin";
            this.panelChangePin.Size = new System.Drawing.Size(131, 121);
            this.panelChangePin.TabIndex = 1;
            // 
            // bChangePin
            // 
            this.bChangePin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bChangePin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bChangePin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bChangePin.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bChangePin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bChangePin.Location = new System.Drawing.Point(0, 0);
            this.bChangePin.Name = "bChangePin";
            this.bChangePin.Size = new System.Drawing.Size(131, 121);
            this.bChangePin.TabIndex = 0;
            this.bChangePin.Text = "Change PIN";
            this.bChangePin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bChangePin.UseVisualStyleBackColor = true;
            this.bChangePin.Click += new System.EventHandler(this.bChangePin_Click);
            // 
            // panelExit
            // 
            this.panelExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelExit.Controls.Add(this.bExit);
            this.panelExit.Location = new System.Drawing.Point(0, 242);
            this.panelExit.Margin = new System.Windows.Forms.Padding(0);
            this.panelExit.Name = "panelExit";
            this.panelExit.Size = new System.Drawing.Size(131, 63);
            this.panelExit.TabIndex = 2;
            // 
            // bExit
            // 
            this.bExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bExit.ForeColor = System.Drawing.Color.DarkRed;
            this.bExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bExit.Location = new System.Drawing.Point(0, 0);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(131, 63);
            this.bExit.TabIndex = 0;
            this.bExit.Text = "Exit";
            this.bExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bExit.UseVisualStyleBackColor = true;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // labelTitleCardNumber
            // 
            this.labelTitleCardNumber.AutoSize = true;
            this.labelTitleCardNumber.Location = new System.Drawing.Point(1017, 30);
            this.labelTitleCardNumber.Name = "labelTitleCardNumber";
            this.labelTitleCardNumber.Size = new System.Drawing.Size(70, 13);
            this.labelTitleCardNumber.TabIndex = 5;
            this.labelTitleCardNumber.Text = "Card number:";
            // 
            // labelTitleBalance
            // 
            this.labelTitleBalance.AutoSize = true;
            this.labelTitleBalance.Location = new System.Drawing.Point(1017, 66);
            this.labelTitleBalance.Name = "labelTitleBalance";
            this.labelTitleBalance.Size = new System.Drawing.Size(49, 13);
            this.labelTitleBalance.TabIndex = 6;
            this.labelTitleBalance.Text = "Balance:";
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelCardNumber
            // 
            this.labelCardNumber.AutoSize = true;
            this.labelCardNumber.Location = new System.Drawing.Point(1133, 30);
            this.labelCardNumber.Name = "labelCardNumber";
            this.labelCardNumber.Size = new System.Drawing.Size(0, 13);
            this.labelCardNumber.TabIndex = 7;
            // 
            // labelBalance
            // 
            this.labelBalance.AutoSize = true;
            this.labelBalance.Location = new System.Drawing.Point(1133, 66);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(19, 13);
            this.labelBalance.TabIndex = 8;
            this.labelBalance.Text = "0$";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 623);
            this.Controls.Add(this.labelBalance);
            this.Controls.Add(this.labelCardNumber);
            this.Controls.Add(this.labelTitleBalance);
            this.Controls.Add(this.labelTitleCardNumber);
            this.Controls.Add(this.flowLayoutPanelAccountSettings);
            this.Controls.Add(this.panelHistory);
            this.Controls.Add(this.panelCashOut);
            this.Controls.Add(this.panelPutMoney);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelAccount.ResumeLayout(false);
            this.panelPutMoney.ResumeLayout(false);
            this.panelCashOut.ResumeLayout(false);
            this.panelHistory.ResumeLayout(false);
            this.flowLayoutPanelAccountSettings.ResumeLayout(false);
            this.panelChangePin.ResumeLayout(false);
            this.panelExit.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelAccount;
        private System.Windows.Forms.Panel panelPutMoney;
        private System.Windows.Forms.Button bPutMoney;
        private System.Windows.Forms.Panel panelCashOut;
        private System.Windows.Forms.Button bCashOut;
        private System.Windows.Forms.Panel panelHistory;
        private System.Windows.Forms.ListBox listBoxHistory;
        private System.Windows.Forms.Button bAccount;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelAccountSettings;
        private System.Windows.Forms.Panel panelChangePin;
        private System.Windows.Forms.Button bChangePin;
        private System.Windows.Forms.Label labelTitleCardNumber;
        private System.Windows.Forms.Label labelTitleBalance;
        private System.Windows.Forms.Panel panelExit;
        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelCardNumber;
        private System.Windows.Forms.Label labelBalance;
    }
}