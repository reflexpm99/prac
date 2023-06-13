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
using WpfApp7.admin;

namespace WpfApp7.window
{
    /// <summary>
    /// Логика взаимодействия для MenuAdmin.xaml
    /// </summary>
    public partial class MenuAdmin : Window
    {
        public MenuAdmin()
        {
            InitializeComponent();
        }

        private void btn_retail_Click_1(object sender, RoutedEventArgs e)
        {
            AdminManufacture adminManufacture = new AdminManufacture();
            adminManufacture.Show();
            this.Close();

        }

        private void btn_products_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow2 mainWindow2 = new MainWindow2();

            mainWindow2.Show();
            this.Close();
        }

        
    }
}