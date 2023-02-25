using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup.Localizer;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Restauran_Manager_WPF.CreateObject;
using Restaurant_Manager;

namespace Restauran_Manager_WPF
{
    /// <summary>
    /// Логика взаимодействия для MenuZal.xaml
    /// </summary>
    public partial class MenuZal : Window
    {
        public static List<Dish> Order1 = new List<Dish> { MenuBlud.Dishes[1], MenuBlud.Dishes[2] };
        public static List<Dish> Order2 = new List<Dish> { MenuBlud.Dishes[0], MenuBlud.Dishes[1], MenuBlud.Dishes[2] };
        public static List<Restaurant_Manager.Table> tables = new List<Restaurant_Manager.Table> { new Restaurant_Manager.Table { Id = 1, Places = 4, Total_cost = 0, Order = Order1, Busy = false, waiter = null }, new Restaurant_Manager.Table { Id = 2, Places = 5, Total_cost = 0, Order = Order2, Busy = false, waiter = null } };
        public MenuZal()
        {
            InitializeComponent();
            //Открытие файла с сохранением столов
            for (int i = 0; i <= 4; ++i)
            {
                CreateTabl(i);
            }
            int summ=0;
            for(int i=0;i< tables.Count();i++)
            {
                for(int j = 0; j < tables[i].Order.Count();j++)
                {
                    summ +=tables[i].Order[j].Cost;
                }
                tables[i].Total_cost = summ;
                if(summ!=0)
                {
                    tables[i].Busy = true;
                }
                summ = 0;
            }
            for (int i = 0; i < tables.Count(); ++i)
            {
                Data_Table.Items.Add(tables[i]);
            }
        }
        public void CreateTabl(int i)
        {
            var column = new DataGridTextColumn();
            switch (i)
            {
                case 0:
                    column.Header = "Номер";
                    column.Binding = new Binding("Id");
                    Data_Table.Columns.Add(column);
                    break;
                case 1:
                    column.Header = "Мест";
                    column.Binding = new Binding("Places");
                    Data_Table.Columns.Add(column);
                    break;
                case 2:
                    column.Header = "Стоимость заказа";
                    column.Binding = new Binding("Total_cost");
                    Data_Table.Columns.Add(column);
                    break;
                case 3:
                    column.Header = "Занято";
                    column.Binding = new Binding("Busy");
                    Data_Table.Columns.Add(column);
                    break;
                case 4:
                    column.Header = "Официант";
                    column.Binding = new Binding("waiter.Name");
                    Data_Table.Columns.Add(column);
                    break;
            }
        }
        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void Button_Click_Back(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            this.Close();
        }

        private void Button_Click_AddTable(object sender, RoutedEventArgs e)
        {
            CreateTable window = new CreateTable();
            window.Show();
            this.Close();
        }

        private void Button_Click_Dell(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
