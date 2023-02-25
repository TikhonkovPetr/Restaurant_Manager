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

namespace Restauran_Manager_WPF.RedZakaz_Bluda
{
    /// <summary>
    /// Логика взаимодействия для DellWaiter.xaml
    /// </summary>
    public partial class DellWaiter : Window
    {
        public DellWaiter()
        {
            InitializeComponent();
        }

        private void Button_No(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Yes(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < MenuZal.tables.Count; i++)
            {
                if (MenuZal.tables[i].waiter== Waiters.waiters[Waiters.index_waiter])
                {
                    MenuZal.tables[i].waiter = new Restaurant_Manager.Waiter();
                }
            }
            Waiters.waiters.Remove(Waiters.waiters[Waiters.index_waiter]);
            for (int i = 1; i <= Waiters.waiters.Count; i++)
            {
                Waiters.waiters[i - 1].Id = i;
            }
            this.Close();
        }
    }
}
