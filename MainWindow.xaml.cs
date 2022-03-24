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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace Solar_System
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        static bool enable = false;

        public MainWindow()
        {
            InitializeComponent();
            Math.Start();

            MainCanvas.KeyDown+= new System.Windows.Input.KeyEventHandler(MainCanvas_KeyDown);
        }

        private void MainCanvas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F)
            {
                Parametrs parametrs = new Parametrs();
                parametrs.Show();
            }
            throw new NotImplementedException();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Parametrs parametrs = new Parametrs();
            parametrs.Show();
        }
        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            Animate();
        }

        public void Animate()
        {
            //rotation sun
            Math.TimeMath(Math.duration[0]); 
            RotationSun.Duration = new TimeSpan(Math.h, Math.m, Math.s);

            //rotation earth
            Math.TimeMath(Math.duration[1]);
            RotationEarth.Duration = new TimeSpan(Math.h, Math.m, Math.s);

            //rotation earth
            Math.TimeMath(Math.duration[2]);
            RotationMoon.Duration = new TimeSpan(Math.h, Math.m, Math.s);

            //rotation earth shadow
            Math.TimeMath(Math.duration[3]);
            ShadowEarth.Duration = new TimeSpan(Math.h, Math.m, Math.s);

            //translate moon 
            Math.TimeMath(Math.duration[4]);
            TranslateMoon.Duration = new TimeSpan(Math.h, Math.m, Math.s);

            //rotation moon shadow
            Math.TimeMath(Math.duration[5]);
            ShadowMoon.Duration = new TimeSpan(Math.h, Math.m, Math.s);

            //translate earth X
            Math.TimeMath(Math.duration[3]);
            TranslateEarthX.Duration = new TimeSpan(Math.h, Math.m, Math.s);

            //translate earth Y
            Math.TimeMath(Math.duration[3]);
            TranslateEarthY.Duration = new TimeSpan(Math.h, Math.m, Math.s);

            red.Begin(this);

        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            if (enable) //path enable
            {
                enable = false;
                EarthPath.Visibility = Visibility.Hidden;
                MoonPath.Visibility = Visibility.Hidden;
                Button_Path.Background = Brushes.Gray;
            }
            else //path disable
            {
                enable = true;
                EarthPath.Visibility = Visibility.Visible;
                MoonPath.Visibility = Visibility.Visible;
                Button_Path.Background= Brushes.White;
            }

            
        }
    }
}
