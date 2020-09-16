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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Grid grid = new Grid();
            this.Content = grid;
            Button btn = new Button();
            btn.Height = 100;
            btn.Width = 200;
            btn.FontSize = 32;
            
            WrapPanel wrappanel = new WrapPanel();
            TextBlock txt = new TextBlock();
            
            txt.Text = "RAIN";
            txt.Foreground = Brushes.Red;
            wrappanel.Children.Add(txt);
            
            txt = new TextBlock();
            txt.Text = "B";
            txt.Foreground = Brushes.Yellow;
            wrappanel.Children.Add(txt);

            txt = new TextBlock();
            txt.Text = "OW";
            txt.Foreground = Brushes.Blue;
            wrappanel.Children.Add(txt);

            btn.Content = wrappanel;
            grid.Children.Add(btn);

            
        }
    }
}
