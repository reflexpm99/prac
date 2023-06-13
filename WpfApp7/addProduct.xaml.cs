using Microsoft.Win32;
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
using WpfApp7.database;
using static System.Net.Mime.MediaTypeNames;

namespace WpfApp7
{
    /// <summary>
    /// Логика взаимодействия для addProduct.xaml
    /// </summary>
    public partial class addProduct : Window
    {
        public addProduct(addProduct addProduct)
        {
            InitializeComponent();
        }
        public Product Product { get; private set; }
        public addProduct(Product product)
        {
            InitializeComponent();
            Product = product;
            DataContext = Product;
        }

        private void Close_ProductU_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Buy_ProductU_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            MessageBox.Show("спасиба!" + "                 " +
                "МОЖНО ПЯТЬ?!") ;
        }
    }
}
