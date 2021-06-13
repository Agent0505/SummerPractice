using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double number = 0;
            try
            {
                number = Convert.ToDouble(textBox1.Text);
                label2.Text = (number * 1.609344).ToString() + " km";
            }
            catch
            {
                textBox1.Focus();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if(e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
            if(e.KeyChar == ',')
            {
                if(textBox1.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
            if(Char.IsControl(e.KeyChar))
            {
                if(e.KeyChar == (char) Keys.Enter)
                {
                    button1.Focus();
                }
                return;
            }
            e.Handled = true;
        }
    }
}
