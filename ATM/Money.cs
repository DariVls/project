using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class Money
    {
        private static double balance=0;

        public void SetBalance(double b) // Установить Баланс
        {
            balance = b;
        }
        public double GetBalance() // получить баланс
        {
            return balance;
        }
        public Money() { }

        public bool check_balance(double summa) // проверить баланс
        {
            if (summa % 100 == 0)
                return true;
            else return false;
        }


    }
}
