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

namespace WpfApp7
{
    /// <summary>
    /// Логика взаимодействия для addManufacture.xaml
    /// </summary>
    public partial class addManufacture : Window
    {
        public addManufacture()
        {
            InitializeComponent();
        }
        public Manufacturer Manufacturer { get; private set; }
        public addManufacture(Manufacturer manufacturer)
        {
            InitializeComponent();
            Manufacturer = manufacturer;
            DataContext = Manufacturer;
        }

        private void Close_ManuU_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
