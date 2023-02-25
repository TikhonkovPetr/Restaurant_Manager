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

namespace Restauran_Manager_WPF.CreateObject
{
    /// <summary>
    /// Логика взаимодействия для Privase.xaml
    /// </summary>
    public partial class Privase : Window
    {
        public Privase()
        {
            InitializeComponent();
        }

        private void Button_No(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Yes(object sender, RoutedEventArgs e)
        {
            for(int i=0;i<MenuZal.tables.Count ;i++)
            {
                for (int j = 0; j < MenuZal.tables[i].Order.Count; j++)
                {
                    if (MenuZal.tables[i].Order[j]== MenuBlud.Dishes[MenuBlud.index_dish])
                    {
                        MenuZal.tables[i].Order.Remove(MenuZal.tables[i].Order[j]);
                    }
                }
            }
            MenuBlud.Dishes.Remove(MenuBlud.Dishes[MenuBlud.index_dish]);
            for (int i = 1; i <= MenuBlud.Dishes.Count; i++)
            {
                MenuBlud.Dishes[i - 1].Id = i;
            }
            this.Close();
        }
    }
}
