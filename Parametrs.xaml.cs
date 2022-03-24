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

namespace Solar_System
{
    /// <summary>
    /// Логика взаимодействия для Parametrs.xaml
    /// </summary>
    public partial class Parametrs : Window
    {
        static int i1=0,i2=0,i3=0;
        static double i4=0;
        public Parametrs()
        {
            InitializeComponent();
            i1 = Math.duration[0];
            i2 = Math.duration[1];
            i3 = Math.duration[2];
            i4 = Math.par[3];
            sun.Text = i1.ToString();
            earth.Text = i2.ToString();
            moon.Text = i3.ToString();
            koef.Text = i4.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string rs, re, rm, k;
            rs = sun.Text.Trim();
            re = earth.Text.Trim();
            rm = moon.Text.Trim();
            k = koef.Text.Trim();
            if(Check(rs,out i1)&& Check(re, out i2) && Check(rm, out i3) && CheckD(k, out i4))
            {
                Math.par[0] = i1; Math.par[1] = i2;
                Math.par[2] = i3; Math.par[3] = i4;
                Math.Timing();
                this.Close();
            }
            else
            {
                MessageBox.Show("Введите правильные данные.");
            }
        }

        bool Check(string s, out int i)
        {
            if (Int32.TryParse(s, out i)) return true;
            else return false;
        }

        bool CheckD(string s, out double i)
        {
            if (Double.TryParse(s, out i)) return true;
            else return false;
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}
