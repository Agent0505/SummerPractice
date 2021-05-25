using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab_3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public double number = 0, temp = 0;
        UInt16 flag = 0;
        public MainWindow()
        {
            InitializeComponent();
        }
        public void ShowNumber()
        {
            Display.Text = number.ToString();
        }
        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            number *= 10;
            number += 1;
            ShowNumber();
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            number *= 10;
            number += 2;
            ShowNumber();
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            number *= 10;
            number += 3;
            ShowNumber();
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            number *= 10;
            number += 4;
            ShowNumber();
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            number *= 10;
            number += 5;
            ShowNumber();
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            number *= 10;
            number += 6;
            ShowNumber();
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            number *= 10;
            number += 7;
            ShowNumber();
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            number *= 10;
            number += 8;
            ShowNumber();
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            number *= 10;
            number += 9;
            ShowNumber();
        }

        private void btnС_Click(object sender, RoutedEventArgs e)
        {
            number = 0;
            temp = 0;
            ShowNumber();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            number = Math.Floor(number / 10);
            ShowNumber();
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            number *= 10;
            ShowNumber();
        }

        private void btnDivide_Click(object sender, RoutedEventArgs e)
        {
            flag = 4;
            temp = number;
            number = 0;
        }

        private void btnMultiply_Click(object sender, RoutedEventArgs e)
        {
            flag = 3;
            temp = number;
            number = 0;
        }

        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            flag = 2;
            temp = number;
            number = 0;
        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            flag = 1;
            temp = number;
            number = 0;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(flag == 1)
            {
                temp += number;
                number = temp;
                ShowNumber();
                return;
            }
            if (flag == 2)
            {
                temp -= number;
                number = temp;
                ShowNumber();
                return;
            }
            if (flag == 3)
            {
                temp *= number;
                number = temp;
                ShowNumber();
                return;
            }
            if (flag == 4)
            {
                temp /= number;
                number = temp;
                ShowNumber();
                return;
            }
        }

        private void Display_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
