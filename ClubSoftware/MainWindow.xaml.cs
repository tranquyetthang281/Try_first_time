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

namespace ClubSoftware
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Post_Click(object sender, RoutedEventArgs e)
        {
            post.Visibility = Visibility.Visible;
            chat.Visibility = Visibility.Collapsed;
            info.Visibility = Visibility.Collapsed;
            add.Visibility = Visibility.Collapsed;
        }

        private void Button_Chat_Click(object sender, RoutedEventArgs e)
        {
            post.Visibility = Visibility.Collapsed;
            chat.Visibility = Visibility.Visible;
            info.Visibility = Visibility.Collapsed;
            add.Visibility = Visibility.Collapsed;
        }

        private void Button_Info_Click(object sender, RoutedEventArgs e)
        {
            post.Visibility = Visibility.Collapsed;
            chat.Visibility = Visibility.Collapsed;
            info.Visibility = Visibility.Visible;
            add.Visibility = Visibility.Collapsed;
        }

        private void Button_AddMember_Click(object sender, RoutedEventArgs e)
        {
            post.Visibility = Visibility.Collapsed;
            chat.Visibility = Visibility.Collapsed;
            info.Visibility = Visibility.Collapsed;
            add.Visibility = Visibility.Visible;
        }

        private void updrive_Click(object sender, RoutedEventArgs e)
        {

        }

        private void reset_Click(object sender, RoutedEventArgs e)
        {
            Ten.Text = "";
            Nganh.Text = "";
            Ngay.Text = "";
            Ngay_tg.Text = "";
            Phone.Text = "";
            Que.Text = "";
        }

        private void addtv_Click(object sender, RoutedEventArgs e)
        {
            Ten.Text = "";
            Nganh.Text = "";
            Ngay.Text = "";
            Ngay_tg.Text = "";
            Phone.Text = "";
            Que.Text = "";
        }

        private void sign_out_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow loginWindow = new LoginWindow();
            loginWindow.Show();
            this.Close();
        }
    }
}
