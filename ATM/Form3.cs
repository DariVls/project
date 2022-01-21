using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class Form3 : Form
    {
        Money money = new Money();
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) // снять деньги (ввод суммы)
        {
            if ((money.check_balance(Convert.ToDouble(textBox1.Text)) == true) && (money.GetBalance() - Convert.ToDouble(textBox1.Text) > 0))
                button1.Enabled = true;
            else
                button1.Enabled = false;

            
                
        }

        private void button2_Click(object sender, EventArgs e) // шаблон на снятие
        {
            if (money.GetBalance() - 100 > 0)
            {
                money.SetBalance(money.GetBalance() - 100);
                Close();
            }
        }

        private void button1_Click(object sender, EventArgs e) // конвертер суммы с баланс
        {
            money.SetBalance(money.GetBalance() - Convert.ToDouble(textBox1.Text));
            Close();
        }

        private void button3_Click(object sender, EventArgs e) // шаблон на снятие
        {
            if (money.GetBalance() - 200 > 0)
            {
                money.SetBalance(money.GetBalance() - 200);
                Close();
            }
        }

        private void button4_Click(object sender, EventArgs e) // шаблон на снятие
        {
            if (money.GetBalance() - 500 > 0)
            {
                money.SetBalance(money.GetBalance() - 500);
                Close();
            }
        }

        private void button5_Click(object sender, EventArgs e) // шаблон на снятие
        {
            if (money.GetBalance() - 1000 > 0)
            {
                money.SetBalance(money.GetBalance() - 1000);
                Close();
            }
        }

        private void button6_Click(object sender, EventArgs e) // шаблон на снятие
        {
            if (money.GetBalance() - 2000 > 0)
            {
                money.SetBalance(money.GetBalance() - 2000);
                Close();
            }
        }

        private void button7_Click(object sender, EventArgs e) // шаблон на снятие
        {
            if (money.GetBalance() - 5000 > 0)
            {
                money.SetBalance(money.GetBalance() - 5000);
                Close();
            }
        }
    }
}
