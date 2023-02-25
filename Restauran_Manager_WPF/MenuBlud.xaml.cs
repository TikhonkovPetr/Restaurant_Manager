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

namespace Restauran_Manager_WPF
{
    /// <summary>
    /// Логика взаимодействия для MenuBlud.xaml
    /// </summary>
    public partial class MenuBlud : Window
    {
        public static List<Restaurant_Manager.Dish> Dishes = new List<Restaurant_Manager.Dish> { new Restaurant_Manager.Dish { Id = 1, Name = "Кола", Cost = 79 }, new Restaurant_Manager.Dish { Id = 2, Name = "Ягодный пирог", Cost = 99 }, new Restaurant_Manager.Dish { Id = 3, Name = "Спагети", Cost = 59 } };
        public MenuBlud()
        {
            InitializeComponent();
            for (int i = 0; i <= 2; ++i)
            {
                CreateTable(i);
            }
            for (int i = 0; i < Dishes.Count(); ++i)
            {
                Data_Dish.Items.Add(Dishes[i]);
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
                    Data_Dish.Columns.Add(column);
                    break;
                case 1:
                    column.Header = "Название";
                    column.Binding = new Binding("Name");
                    Data_Dish.Columns.Add(column);
                    break;
                case 2:
                    column.Header = "Стоимость";
                    column.Binding = new Binding("Cost");
                    Data_Dish.Columns.Add(column);
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
