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
using System.Windows.Navigation;
using WpfApp7.admin;
using System.Collections.ObjectModel;
using WpfApp7.database;


namespace WpfApp7
{
    /// <summary>
    /// Логика взаимодействия для MainWindow2.xaml
    /// </summary>
    public partial class MainWindow2 : Window
    {
        public ObservableCollection<Product> Product { get; set; }
        public MainWindow2()
        {
            InitializeComponent();
            Product = new ObservableCollection<Product>();
            DataContext = this;
            LoadProduct4();
        }

        public void LoadProduct4()
        {
            using (var context = new balbesEntities2())
            {
                var products = context.Product.ToList();
                foreach (var product in products)
                {
                    Product.Add(new Product
                    {
                        IdProduct = product.IdProduct,
                        ProductName = product.ProductName,
                        ImageName = product.ImageName,
                        Image = product.Image,
                        IdManufacturer = product.IdManufacturer,
                        Status = product.Status,
                        Price = product.Price,
                    });
                }
            }
        }


        private void Add_Product_Click(object sender, RoutedEventArgs e)
        {
            Product product = usirus.SelectedItem as Product;
            if (product is null) return;


            addProduct addProduct = new addProduct(new Product
            {
                ProductName = product.ProductName,
                ImageName = product.ImageName,
                Status = product.Status,
                Price = product.Price,


            });
            if (addProduct.ShowDialog() == true)
            {

                if (product != null)
                {

                }


            }
        }
    }
}
