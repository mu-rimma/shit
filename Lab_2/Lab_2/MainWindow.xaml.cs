using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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

namespace Lab_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public static void Res()
        {
            //функция для перевода из одной ед.измерения в другую
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int a = int.Parse(txtbxin.Text);

            int choose = list1.SelectedIndex;
            int calculate = list2.SelectedIndex;
            int liter = 0, pt = 0, gal = 0, charka = 0, cup = 0, cubmeter = 0;
            /*int liter2 = 0, pt2 = 0, gal2 = 0, charka2 = 0, cup2 = 0, cubmeter2 = 0;*/
            double result = 0;

            switch (choose)
            {
                case 0:
                    liter = a;
                    break;
                case 1:
                    pt = a;
                    break;
                case 2:
                    gal = a;
                    break;
                case 3:
                    charka = a;
                    break;
                case 4:
                    cup = a;
                    break;
                case 5:
                    cubmeter = a;
                    break;
            }

            switch (calculate)
            {
                case 0:
                    if (liter == a)
                    {
                        result = a;
                    }
                    else if (gal == a)
                    {
                        result = a * 4.55;
                    }
                    else if (pt == a)
                    {
                        result = a * 0.568;
                    }
                    else if (charka == a)
                    {
                        result = a * 0.123;
                    }
                    else if (cup == a)
                    {
                        result = a * 0.2;
                    }
                    else if (cubmeter == a)
                    {
                        result = a * 1000;
                    }
                    break;

                case 1:
                    if (liter == a)
                    {
                        result = a * 1.76;
                    }
                    else if (gal == a)
                    {
                        result = a * 8;
                    }
                    else if (pt == a)
                    {
                        result = a;
                    }
                    else if (charka == a)
                    {
                        result = a * 0.22;
                    }
                    else if (cup == a)
                    {
                        result = a * 0.35;
                    }
                    else if (cubmeter == a)
                    {
                        result = a * 1759.75;
                    }
                    break;

                case 2:
                    if (liter == a)
                    {
                        result = a * 0.22;
                    }
                    else if (gal == a)
                    {
                        result = a;
                    }
                    else if (pt == a)
                    {
                        result = a * 0.12;
                    }
                    else if (charka == a)
                    {
                        result = a * 0.027;
                    }
                    else if (cup == a)
                    {
                        result = a * 0.044;
                    }
                    else if (cubmeter == a)
                    {
                        result = a * 219.97;
                    }
                    break;

                case 3:
                    if (liter == a)
                    {
                        result = a * 8.13;
                    }
                    else if (gal == a)
                    {
                        result = a * 36.96;
                    }
                    else if (pt == a)
                    {
                        result = a * 4.62;
                    }
                    else if (charka == a)
                    {
                        result = a;
                    }
                    else if (cup == a)
                    {
                        result = a * 1.63;
                    }
                    else if (cubmeter == a)
                    {
                        result = a * 8130.74;
                    }
                    break;

                case 4:
                    if (liter == a)
                    {
                        result = a * 5;
                    }
                    else if (gal == a)
                    {
                        result = a * 22.73;
                    }
                    else if (pt == a)
                    {
                        result = a * 2.84;
                    }
                    else if (charka == a)
                    {
                        result = a * 0.61;
                    }
                    else if (cup == a)
                    {
                        result = a;
                    }
                    else if (cubmeter == a)
                    {
                        result = a * 5000;
                    }
                    break;

                case 5:
                    if (liter == a)
                    {
                        result = a * 0.001;
                    }
                    else if (gal == a)
                    {
                        result = a * 0.0045;
                    }
                    else if (pt == a)
                    {
                        result = a * 0.00057;
                    }
                    else if (charka == a)
                    {
                        result = a * 0.00012;
                    }
                    else if (cup == a)
                    {
                        result = a * 0.0002;
                    }
                    else if (cubmeter == a)
                    {
                        result = a;
                    }
                    break;
            }


            txtbxout.Text = string.Format($" {result:0.00}");
        }

        private void list1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
