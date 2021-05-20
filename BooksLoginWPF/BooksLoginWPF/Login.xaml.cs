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
using BooksLoginWPF.BooksService1;
using System.ServiceModel;


namespace BooksLoginWPF
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        static public BooksServiceClient client;
        static public BooksWcf.User userClient;
        MainWindow mw = new MainWindow();
        public Login()
        {
            InitializeComponent();
            client = new BooksServiceClient();
            mw.Visibility = Visibility.Collapsed;
            //MainWindow.isvisible = false;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Username.Text == "" || Password.Password == "")
            {
                
                MessageBox.Show("Mindkét mező kitöltése kötelező!");
            }
            else
            {
                string username = Username.Text;
                string password = Password.Password;
                try
                {
                    client = new BooksServiceClient();
                    userClient = client.Login(username,password);


                    MainWindow main = new MainWindow();

                    this.Hide();
                    main.ShowDialog();

                }
                catch (FaultException<BooksWcf.LoginFailedFault> ex)
                {

                    MessageBox.Show("Hibás adatok!");
                }
                catch (EndpointNotFoundException)
                {
                    MessageBox.Show("Hiba a kiszolgálóval!");
                }
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
    }
}
