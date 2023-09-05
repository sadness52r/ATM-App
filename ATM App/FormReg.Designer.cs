namespace ATM_App
{
    partial class FormReg
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReg));
            this.textBoxCardNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bEnter = new System.Windows.Forms.Button();
            this.textBoxPin = new System.Windows.Forms.TextBox();
            this.bShowPin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxCardNumber
            // 
            this.textBoxCardNumber.Font = new System.Drawing.Font("Trebuchet MS", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCardNumber.Location = new System.Drawing.Point(149, 143);
            this.textBoxCardNumber.Multiline = true;
            this.textBoxCardNumber.Name = "textBoxCardNumber";
            this.textBoxCardNumber.Size = new System.Drawing.Size(491, 57);
            this.textBoxCardNumber.TabIndex = 0;
            this.textBoxCardNumber.Enter += new System.EventHandler(this.textBoxCardNumber_Enter);
            this.textBoxCardNumber.Leave += new System.EventHandler(this.textBoxCardNumber_Leave);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Orbitron", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(142, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(523, 42);
            this.label1.TabIndex = 4;
            this.label1.Text = "Please, register your card";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bEnter
            // 
            this.bEnter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bEnter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bEnter.Location = new System.Drawing.Point(265, 346);
            this.bEnter.Name = "bEnter";
            this.bEnter.Size = new System.Drawing.Size(293, 60);
            this.bEnter.TabIndex = 5;
            this.bEnter.Text = "Enter";
            this.bEnter.UseVisualStyleBackColor = true;
            this.bEnter.Click += new System.EventHandler(this.bEnter_Click);
            // 
            // textBoxPin
            // 
            this.textBoxPin.Font = new System.Drawing.Font("Trebuchet MS", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPin.Location = new System.Drawing.Point(149, 235);
            this.textBoxPin.Name = "textBoxPin";
            this.textBoxPin.Size = new System.Drawing.Size(491, 50);
            this.textBoxPin.TabIndex = 6;
            this.textBoxPin.Enter += new System.EventHandler(this.textBoxPin_Enter);
            this.textBoxPin.Leave += new System.EventHandler(this.textBoxPin_Leave);
            // 
            // bShowPin
            // 
            this.bShowPin.BackgroundImage = global::ATM_App.Properties.Resources.eye;
            this.bShowPin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bShowPin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bShowPin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bShowPin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bShowPin.Location = new System.Drawing.Point(669, 250);
            this.bShowPin.Name = "bShowPin";
            this.bShowPin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bShowPin.Size = new System.Drawing.Size(41, 32);
            this.bShowPin.TabIndex = 7;
            this.bShowPin.UseVisualStyleBackColor = true;
            this.bShowPin.Click += new System.EventHandler(this.bShowPin_Click);
            // 
            // FormReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bShowPin);
            this.Controls.Add(this.textBoxPin);
            this.Controls.Add(this.bEnter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCardNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormReg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.FormReg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCardNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bEnter;
        private System.Windows.Forms.TextBox textBoxPin;
        private System.Windows.Forms.Button bShowPin;
    }
}

