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

namespace OrganiZer {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();

            //lambda events
            TitleBar.MouseDown += (s, e) => this.DragMove();

            TitleBarClose.MouseDown += (s, e) => this.Close();
            TitleBarMinimize.MouseDown += (s, e) => App.Current.MainWindow.WindowState = WindowState.Minimized;
            TitleBarWindow.MouseDown += (s, e) => App.Current.MainWindow.WindowState = App.Current.MainWindow.WindowState == WindowState.Normal ? WindowState.Maximized : WindowState.Normal;

            MainFrame.NavigationUIVisibility = NavigationUIVisibility.Hidden;
            MainFrame.Navigate(new StartupPage());
        }

        protected void MouseHoverHighlight(object sender, MouseEventArgs e) {
            ((Grid)sender).Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#242424")); //replace string with setting option
        }
        protected void MouseLeaveHighlight(object sender, MouseEventArgs e) {
            Grid a = (Grid)sender;
            string hex = (string)a.Tag;
            a.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString(hex));
        }
    }
}
