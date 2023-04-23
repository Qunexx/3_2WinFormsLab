using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double a;
        private double b;
        private int d;
        
        private MyCalc.MyCalc1 MyCalcc = new MyCalc.MyCalc1(); //Занимаем место для нового класса
        
        private void button1_Click(object sender, EventArgs e)
        {


            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);
            d = Convert.ToInt32(textBox4.Text);
            
            
                try
                {
                    MyCalcc.a = a;
                    MyCalcc.b = b;
                    MyCalcc.d = d;
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Ошибка: " + exception.Message);
                    textBox1.Focus();
                    return;
                }

                MessageBox.Show("Параметры считаны!");
            

            //Вызов метода для расчета
            double Rez = MyCalcc.calc1();

            textBox3.Text = Rez.ToString("F4");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}