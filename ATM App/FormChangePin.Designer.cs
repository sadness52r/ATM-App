namespace ATM_App
{
    partial class FormChangePin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChangePin));
            this.labelChangePin = new System.Windows.Forms.Label();
            this.textBoxChangePin = new System.Windows.Forms.TextBox();
            this.bChangePin = new System.Windows.Forms.Button();
            this.bShowPin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelChangePin
            // 
            this.labelChangePin.AutoSize = true;
            this.labelChangePin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelChangePin.Location = new System.Drawing.Point(696, 9);
            this.labelChangePin.Name = "labelChangePin";
            this.labelChangePin.Size = new System.Drawing.Size(127, 25);
            this.labelChangePin.TabIndex = 2;
            this.labelChangePin.Text = "Change PIN";
            // 
            // textBoxChangePin
            // 
            this.textBoxChangePin.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxChangePin.Location = new System.Drawing.Point(535, 50);
            this.textBoxChangePin.Name = "textBoxChangePin";
            this.textBoxChangePin.Size = new System.Drawing.Size(449, 47);
            this.textBoxChangePin.TabIndex = 3;
            this.textBoxChangePin.UseSystemPasswordChar = true;
            // 
            // bChangePin
            // 
            this.bChangePin.Location = new System.Drawing.Point(676, 111);
            this.bChangePin.Name = "bChangePin";
            this.bChangePin.Size = new System.Drawing.Size(164, 23);
            this.bChangePin.TabIndex = 4;
            this.bChangePin.Text = "CHANGE PIN";
            this.bChangePin.UseVisualStyleBackColor = true;
            this.bChangePin.Click += new System.EventHandler(this.bChangePin_Click);
            // 
            // bShowPin
            // 
            this.bShowPin.BackgroundImage = global::ATM_App.Properties.Resources.eye;
            this.bShowPin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bShowPin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bShowPin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bShowPin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bShowPin.Location = new System.Drawing.Point(1023, 62);
            this.bShowPin.Name = "bShowPin";
            this.bShowPin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bShowPin.Size = new System.Drawing.Size(44, 35);
            this.bShowPin.TabIndex = 8;
            this.bShowPin.UseVisualStyleBackColor = true;
            this.bShowPin.Click += new System.EventHandler(this.bShowPin_Click);
            // 
            // FormChangePin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(1518, 146);
            this.Controls.Add(this.bShowPin);
            this.Controls.Add(this.bChangePin);
            this.Controls.Add(this.textBoxChangePin);
            this.Controls.Add(this.labelChangePin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormChangePin";
            this.Text = "FormChangePin";
            this.Load += new System.EventHandler(this.FormChangePin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelChangePin;
        private System.Windows.Forms.TextBox textBoxChangePin;
        private System.Windows.Forms.Button bChangePin;
        private System.Windows.Forms.Button bShowPin;
    }
}