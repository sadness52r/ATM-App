using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ATM_App
{
    [DataContract]
    public class User
    {
        [DataMember] public uint Money { get; set; }
        [DataMember] public string CardNumber { get; set; }
        [DataMember] public string PinCode { get; set; }
        [DataMember] public List<string> TransactionsHistory { get; set; }

        public User(uint money, string cardNumber, string pinCode)
        {
            Money = money;
            CardNumber = cardNumber;
            PinCode = pinCode;
            TransactionsHistory = new List<string>();
        }
    }
}
