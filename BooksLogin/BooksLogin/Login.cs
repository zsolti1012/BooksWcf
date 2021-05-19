using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BooksLogin.BooksService;
using System.ServiceModel;


namespace BooksLogin
{
    public partial class Login : Form
    {
        static public BooksServiceClient client;
        static public BooksWcf.User userClient;
        
        public Login()
        {
            InitializeComponent();
            client = new BooksServiceClient();
            MainWindow.isvisible = false;
        }
        
        
        private void Button_Enter_Click(object sender, EventArgs e)
        {
           
           

            if (textBox_Logname.Text=="" || textBox_Passwd.Text=="")
            {
                MessageBox.Show("Mindkét mező kitöltése kötelező!");
            }
            else
            {
                string username = textBox_Logname.Text;
                string password = textBox_Passwd.Text;
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
                catch(EndpointNotFoundException )
                {
                    MessageBox.Show("Hiba a kiszolgálóval!");
                }
            }
        }

        private void Button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
