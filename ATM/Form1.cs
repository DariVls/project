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
    public partial class Form1 : Form
    {
        Money money = new Money();
        public Form1()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox3.Text += "4";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox3.Text += "8";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            List<Button> btn = new List<Button> { button13, button1, button11, button10, button4, button5, button6, button7, button8, button9 };
            if (textBox3.Text.Length > 3)
            {
                foreach (Button b in btn)
                {
                    b.Enabled = false;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e) // Цифра на табло ввода Пин кода карты
        {
            textBox3.Text += "1";
        }

        private void button4_Click(object sender, EventArgs e) // 
        {
            textBox3.Text += "2";
        }

        private void button5_Click(object sender, EventArgs e) // 
        {
            textBox3.Text += "3";
        }

        private void button7_Click(object sender, EventArgs e) // 
        {
            textBox3.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e) // 
        {
            textBox3.Text += "6";
        }

        private void button11_Click(object sender, EventArgs e) // 
        {
            textBox3.Text += "7";
        }

        private void button9_Click(object sender, EventArgs e) // 
        {
            textBox3.Text += "9";
        }

        private void button13_Click(object sender, EventArgs e) // 
        {
            textBox3.Text += "0";
        }

        private void button14_Click(object sender, EventArgs e) // Очистить поле ввода
        {
            List<Button> btn = new List<Button> { button13, button1, button11, button10, button4, button5, button6, button7, button8, button9 };
            textBox3.Text = "";
            foreach (Button b in btn)
            {
                b.Enabled = true;
            }
        }
        
        private void textBox2_MouseClick(object sender, MouseEventArgs e) // Вставте карту 
        {
            List<Button> btn = new List<Button> { button14, button13, button1,button11, button10, button12,  button4, button5, button6, button7, button8, button9 };
            if (textBox2.BackColor == Color.Maroon)
            {
                textBox2.BackColor = Color.Green;
                label4.Visible = true;
                foreach(Button b in btn)
                {
                    b.Enabled = true;
                }
                label5.Text = "Введите пин-код";
            }
            else
            {
                label4.Visible = false;
                textBox2.BackColor = Color.Maroon;
                foreach (Button b in btn)
                {
                    b.Enabled = false;
                }
                label5.Text = "";
                textBox3.Text = "";
                textBox1.Text = "";
            }
        }

        private void button12_Click(object sender, EventArgs e) // Проверка пина
        {
            
                Users u= new Users();
                if (u.check(Convert.ToInt32(textBox3.Text)) == "Неверный PIN")
                    label5.Text = "Неверный PIN";
                else
                {
                    label5.Text = "Добро пожаловать, " + u.check(Convert.ToInt32(textBox3.Text));
                    button2.Enabled = true;
                    button3.Enabled = true;
                    button12.Enabled = false;
                    button14.Enabled = false;
                    textBox1.Text = Convert.ToString(u.balance(Convert.ToInt32(textBox3.Text)));
                    money.SetBalance(Convert.ToDouble(textBox1.Text));
            }
        }

        private void button3_Click(object sender, EventArgs e) // "Внести деньги на баланс"
        {
            
            Form2 form = new Form2();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e) // "Вывод денег"
        {
            Form3 form = new Form3();
            form.Show();
        }
    }
}
