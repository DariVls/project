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
    public partial class Form2 : Form
    {
        Money money = new Money();
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // Вывод денег с баланса
        {
                money.SetBalance(Convert.ToDouble(textBox1.Text) + money.GetBalance());
            Close();
                
        }

        private void textBox1_TextChanged(object sender, EventArgs e) // Конвертер суммы на баланс
        {
            if (money.check_balance(Convert.ToDouble(textBox1.Text)) == true)
                button1.Enabled = true;
            else
                button1.Enabled = false;
        }
    }
}
