namespace ATM_App
{
    partial class FormCashOut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCashOut));
            this.labelCashOut = new System.Windows.Forms.Label();
            this.textBoxCashOut = new System.Windows.Forms.TextBox();
            this.bCashOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelCashOut
            // 
            this.labelCashOut.AutoSize = true;
            this.labelCashOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCashOut.Location = new System.Drawing.Point(555, 9);
            this.labelCashOut.Name = "labelCashOut";
            this.labelCashOut.Size = new System.Drawing.Size(428, 25);
            this.labelCashOut.TabIndex = 2;
            this.labelCashOut.Text = "How much money do you want to cash out?";
            // 
            // textBoxCashOut
            // 
            this.textBoxCashOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCashOut.Location = new System.Drawing.Point(535, 50);
            this.textBoxCashOut.Name = "textBoxCashOut";
            this.textBoxCashOut.Size = new System.Drawing.Size(449, 47);
            this.textBoxCashOut.TabIndex = 3;
            // 
            // bCashOut
            // 
            this.bCashOut.Location = new System.Drawing.Point(677, 111);
            this.bCashOut.Name = "bCashOut";
            this.bCashOut.Size = new System.Drawing.Size(164, 23);
            this.bCashOut.TabIndex = 4;
            this.bCashOut.Text = "CASH OUT";
            this.bCashOut.UseVisualStyleBackColor = true;
            this.bCashOut.Click += new System.EventHandler(this.bCashOut_Click);
            // 
            // FormCashOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(1518, 146);
            this.Controls.Add(this.bCashOut);
            this.Controls.Add(this.textBoxCashOut);
            this.Controls.Add(this.labelCashOut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormCashOut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCashOut";
            this.Load += new System.EventHandler(this.FormCashOut_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCashOut;
        private System.Windows.Forms.TextBox textBoxCashOut;
        private System.Windows.Forms.Button bCashOut;
    }
}