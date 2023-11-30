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
using System.Windows.Shapes;

namespace laba3
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }
        private void Button_Lab2(object sender, RoutedEventArgs e)
        {
            MainWindow window1 = new MainWindow();
            window1.Show();

            this.Hide();
        }

        private void ButtonResult_Click(object sender, RoutedEventArgs e)
        {
            double a, b, c, d, x;

            a = Convert.ToDouble(textBoxA.Text);
            b = Convert.ToDouble(textBoxB.Text);
            c = Convert.ToDouble(textBoxC.Text);
            d = Convert.ToDouble(textBoxD.Text);
            x = Convert.ToDouble(textBoxX.Text);

            QuadraticPolynomial square = new QuadraticPolynomial(a, b, c, x);
            CubicPolynomial cube = new CubicPolynomial(a, b, c, d, x);

            double squareValue = square.Calculate();
            double cubeValue = cube.Calculate();
            MessageBox.Show($"Значення квадратного багаточлена: {squareValue}\nЗначення кубічного багаточлена: {cubeValue}" +
                $"{(squareValue > cubeValue ? "\nКвадратний багаточлен має більше значення" : squareValue < cubeValue ? "\nКубічний багаточлен має більше значення" : "\nБагаточлени мають однакове значення")}");
        }

        private void ButtonExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
