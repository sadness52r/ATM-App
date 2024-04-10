using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using Newtonsoft.Json;
using System.IO;
using System.Text;

using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_App
{
    public partial class FormReg : Form
    {
        private bool isShowedPin = false;
        AccountController accController = new AccountController();

        public FormReg()
        {
            InitializeComponent();
        }

        private void FormReg_Load(object sender, EventArgs e)
        {
            accController.Users = File.Exists("users.json") ? JsonConvert.DeserializeObject<List<User>>(File.ReadAllText("users.json")) : new List<User>();

            textBoxCardNumber.Text = "Enter your card number";
            textBoxPin.Text = "Enter your pin code";
            textBoxCardNumber.ForeColor = textBoxPin.ForeColor = Color.Gray;
        }

        private void ChangeTBContent(ref TextBox text_box, Color color, string change_text)
        {
            text_box.Text = change_text;
            text_box.ForeColor = color;
        }

        private bool ChangeViewPin(ref Button bShowPin, bool isShowedPin, string img_path)
        {
            bShowPin.BackgroundImage = Image.FromFile(img_path);
            isShowedPin = !this.isShowedPin;
            if (textBoxPin.Text != "Enter your pin code")
                textBoxPin.UseSystemPasswordChar = this.isShowedPin;

            return isShowedPin;
        }

        private void bEnter_Click(object sender, EventArgs e)
        {
            accController.TryRegister(this, textBoxCardNumber.Text, textBoxPin.Text);
        }

        private void textBoxCardNumber_Enter(object sender, EventArgs e)
        {
            if (textBoxCardNumber.Text == "Enter your card number" || textBoxCardNumber.TextLength == 0)
                ChangeTBContent(ref textBoxCardNumber, Color.Black, null);
        }

        private void textBoxCardNumber_Leave(object sender, EventArgs e)
        {
            if (textBoxCardNumber.TextLength == 0)
                ChangeTBContent(ref textBoxCardNumber, Color.Gray, "Enter your card number");
        }

        private void textBoxPin_Enter(object sender, EventArgs e)
        {
            if (!isShowedPin)
                textBoxPin.UseSystemPasswordChar = true;

            if (textBoxPin.Text == "Enter your pin code" || textBoxPin.TextLength == 0)
                ChangeTBContent(ref textBoxPin, Color.Black, null);
        }

        private void textBoxPin_Leave(object sender, EventArgs e)
        {
            if (textBoxPin.TextLength == 0)
            {
                ChangeTBContent(ref textBoxPin, Color.Gray, "Enter your pin code");

                if (!isShowedPin)
                    textBoxPin.UseSystemPasswordChar = false;
            }
        }

        private void bShowPin_Click(object sender, EventArgs e)
        {
            if (isShowedPin)
                isShowedPin = ChangeViewPin(ref bShowPin, isShowedPin, AppDomain.CurrentDomain.BaseDirectory +
                    @"..\..\Materials\eye.png");
            else
                isShowedPin = ChangeViewPin(ref bShowPin, isShowedPin, AppDomain.CurrentDomain.BaseDirectory +
                    @"..\..\Materials\eye_closed.png");
        }
    }
}
