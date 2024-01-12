using OgromniyBober.Data;
using OgromniyBober.NavHost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
    /// Логика взаимодействия для AppRegistration.xaml
    /// </summary>
    public partial class AppRegistration : Page
    {
        public AppRegistration()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AppNav.NavigateAndPop();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            StringBuilder error = new StringBuilder(); 
            if (NameText.Text == "" || NameText.Text == null)
                error.AppendLine("Имя не введено"); 
            if (LoginText.Text == "" || LoginText.Text == null)
                error.AppendLine("Логин не введен"); 
            if (PasswordText.Text == null || PasswordText.Text == "")
                error.AppendLine("Пароль не введен");

            if (error.Length > 0)
            {
                MessageBox.Show(error.ToString());  
            }
            else
            {
                App.db.User.Add(new User()
                {
                    NAME = NameText.Text,
                    LOGIN = LoginText.Text,
                    PASSWORD = PasswordText.Text,
                }); 
                App.db.SaveChanges();
                MessageBox.Show("Сохранено");
                AppNav.NavigateAndPop();
            }
        }
    }
}
