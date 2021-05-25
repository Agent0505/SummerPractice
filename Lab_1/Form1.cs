using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    
    public partial class Calculator : Form
    {
        static double number = 0, temp = 0;
        static UInt16 flag = 0;

        public void ShowNumber()
        {
            label1.Text = number.ToString();
        }

        public Calculator()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            number = 0;
            ShowNumber();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            number *= 10;
            number += 1;
            ShowNumber();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            number *= 10;
            number += 2;
            ShowNumber();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            number *= 10;
            number += 3;
            ShowNumber();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            number *= 10;
            number += 4;
            ShowNumber();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            number *= 10;
            number += 5;
            ShowNumber();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            number *= 10;
            number += 6;
            ShowNumber();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            number *= 10;
            number += 7;
            ShowNumber();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            number *= 10;
            number += 8;
            ShowNumber();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            number *= 10;
            number += 9;
            ShowNumber();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            number *= 10;
            ShowNumber();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            number = Math.Floor(number / 10);
            ShowNumber();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            flag = 1;
            temp = number;
            number = 0;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if(flag == 1)
            {
                temp += number;
                number = temp;
            }
            if(flag == 2)
            {
                temp -= number;
                number = temp;
            }
            if(flag == 3)
            {
                temp *= number;
                number = temp;
            }
            if(flag == 4)
            {
                temp /= number;
                number = temp;
            }
            ShowNumber();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            flag = 2;
            temp = number;
            number = 0;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            flag = 3;
            temp = number;
            number = 0;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            flag = 4;
            temp = number;
            number = 0;
        }
    }
}
