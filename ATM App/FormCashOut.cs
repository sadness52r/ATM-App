using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_App
{
    [DataContract]
    public partial class FormCashOut : Form
    {
        private User user;
        private Label labelBalance;
        [DataMember] private ListBox lBoxHistory;

        public FormCashOut(User user, Label label, ListBox lBoxHistory)
        {
            InitializeComponent();
            this.user = user;
            this.lBoxHistory = lBoxHistory;
            labelBalance = label;
        }

        private void bCashOut_Click(object sender, EventArgs e)
        {
            MoneyController moneyController = new MoneyController(user);
            moneyController.CashOut(textBoxCashOut.Text);
            if (labelBalance.Text != user.Money.ToString() + '$')
            {
                labelBalance.Text = user.Money.ToString() + '$';
                user.TransactionsHistory.Add('[' + DateTime.Now.ToString() + ']' + " Cash out for the amount: " + textBoxCashOut.Text + "$. Your balance is " + user.Money);
                lBoxHistory.Items.Add(user.TransactionsHistory[user.TransactionsHistory.Count - 1]);
            }
        }
    }
}
