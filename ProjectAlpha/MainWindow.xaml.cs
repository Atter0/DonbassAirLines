using ProjectAlpha.base1;
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

namespace ProjectAlpha
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow() => InitializeComponent();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Border_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void PasswordBox_MouseDown(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            RegistrWindow registrWindow = new RegistrWindow();
            registrWindow.Show();
            

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            var currentuser = AppData.db.user.FirstOrDefault(u => u.username == login.Text && u.password == password.Password);
            if (currentuser != null)
            {
                MessageBox.Show("Вы успешно авторизированы!");
            } else
            {
                MessageBox.Show("Введите правильный Логин/Пароль,если нету учетной записи,пройдите регистрацию.");
            }
        }
    }
}
