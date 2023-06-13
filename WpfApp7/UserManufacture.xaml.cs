using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
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
    /// <summary>
    /// Логика взаимодействия для UserManufacture.xaml
    /// </summary>
    public partial class UserManufacture : Window
    {
        public ObservableCollection<Manufacturer> Manufacturers { get; set; }
        public UserManufacture()
        {
            InitializeComponent();
            Manufacturers = new ObservableCollection<Manufacturer>();
            DataContext = this;
            LoadManufacture2();
        }

        public void LoadManufacture2()
        {
            using (var context = new balbesEntities2())
            {
                var manufacturers = context.Manufacturer.ToList();
                foreach (var manufacturer in manufacturers)
                {
                    Manufacturers.Add(new Manufacturer
                    {
                        IdManufacturer = manufacturer.IdManufacturer,
                        ManufacturerName = manufacturer.ManufacturerName,
                        Date = manufacturer.Date,
                    });
                }
            }
        }


        private void Add_Manu(object sender, RoutedEventArgs e)
        {
            Manufacturer manufacturer = usirname.SelectedItem as Manufacturer;
            if (manufacturer is null) return;

            addManufacture addManufactureAA = new addManufacture(new Manufacturer
            {

                ManufacturerName = manufacturer.ManufacturerName,
                Date = manufacturer.Date


            });
            if (addManufactureAA.ShowDialog() == true)
            {

                if (manufacturer != null)
                {

                }


            }
        }
    }
}