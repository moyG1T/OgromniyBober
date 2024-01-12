using OgromniyBober.Data;
using OgromniyBober.NavHost;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OgromniyBober.Pages
{
    /// <summary>
    /// Логика взаимодействия для AppAuthorazation.xaml
    /// </summary>
    public partial class AppAuthorazation : Page
    {
        public AppAuthorazation()
        {
            InitializeComponent();
        }

        private void RegistButton_Click(object sender, RoutedEventArgs e)
        {
            AppNav.Navigate(new PageComps("Регистрация", new AppRegistration()));
        }

        private void LogInButton_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder err = new StringBuilder();

            if (LoginBox.Text == "")
                err.AppendLine("Логин пуст");
            if (PassWordBox.Password == "")
                err.AppendLine("Пароль пуст");

            if (err.Length > 0)
                MessageBox.Show(err.ToString());
            else
            {
                User user = App.db.User.Where(x => x.LOGIN == LoginBox.Text && x.PASSWORD == PassWordBox.Password).FirstOrDefault();
                if (user != null)
                {
                    App.UserID = App.db.User.Where(x => x.LOGIN == LoginBox.Text && x.PASSWORD == PassWordBox.Password).FirstOrDefault().ID;
                    AppNav.Navigate(new PageComps("Заметки", new Desks()));
                    MessageBox.Show($"Вы успешно зашли, {user.LOGIN}");
                }
                else
                    MessageBox.Show("Что-то неверно ;)");
            }
        }
    }
}
