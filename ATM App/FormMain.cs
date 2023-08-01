using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_App
{
    public partial class FormMain : Form
    {
        private bool isExpand = false;
        private User user;
        private FormReg formReg;
        private DropDownController ddController;
        private AccountController accController;
        public FormMain(User user, FormReg parentForm, AccountController accController)
        {
            InitializeComponent();
            this.user = user;
            formReg = parentForm;
            this.accController = accController;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            ddController = new DropDownController(isExpand, flowLayoutPanelAccountSettings.MaximumSize.Height, flowLayoutPanelAccountSettings.MinimumSize.Height);
            labelCardNumber.Text = user.CardNumber;
            labelBalance.Text = user.Money.ToString() + '$';
            foreach (var transaction in user.TransactionsHistory)
                listBoxHistory.Items.Add(transaction);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!ddController.IsExpand)
                ddController.Open(ref flowLayoutPanelAccountSettings, timer1);
            else
                ddController.Close(ref flowLayoutPanelAccountSettings, timer1);
        }

        private void bAccount_Click(object sender, EventArgs e) => timer1.Start();

        private void bPutMoney_Click(object sender, EventArgs e)
        {
            FormPutMoney formPutMoney = new FormPutMoney(user, labelBalance, listBoxHistory);
            formPutMoney.ShowDialog();
        }

        private void bCashOut_Click(object sender, EventArgs e)
        {
            FormCashOut formCashOut = new FormCashOut(user, labelBalance, listBoxHistory);
            formCashOut.ShowDialog();
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            formReg.Show();
            this.Hide();
        }

        private void bChangePin_Click(object sender, EventArgs e)
        {
            FormChangePin formChangePin = new FormChangePin(accController, user);
            formChangePin.ShowDialog();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            JsonManager.SerializeData(accController.Users.GetType(), accController.Users, "users.json");
        }
    }
}
