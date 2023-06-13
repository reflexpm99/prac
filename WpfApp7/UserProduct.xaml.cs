using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using WpfApp7.database;


namespace WpfApp7
{
    public partial class UserProduct : Window
    { 
        public ObservableCollection<Product> Product { get; set; }
    public UserProduct()
    {
        InitializeComponent();
        Product = new ObservableCollection<Product>();
        DataContext = this;
        LoadProduct3();
    }

    public void LoadProduct3()
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
                    IdManufacturer= product.IdManufacturer,
                    Status = product.Status,
                    Price= product.Price,
                });
            }
        }
    }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Product product = usirusir.SelectedItem as Product;
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

   