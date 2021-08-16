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

namespace FakeBat
{
    /// <summary>
    /// Interaction logic for Screenblur.xaml
    /// </summary>
    public partial class Screenblur : Window
    {
        public Screenblur()
        {
            InitializeComponent();
            this.Height = System.Windows.SystemParameters.PrimaryScreenHeight;
            this.Width = System.Windows.SystemParameters.PrimaryScreenWidth;
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            this.ShowInTaskbar = false;
            this.AllowsTransparency = true;
        }
    }
}
