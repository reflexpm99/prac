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

namespace WpfApp7.admin
{
    /// <summary>
    /// Логика взаимодействия для addProduct2.xaml
    /// </summary>
    public partial class addProduct2 : Window
    {
        public addProduct2(addProduct addProduct)
        {
            InitializeComponent();
        }
        public Product Product { get; private set; }
        public addProduct2(Product product)
        {
            InitializeComponent();
            Product = product;
            DataContext = Product;
        }

        private void Close_ProductA_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Buy_ProductA_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            MessageBox.Show("спасиба!" + "                 " +
                "МОЖНО ПЯТЬ?!");
        }
    }
}

