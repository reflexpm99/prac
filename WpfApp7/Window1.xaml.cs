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
using WpfApp7.window;

namespace WpfApp7
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void btn_enter_Click(object sender, RoutedEventArgs e)
        {
            if (tb_login.Text == "admin" && tb_password.Password == "123") // логин  и пароль
            {
                MenuAdmin menuAdmin = new MenuAdmin();
                
                menuAdmin = menuAdmin ;
                menuAdmin.Show();

                this.Close();
            }
            else
            {
                MenuUser menuUser = new MenuUser();

                menuUser.Show();
                this.Close();
            }

        }
    }
}
