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
    /// Логика взаимодействия для AddBludo.xaml
    /// </summary>
    public partial class AddBludo : Window
    {
        public AddBludo()
        {
            InitializeComponent();
            ComBox_Dish.DisplayMemberPath = "Name";
            ComBox_Dish.ItemsSource = MenuBlud.Dishes;
        }

        private void Button_Click_Back(object sender, RoutedEventArgs e)
        {
            RedZakaz redZakaz= new RedZakaz();
            redZakaz.Show();
            this.Close();
        }

        private void Button_Click_Add(object sender, RoutedEventArgs e)
        {
            if (ComBox_Dish.SelectedItem != null)
            {
                MenuZal.tables[RedZakaz.reserw].Order.Add((Restaurant_Manager.Dish)ComBox_Dish.SelectedItem);
                RedZakaz redZakaz = new RedZakaz();
                redZakaz.Show();
                this.Close();
            }
        }
    }
}
