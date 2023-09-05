using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ATM_App
{
    public class User
    {
        public const int MAX_TRANSACTIONS_NUMBER = 10;
        public uint Money { get; set; }
        public string CardNumber { get; set; }
        public string PinCode { get; set; }
        public int TransactionsNumber { get; set; }
        public List<string> TransactionsHistory { get; set; }
        public DateTime LastTransaction { get; set; }

        public User(uint money, string cardNumber, string pinCode)
        {
            Money = money;
            CardNumber = cardNumber;
            PinCode = pinCode;
            TransactionsNumber = 0;
            TransactionsHistory = new List<string>();
        }
    }
}
