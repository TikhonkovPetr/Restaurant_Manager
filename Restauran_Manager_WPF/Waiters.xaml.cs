using System;
using System.Collections.Generic;
using System.Data;
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

namespace Restauran_Manager_WPF
{
    /// <summary>
    /// Логика взаимодействия для Waiters.xaml
    /// </summary>
    public partial class Waiters : Window
    {
        public static List<Restaurant_Manager.Waiter> waiters = new List<Restaurant_Manager.Waiter> { new Restaurant_Manager.Waiter { Id = 1, Name = "Tom", Salary_per_day = 37000, Device_date = new DateTime(2021, 12, 20), Worked_days = 487 }, new Restaurant_Manager.Waiter { Id = 2, Name = "Gary", Salary_per_day = 30000, Device_date = new DateTime(2022, 1, 12), Worked_days = 120 }, new Restaurant_Manager.Waiter { Id = 3, Name = "Clam", Salary_per_day = 28000, Device_date = new DateTime(2022, 8, 11), Worked_days = 23 } };
        public Waiters()
        {
            InitializeComponent();
            Data_Waiter.Width= 600;
            Data_Waiter.Height= 400;
            for (int i = 0; i <= 4; ++i)
            {
                CreateTable(i);
            }
            for (int i = 0; i < waiters.Count(); ++i)
            {
                Data_Waiter.Items.Add(waiters[i]);
            }
        }
        public void CreateTable(int i)
        {
            var column = new DataGridTextColumn();
            switch (i)
            {
                case 0:
                    column.Header = "Номер";
                    column.Binding = new Binding("Id");
                    Data_Waiter.Columns.Add(column);
                    break;
                case 1:
                    column.Header = "Имя";
                    column.Binding = new Binding("Name");
                    Data_Waiter.Columns.Add(column);
                    break;
                case 2:
                    column.Header = "Зароботная плата";
                    column.Binding = new Binding("Salary_per_day");
                    Data_Waiter.Columns.Add(column);
                    break;
                case 3:
                    column.Header = "Дата устройства";
                    column.Binding = new Binding("Device_date");
                    Data_Waiter.Columns.Add(column);
                    break;
                case 4:
                    column.Header = "Дней проработал";
                    column.Binding = new Binding("Worked_days");
                    Data_Waiter.Columns.Add(column);
                    break;
            }
        }
        private void Button_Click_Back(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            this.Close();
        }
    }
}
