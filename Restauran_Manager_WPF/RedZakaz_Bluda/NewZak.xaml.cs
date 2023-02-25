using Restaurant_Manager;
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
    /// Логика взаимодействия для NewZak.xaml
    /// </summary>
    public partial class NewZak : Window
    {
        List<Restaurant_Manager.Dish> dish = new List<Restaurant_Manager.Dish>();
        public NewZak()
        {
            InitializeComponent();
            ComBox_Waiters.ItemsSource = Waiters.waiters;
            ComBox_Waiters.DisplayMemberPath = "Name";
            ComBox_Dish.ItemsSource = MenuBlud.Dishes;
            ComBox_Dish.DisplayMemberPath = "Name";
            for (int i = 0; i <= 1; i++)
            {
                CreateTable(i);
            }
        }
        public void CreateTable(int i)
        {
            var column = new DataGridTextColumn();
            switch (i)
            {
                case 0:
                    column.Header = "Название";
                    column.Binding = new Binding("Name");
                    Data_Zakaz.Columns.Add(column);
                    break;
                case 1:
                    column.Header = "Стоимость";
                    column.Binding = new Binding("Cost");
                    Data_Zakaz.Columns.Add(column);
                    break;
            }
        }

        private void Button_Click_Back(object sender, RoutedEventArgs e)
        {
            RedZakaz window = new RedZakaz();
            window.Show();
            this.Close();
        }

        private void Button_Click_Add(object sender, RoutedEventArgs e)
        {
            if(ComBox_Dish.SelectedItem!=null)
            {
                Data_Zakaz.Items.Add(ComBox_Dish.SelectedItem);
                dish.Add((Restaurant_Manager.Dish)ComBox_Dish.SelectedItem);
                ComBox_Dish.SelectedItem = null;
            }
        }

        private void Button_Click_Dell(object sender, RoutedEventArgs e)
        {
            if(Data_Zakaz.SelectedItem!=null)
            {
                Data_Zakaz.Items.Remove(Data_Zakaz.SelectedItem);
                Data_Zakaz.SelectedItem = null;
            }
        }

        private void Button_Click_Create(object sender, RoutedEventArgs e)
        {
            if(ComBox_Waiters.SelectedItem!=null && Data_Zakaz.Items.Count>0)
            {
                MenuZal.tables[RedZakaz.index].Order = dish;
                MenuZal.tables[RedZakaz.index].waiter = (Restaurant_Manager.Waiter)ComBox_Waiters.SelectedItem;
                Waiters.waiters[ComBox_Waiters.SelectedIndex].Worked_days += 1;
                RedZakaz redZakaz = new RedZakaz();
                redZakaz.Show();
                this.Close();
            }
        }
    }
}
