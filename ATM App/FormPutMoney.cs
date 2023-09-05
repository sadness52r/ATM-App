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
    public partial class FormPutMoney : Form
    {
        private User user;
        private Label labelBalance;
        private ListBox lBoxHistory;
        public FormPutMoney(User user, Label label, ListBox lBoxHistory)
        {
            InitializeComponent();
            this.user = user;
            this.lBoxHistory = lBoxHistory;
            labelBalance = label;
        }

        private void bPut_Click(object sender, EventArgs e)
        {
            MoneyController moneyController = new MoneyController(user);
            moneyController.TryTransaction(this, null, textBoxPutMoney.Text);
            if (labelBalance.Text != user.Money.ToString() + '$')
            {
                labelBalance.Text = user.Money.ToString() + '$';
                user.LastTransaction = DateTime.Now;
                user.TransactionsNumber++;
                user.TransactionsHistory.Add('[' + DateTime.Now.ToString() + ']' + " Replenishment for the amount: " + textBoxPutMoney.Text + "$. Your balance is " + user.Money);
                lBoxHistory.Items.Add(user.TransactionsHistory[user.TransactionsHistory.Count - 1]);
            }
        }

        private void FormPutMoney_Load(object sender, EventArgs e)
        {

        }
    }
}
