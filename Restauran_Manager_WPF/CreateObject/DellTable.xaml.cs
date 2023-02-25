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
    /// Логика взаимодействия для DellTable.xaml
    /// </summary>
    public partial class DellTable : Window
    {
        public DellTable()
        {
            InitializeComponent();
        }

        private void Button_Yes(object sender, RoutedEventArgs e)
        {
            MenuZal.tables.Remove(MenuZal.tables[MenuZal.index_tab]);
            for (int i = 1; i <= MenuZal.tables.Count; i++)
            {
                MenuZal.tables[i - 1].Id = i;
            }
            this.Close();
        }

        private void Button_No(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
