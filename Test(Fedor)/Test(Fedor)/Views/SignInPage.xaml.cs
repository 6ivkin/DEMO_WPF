﻿using System;
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

namespace Test_Fedor_.Views
{
    /// <summary>
    /// Логика взаимодействия для SignInPage.xaml
    /// </summary>
    public partial class SignInPage : Page
    {
        public SignInPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new WelcomePage());

            //var CurrentUser = AppData.db.User.FirstOrDefault(u => u.Login == TxbLogin && u.Password == TxbPassword);
            //if(CurrentUser != null)
            //{
            //    NavigationService.Navigate(new WelcomePage());
            //} else
            //{
            //    MessageBox.Show("Неверно ввели данные!");
            //}
        }
    }
}
