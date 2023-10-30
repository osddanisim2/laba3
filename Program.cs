using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace practic1
{


    namespace WindowsFormsApp1
    {


        static class Program
        {
            [STAThread]
            static void Main()
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
        }
        internal class Tabul
        {
            //���� � ������������ �������
            public double[,] xy = new double[1000, 2];
            //������� ������� �������� � �����
            public int n = 0;
            // ����� ��� �������� �������
            private double f1(double x)
            {
                return Math.Abs(Math.Pow((2 * x + 5)/(x * x * x + 2), (1/3)));
            }
            private double f2(double x)
            {
                return Math.Sqrt(Math.Sin(x*x + 3) + 4) / (x*x + 2);
            }
            private double f3(double x)
            {
                return Math.Sin(Math.Pow((x + 2), 3)) / Math.Log(x*x + 3*x + 1);
            }
            // ����� �����������
            public void tab(double xn = 2.1, double xk = 6.5, double h = 0.2, double a = 0.8)
            {
                double x = xn, y;
                int i = 0;
                while (x <= xk)
                {
                    if (x < 0)
                        y = f1(x);
                    else
                    {
                        if ((x >= 0) && (x < a))
                            y = f2(x);
                        else
                            y = f3(x);
                    }
                    xy[i, 0] = x;
                    xy[i, 1] = y;
                    x = x + h;
                    i++;
                }
                n = i;
            }
        }
    }
    }
