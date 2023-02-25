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

namespace Restauran_Manager_WPF
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

        private void Button_Click_Menu_Zal(object sender, RoutedEventArgs e)
        {
            MenuZal menuZal=new MenuZal();
            menuZal.Show();
            this.Close();
        }

        private void Button_Click_Exit(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void Button_Click_Waiters(object sender, RoutedEventArgs e)
        {
            Waiters waiters = new Waiters();
            waiters.Show();
            this.Close();
        }

        private void Button_Click_MenuBlud(object sender, RoutedEventArgs e)
        {
            MenuBlud menuBlud=new MenuBlud();
            menuBlud.Show();
            this.Close();
        }

        private void Button_Click_Red(object sender, RoutedEventArgs e)
        {
            RedZakaz redZakaz=new RedZakaz();
            redZakaz.Show();
            this.Close();
        }
    }
}
