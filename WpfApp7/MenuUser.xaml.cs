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

namespace WpfApp7
{
    /// <summary>
    /// Логика взаимодействия для MenuUser.xaml
    /// </summary>
    public partial class MenuUser : Window
    {
        public MenuUser()
        {
            InitializeComponent();
        }

        private void btn_retail_Click(object sender, RoutedEventArgs e)
        {
            UserManufacture userManufacture = new UserManufacture();
            userManufacture.Show();
            this.Close();
        }

        private void btn_products_Click(object sender, RoutedEventArgs e)
        {
            UserProduct userProduct = new UserProduct();
            userProduct.Show();
            this.Close();

        }
    }
}
