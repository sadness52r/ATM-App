using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_App
{
    class MoneyController
    {
        private uint _money;
        private User user;
        
        public MoneyController(User user)
        {
            this.user = user;
        }

        private bool CheckFormat(string money) 
        {
            bool isParsed = uint.TryParse(money, out _money);
            if (isParsed && _money <= 1000)
                return true;
            return false;
        } 

        public void Put(string money)
        {
            if (CheckFormat(money))
            {
                user.Money += _money;
                MessageBox.Show("Transaction has made!!!");
            }      
            else
                MessageBox.Show("Enter correct value! (no more than 1000$)");
        }

        public void CashOut(string money)
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
    }
}
