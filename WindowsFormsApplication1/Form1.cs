using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        //string t;
        int liczba,liczba2,ena,suma,roznica,mnozenie,dzialanie;
        double dzielenie, liczba3, liczba4;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //liczba = int.Parse(textBox1.Text);
            //liczba2 = int.Parse(textBox2.Text);
            //suma = liczba + liczba2;
            //MessageBox.Show(suma.ToString());
            //textBox2.Text=t;
            //textBox1.Clear();
            dzialanie = 1;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //ena = 1;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            /*if (ena == 1)
            {
                button1.Enabled = true;
            }*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //liczba = int.Parse(textBox1.Text);
            //liczba2 = int.Parse(textBox2.Text);
            //roznica = liczba - liczba2;
            //MessageBox.Show(roznica.ToString());
            dzialanie = 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //liczba = int.Parse(textBox1.Text);
            //liczba2 = int.Parse(textBox2.Text);
            //mnozenie = liczba * liczba2;
            //MessageBox.Show(mnozenie.ToString());
            dzialanie = 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //liczba3 = double.Parse(textBox1.Text, System.Globalization.NumberStyles.AllowDecimalPoint);
            //liczba4 = double.Parse(textBox2.Text, System.Globalization.NumberStyles.AllowDecimalPoint);
            /*if (liczba4 == 0)
            {
                MessageBox.Show("dzielenie przez zero");
            }*/
            //else
            {
                //DivideByZeroException("dzielenie przez zero");
                //dzielenie = liczba / liczba2;
                //MessageBox.Show(dzielenie.ToString());
                dzialanie = 4;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            /*string jeden, dwa;
            jeden = textBox1.Text;
            dwa = textBox2.Text;
            textBox1.Text = dwa;
            textBox2.Text = jeden*/
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (dzialanie == 1)
            {
                liczba = int.Parse(textBox1.Text);
                liczba2 = int.Parse(textBox2.Text);
                suma = liczba + liczba2;
                //MessageBox.Show(suma.ToString());
                //suma.ToString();
                textBox3.Text = suma.ToString();
            }
            if (dzialanie == 2)
            {
                liczba = int.Parse(textBox1.Text);
                liczba2 = int.Parse(textBox2.Text);
                roznica = liczba - liczba2;
                //MessageBox.Show(roznica.ToString());
                textBox3.Text = roznica.ToString();
            }
            if (dzialanie == 3)
            {
                liczba = int.Parse(textBox1.Text);
                liczba2 = int.Parse(textBox2.Text);
                mnozenie = liczba * liczba2;
                //MessageBox.Show(mnozenie.ToString());
                textBox3.Text = mnozenie.ToString();
            }
            if (dzialanie == 4)
            {
                string lama="zlamiles";
                liczba3 = double.Parse(textBox1.Text);
                liczba4 = double.Parse(textBox2.Text);
                if (liczba4 == 0)
                {
                    textBox3.Text = lama;
                }
                else
                {
                    dzielenie = liczba3 / liczba4;
                    textBox3.Text = dzielenie.ToString();
                }
                //MessageBox.Show(dzielenie.ToString());
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
