using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_App
{
    public class MoneyController
    {
        private uint _money;
        private User user;

        public MoneyController() { }
        public MoneyController(User user)
        {
            this.user = user;
        }

        protected bool CheckFormat(string money) 
        {
            bool isParsed = uint.TryParse(money, out _money);
            if (isParsed && _money <= 1000)
                return true;
            return false;
        } 

        private void Put(string money)
        {
            if (CheckFormat(money))
            {
                user.Money += _money;
                MessageBox.Show("Transaction has made!!!");
            }      
            else
                MessageBox.Show("Enter correct value! (no more than 1000$)");
        }

        private void CashOut(string money)
        {
            if (CheckFormat(money))
            {
                if (_money > user.Money)
                    MessageBox.Show("You don't have enough money to cash out!");
                else
                {
                    user.Money -= _money;
                    MessageBox.Show("Transaction has made!!!");
                } 
            }  
            else
                MessageBox.Show("Enter correct value! (no more than 1000$)");
        }

        public void TryTransaction(FormPutMoney formPM, FormCashOut formCO, string money)
        {
            if (Math.Abs(user.LastTransaction.Date.Hour - DateTime.Now.Date.Hour) >= 24)
                user.TransactionsNumber = 0;

            if (user.TransactionsNumber != User.MAX_TRANSACTIONS_NUMBER)
            {
                if (formPM != null)
                    Put(money);
                else if (formCO != null)
                    CashOut(money);
            }
            else
            {
                MessageBox.Show("You can't make more than 10 transactions on a day!");
            }
        }
    }
}
