namespace ATM_App
{
    partial class FormPutMoney
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPutMoney));
            this.textBoxPutMoney = new System.Windows.Forms.TextBox();
            this.labelPutMoney = new System.Windows.Forms.Label();
            this.bPut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxPutMoney
            // 
            this.textBoxPutMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPutMoney.Location = new System.Drawing.Point(523, 47);
            this.textBoxPutMoney.Name = "textBoxPutMoney";
            this.textBoxPutMoney.Size = new System.Drawing.Size(449, 47);
            this.textBoxPutMoney.TabIndex = 0;
            // 
            // labelPutMoney
            // 
            this.labelPutMoney.AutoSize = true;
            this.labelPutMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPutMoney.Location = new System.Drawing.Point(560, 9);
            this.labelPutMoney.Name = "labelPutMoney";
            this.labelPutMoney.Size = new System.Drawing.Size(376, 25);
            this.labelPutMoney.TabIndex = 1;
            this.labelPutMoney.Text = "How much money do you want to put?";
            // 
            // bPut
            // 
            this.bPut.Location = new System.Drawing.Point(671, 111);
            this.bPut.Name = "bPut";
            this.bPut.Size = new System.Drawing.Size(164, 23);
            this.bPut.TabIndex = 2;
            this.bPut.Text = "PUT";
            this.bPut.UseVisualStyleBackColor = true;
            this.bPut.Click += new System.EventHandler(this.bPut_Click);
            // 
            // FormPutMoney
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(1518, 146);
            this.Controls.Add(this.bPut);
            this.Controls.Add(this.labelPutMoney);
            this.Controls.Add(this.textBoxPutMoney);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormPutMoney";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPutMoney";
            this.Load += new System.EventHandler(this.FormPutMoney_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPutMoney;
        private System.Windows.Forms.Label labelPutMoney;
        private System.Windows.Forms.Button bPut;
    }
}