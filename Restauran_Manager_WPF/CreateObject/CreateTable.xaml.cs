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
    /// Логика взаимодействия для CreateTable.xaml
    /// </summary>
    public partial class CreateTable : Window
    {
        int number=0;
        public CreateTable()
        {
            InitializeComponent();
        }

        private void Button_Click_Back(object sender, RoutedEventArgs e)
        {
            MenuZal menuZal = new MenuZal();
            menuZal.Show();
            this.Close();
        }

        private void Button_Click_Create(object sender, RoutedEventArgs e)
        {

            if (number > 0)
            {
                Restaurant_Manager.Table table = new Restaurant_Manager.Table { Id = MenuZal.tables.Count +1, Places = number, Total_cost = 0, waiter = new Restaurant_Manager.Waiter(), Busy = false, Order = new List<Restaurant_Manager.Dish>()};
                MenuZal.tables.Add(table);
                MenuZal menuZal = new MenuZal();
                menuZal.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Недопустимое количество мест", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void Button_Click_Plus(object sender, RoutedEventArgs e)
        {
            number += 1;
            LabelNum.Content = number.ToString();
        }
        private void Button_Click_Minus(object sender, RoutedEventArgs e)
        {
            if (number > 0)
            {
                number -= 1;
                LabelNum.Content = number.ToString();
            }
        }
    }
}
