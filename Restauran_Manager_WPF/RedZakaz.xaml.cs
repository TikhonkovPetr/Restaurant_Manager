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
using Restauran_Manager_WPF.RedZakaz_Bluda;
using Restaurant_Manager;

namespace Restauran_Manager_WPF
{
    /// <summary>
    /// Логика взаимодействия для RedZakaz.xaml
    /// </summary>
    public partial class RedZakaz : Window
    {
        public static int reserw;
        public static bool prow = false;
        public static int index;
        public RedZakaz()
        {
            InitializeComponent();
            List_Table.ItemsSource = MenuZal.tables;
            List_Table.DisplayMemberPath = "Id";
            for(int i=0;i<=1;i++)
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
            MainWindow window = new MainWindow();
            window.Show();
            this.Close();
        }
        private void Select_Table(object sender, SelectionChangedEventArgs e)
        {
            int summ = 0;
            Data_Zakaz.Items.Clear();
            for (int i = 0; i < MenuZal.tables[List_Table.SelectedIndex].Order.Count(); i++)
            {
                Data_Zakaz.Items.Add(MenuZal.tables[List_Table.SelectedIndex].Order[i]);
                summ += MenuZal.tables[List_Table.SelectedIndex].Order[i].Cost;
            }
            if(MenuZal.tables[List_Table.SelectedIndex].Order.Count()!=0)
            {
                MenuZal.tables[List_Table.SelectedIndex].Busy = true;
            }
            Table.Content = "Заказ столика "+(List_Table.SelectedIndex + 1).ToString();
            Rub.Content=summ.ToString()+ " рублей";
            MenuZal.tables[List_Table.SelectedIndex].Total_cost= summ;
            reserw = List_Table.SelectedIndex;
            prow = true;
        }
        private void Button_Click_Dell(object sender, RoutedEventArgs e)
        {
            if (prow)
            {
                DellBludo window = new DellBludo();
                window.Show();
                this.Close();
            }
        }

        private void Button_Click_Add(object sender, RoutedEventArgs e)
        {
            if (prow)
            {
                AddBludo window = new AddBludo();
                window.Show();
                this.Close();
            }
        }

        private void Button_Click_Creal(object sender, RoutedEventArgs e)
        {
            if (prow)
            {
                Data_Zakaz.Items.Clear();
                prow = false;
                ClearTable clearTable = new ClearTable();
                clearTable.ShowDialog();
            }
        }

        private void Button_Click_Create(object sender, RoutedEventArgs e)
        {
            if (prow)
            {
                if (!MenuZal.tables[List_Table.SelectedIndex].Busy)
                {
                    NewZak newZak = new NewZak();
                    index = List_Table.SelectedIndex;
                    newZak.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Столик занят", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
            else
            {
                MessageBox.Show("Столик не выбран","Ошибка",MessageBoxButton.OK,MessageBoxImage.Warning);
            }
        }
    }
}
