using ServiceStack;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_App
{
    [DataContract]
    public class AccountController
    {
        [DataMember] private static List<User> users = new List<User>();
        public static List<User> Users => users;

        private static bool CheckValid(string _pinCode, string _cardNumber = "")
        {
            for (int i = 0; i < _cardNumber.Length || i < _pinCode.Length; i++)
            {
                int _symb1 = 0, _symb2 = 0;
                if (i < _cardNumber.Length)
                     _symb1 = _cardNumber[i] - '0';
                if (i < _pinCode.Length)
                     _symb2 = _pinCode[i] - '0';
               
                if (i < _cardNumber.Length && (_symb1 < 0 || _symb1 > 9) || i < _pinCode.Length && (_symb2 < 0 || _symb2 > 9))
                    return false;
            }
            return true;
        }

        private int FindUser(string _cardNumber, string _pinCode)
        {
            for (int i = 0; i < users.Count; i++)
                if (users[i].CardNumber == _cardNumber)
                {
                    if (users[i].PinCode == _pinCode)
                        return i;
                    else
                        return -1;
                }
            return -2;
        }

        private void OpenMain(User user, FormReg form, AccountController accController)
        {
            FormMain formMain = new FormMain(user, form, accController);
            form.Hide();
            formMain.Closed += (s, args) => form.Close();
            formMain.Show();
        }

        public void TryRegister(FormReg form, string _cardNumber, string _pinCode)
        {
            if (CheckValid(_pinCode, _cardNumber))
            {
                int user_index = FindUser(_cardNumber, _pinCode);
                switch (user_index)
                {
                    case -2:
                        Random rnd = new Random();
                        User user = new User((uint)rnd.Next(1000), _cardNumber, _pinCode);
                        users.Add(user);
                        OpenMain(user, form, this);
                        break;
                    case -1:
                        MessageBox.Show("Wrong PIN!");
                        break;
                    default:
                        OpenMain(users[user_index], form, this);
                        break;
                }
            }
            else
            {
                MessageBox.Show("Enter correct data, please!");
            }
        }

        public void ChangePin(string new_pin, string _cardNumber, string _oldPin)
        {
            if (CheckValid(new_pin))
            {
                int user_index = FindUser(_cardNumber, _oldPin);
                users[user_index].PinCode = new_pin;
                MessageBox.Show("Pin was changed succesfully!!!");
            }
            else
            {
                MessageBox.Show("Enter correct data, please!");
            }
        }
    }
}
