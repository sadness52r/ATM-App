using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_App
{
    public partial class FormChangePin : Form
    {
        private bool isShowedPin = false;
        private AccountController accController;
        private User user;

        public FormChangePin(AccountController accController, User user)
        {
            InitializeComponent();
            this.accController = accController;
            this.user = user;
        }

        private bool ChangeViewPin(ref Button bShowPin, bool isShowedPin, string img_path)
        {
            bShowPin.BackgroundImage = Image.FromFile(img_path);
            isShowedPin = !this.isShowedPin;
            textBoxChangePin.UseSystemPasswordChar = this.isShowedPin;
            return isShowedPin;
        }
        private void bShowPin_Click(object sender, EventArgs e)
        {
            if (isShowedPin)
                isShowedPin = ChangeViewPin(ref bShowPin, isShowedPin, @"A:\Проекты VB\ATM App\ATM App\Materials\eye.png");
            else
                isShowedPin = ChangeViewPin(ref bShowPin, isShowedPin, @"A:\Проекты VB\ATM App\ATM App\Materials\eye_closed.png");
        }
        private void bChangePin_Click(object sender, EventArgs e)
        {
            accController.ChangePin(textBoxChangePin.Text, user.CardNumber, user.PinCode);
        }
    }
}
