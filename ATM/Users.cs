using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class Users
    {
        public List<Tuple<string, int, double>> users = new List<Tuple<string, int, double>>();

        public Users()
        {
            users.Add(new Tuple<string, int, double>("Дарья", 0000, 19021.34));
        }

        public string check(int pin) // проверка пинкода
        {
            foreach (var item in users)
            {
                if (pin == item.Item2)
                    return item.Item1;
            }
            return "Неверный PIN";
        }
        public double balance(int pin) // баланс
        {
            foreach (var item in users)
            {
                if (pin == item.Item2)
                    return item.Item3;
            }
            return 0;
        }


    }
}
