using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
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

namespace Variant_1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        double x, a, b, y;
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Result == null) return;
            if (!string.IsNullOrWhiteSpace(Input.Text) && Input.Text.All(char.IsDigit))
            { a = Convert.ToDouble(Input.Text); }
            else
                a = 0;
            x = Math.Log10(0.05 + 2);
            b = Math.Pow(2, x);
            y = (Math.Pow(x, 4) - b*Math.Pow(x, 3) - a)/((x+a)*(x-b));
            Result.Text = y.ToString();
        }
    }
}
