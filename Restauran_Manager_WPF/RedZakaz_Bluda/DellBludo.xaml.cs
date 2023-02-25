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
    /// Логика взаимодействия для DellBludo.xaml
    /// </summary>
    public partial class DellBludo : Window
    {
        public DellBludo()
        {
            InitializeComponent();
            for (int i = 0; i <= 1; i++)
            {
                CreateTable(i);
            }
            for (int i = 0; i < MenuZal.tables[RedZakaz.reserw].Order.Count(); i++)
            {
                Data_Blud_Table.Items.Add(MenuZal.tables[RedZakaz.reserw].Order[i]);
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
                    Data_Blud_Table.Columns.Add(column);
                    break;
                case 1:
                    column.Header = "Стоимость";
                    column.Binding = new Binding("Cost");
                    Data_Blud_Table.Columns.Add(column);
                    break;
            }
        }

        private void Button_Click_Back(object sender, RoutedEventArgs e)
        {
            RedZakaz redZakaz = new RedZakaz();
            redZakaz.Show();
            this.Close();
        }

        private void Button_Click_Dell(object sender, RoutedEventArgs e)
        {
            if(Data_Blud_Table.SelectedItem!=null)
            {
                MenuZal.tables[RedZakaz.reserw].Order.Remove((Restaurant_Manager.Dish)Data_Blud_Table.SelectedItem);
                RedZakaz redZakaz = new RedZakaz();
                redZakaz.Show();
                this.Close();
            }
        }
    }
}
