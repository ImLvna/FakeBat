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

namespace FakeBat
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Hide();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            this.ShowInTaskbar = false;
            Window blur = new FakeBat.Screenblur();
            blur.Show();
            this.Focus();
            this.Show();
            //this.Height = (System.Windows.SystemParameters.PrimaryScreenHeight / 4.4586776859504132231404958677686);
            //this.Width = (System.Windows.SystemParameters.PrimaryScreenWidth / 1.8813725490196078431372549019608);
            //MessageBox.Show((System.Windows.SystemParameters.PrimaryScreenWidth / 1.8813725490196078431372549019608).ToString());
            //MessageBox.Show((System.Windows.SystemParameters.PrimaryScreenHeight / 4.4586776859504132231404958677686).ToString());
        }

        private bool closeheld = false;

        private void closebtn_MouseEnter(object sender, MouseEventArgs e)
        {
            //MessageBox.Show("test");
            if (!closeheld) {
                BrushConverter brushConverter = new BrushConverter();
                closebtn.Background = (Brush)brushConverter.ConvertFromString("#505256");
            }
        }

        private void closebtn_MouseLeave(object sender, MouseEventArgs e)
        {
            if (!closeheld) {
                BrushConverter brushConverter = new BrushConverter();
                closebtn.Background = (Brush)brushConverter.ConvertFromString("#353C48");
            }
        }

        private void closebtn_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            closeheld = true;
            BrushConverter brushConverter = new BrushConverter();
            closebtn.Background = (Brush)brushConverter.ConvertFromString("#fff");
            closetext.Foreground = (Brush)brushConverter.ConvertFromString("#000");
        }

        private void closebtn_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            closeheld = false;
            System.Windows.Application.Current.Shutdown();
        }
    }
}
