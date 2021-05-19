using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using BooksLogin.BooksService;
using BooksWcf;

namespace BooksLogin
{
    public partial class MainWindow : Form
    {

        private BooksServiceClient client=Login.client;
        private BooksWcf.User userClient=Login.userClient;
        private bool success;
        static public bool isvisible = true;

        public MainWindow()
        {
            InitializeComponent();
            if (!isvisible) { button_login.Visible = false; }
        }

       





        private void Button_Logout_Click(object sender, EventArgs e)
        {
            try
            {
                bool logoutResult = client.Logout(userClient);
                if (logoutResult)
                {
                    userClient = null;

                    MessageBox.Show("Sikeres kijelentkezés!");
                
                    
                }
            }
            catch (EndpointNotFoundException)
            {
                MessageBox.Show("Hiba a kiszolgálóval!");
            }
            catch (FaultException<LoginFailedFault> ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ismeretlen hiba: " + ex.Message);
            }


            Login login = new Login();
            this.Hide();
            login.ShowDialog();
            
            this.Close();
        }

        private void Button_List_Click(object sender, EventArgs e)
        {
           
            listBox_List.Items.Clear();
            try
            {
                ICollection<BooksWcf.Book> result = client.ListAll(userClient,"Zsolti|wcf");
                listBox_List.Items.Add(("ID\tCím\t\tPontszám\tOldalsz.\tÉv").ToString());
                
                foreach (BooksWcf.Book book in result)
                {
                    ListBoxItem item = new ListBoxItem();
                    item.Content = (book.id + ";" + book.name + ";" + book.rating + ";" + book.length + ";" + book.releaseYear);
                    
                    listBox_List.Items.Add((book.id + "\t" + book.name + "\t" + book.rating + "\t" + book.length + "\t" + book.releaseYear).ToString());
                }
            }
            catch (NullReferenceException)
            {

                MessageBox.Show("A funkció használatához jelentkezz be!");
            }

            catch (EndpointNotFoundException)
            {

                MessageBox.Show("Hiba a kiszolgálóval!");
            }

            catch (FaultException<BooksWcf.LoginFailedException> ex)
            {
                MessageBox.Show(ex.Message);
            }

            catch (FaultException<BooksWcf.NoAvailableBookException> ex)
            {
                MessageBox.Show(ex.Reason.ToString());
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ismeretlen hiba: "+ex.Message);
            }
        }

        private void Button_Listbyid_Click(object sender, EventArgs e)
        {
            if (textBox_byid_id.Text.All(char.IsDigit))
            {
                listBox_byid.Items.Clear();
                try
                {
                    ICollection<Book> oneResult = client.ListById(textBox_byid_id.Text, userClient, "Zsolti|wcf");
                    foreach (Book book in oneResult)
                    {
                        ListBoxItem item = new ListBoxItem();
                       
                        listBox_byid.Items.Add((book.id + "\t" + book.name + "\t" + book.rating + "\t" + book.length + "\t" + book.releaseYear).ToString());
                    }
                }
                catch (NullReferenceException)
                {
                    MessageBox.Show("A funkció használatához be kell jelentkezni!");
                }
                catch (EndpointNotFoundException)
                {
                    MessageBox.Show("Hiba a kiszolgálóval!");
                }
                catch (FaultException<LoginFailedFault> ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (FaultException<BookNotFoundFault> ex)
                {
                    MessageBox.Show(ex.Reason.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("hiba: " + ex.Message);
                }
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void Button_Add_Click(object sender, EventArgs e)
        {
            try
            {
                string title =textBox_besz_name.Text;
                string length = textBox_besz_length.Text;
                string releaseYear = textBox_besz_releaseyear.Text;
                

                if (textBox_besz_name.Text=="" || textBox_besz_length.Text=="" || textBox_besz_releaseyear.Text=="")
                {
                    MessageBox.Show("Minden mező kitöltése kötelező!");
                }
               
                    else
                    {
                        Button_List_Click(sender, e);
                        bool insertResult = client.Insert(title, "0", length, releaseYear, userClient, "Zsolti|wcf");
                        if (insertResult)
                        {
                            MessageBox.Show("Beszúrás sikeres!!");
                        }
                        else
                        {
                            MessageBox.Show("Sikertelen adatbeillesztés!!");
                        }
                        Button_List_Click(sender, e);
                    }
                
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("A funkció használatához be kell jelentkezni!");
            }
            catch (EndpointNotFoundException)
            {
                MessageBox.Show("Hiba a kiszolgálóval!");
            }
            catch (FaultException<LoginFailedFault> ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("hiba: " + ex.Message);
            }
        }

        private void Button_delete_Click(object sender, EventArgs e)
        {
            if (textBox_del_id.Text.All(char.IsDigit) &&textBox_del_id.Text!=""&& textBox_del_id.Text !=null||isvisible)
            {
                try
                {
                    validdata(textBox_del_id.Text);
                if (success)
                {
                    string deleteID = textBox_del_id.Text;
                    
                        bool deleteResult = client.Delete(deleteID, userClient, "Zsolti|wcf");
                        if (deleteResult)
                        {
                            Button_List_Click(sender, e);
                            MessageBox.Show("Törlés sikeres!");

                        }
                        else
                        {
                            MessageBox.Show("Törlés sikertelen!");
                        }
                    
                }
                }
                catch (NullReferenceException)
                {
                    MessageBox.Show("A funkció használatához be kell jelentkezni!");
                }
                catch (EndpointNotFoundException)
                {
                    MessageBox.Show("Hiba a kiszolgálóval!");
                }
                catch (FaultException<LoginFailedFault> ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("hiba: " + ex.Message);
                }
            }
            else { MessageBox.Show("Id csak szám lehet!"); }
        }

        private void Button_Update_Click(object sender, EventArgs e)
        {
            if (textBox_id.Text.All(char.IsDigit)&&textBox_id.Text!=""&&textBox_id.Text!=null)
            {
                validdata(textBox_id.Text);
                if (success)
                {
                    try
                    {
                        string id = textBox_id.Text;
                        string name = textBox_name.Text;
                        string rating = textBox_rating.Text;
                        string length = textBox_length.Text;
                        string releaseYear = textBox_releaseYear.Text;

                        if (textBox_id.Text == "" || textBox_name.Text == "" || textBox_rating.Text == "" || textBox_length.Text == "" || textBox_releaseYear.Text == "")
                        {
                            MessageBox.Show("Minden mező kitöltése kötelező!");
                        }
                        else
                        {
                            bool updateResult = client.Update(id, name, rating, length, releaseYear, userClient, "Zsolti|wcf");

                            if (updateResult)
                            {
                                Button_List_Click(sender, e);
                                MessageBox.Show("Sikeres adatmódosítás!");
                            }
                            else
                            {
                                MessageBox.Show("Sikertelen adatmódosítás!");
                            }
                        }
                    }
                    catch (NullReferenceException)
                    {
                        MessageBox.Show("A funkció használatához be kell jelentkezni!");
                    }
                    catch (EndpointNotFoundException)
                    {
                        MessageBox.Show("Hiba a kiszolgálóval!");
                    }
                    catch (FaultException<LoginFailedFault> ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hiba: " + ex.Message);
                    }
                }
            }
            else { MessageBox.Show("Id csak szám lehet!"); }
        }
        private string tmp_id;
        private string tmp_name;
        private string tmp_length;
        private string tmp_rating;
        private string tmp_releaseYear;



        private void validdata(string id)
        {
            success = false;
            try
            { ICollection<Book> oneResult = client.ListById(id, userClient, "Zsolti|wcf");
                success = true;
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("A funkció használatához be kell jelentkezni!");
            }
            catch (EndpointNotFoundException)
            {
                MessageBox.Show("Hiba a kiszolgálóval!");
            }
            catch (FaultException<LoginFailedFault> ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (FaultException<BookNotFoundFault> ex)
            {
                MessageBox.Show(ex.Reason.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("hiba: " + ex.Message);
            }

        }


        
        private void likeordislike()
        {
            success = false;
            if (textBox_like.Text.All(char.IsDigit) && textBox_like.Text!=""&& textBox_like.Text!=null)
            {
                
                try
                {
                    ICollection<Book> oneResult = client.ListById(textBox_like.Text, userClient, "Zsolti|wcf");
                    foreach (Book book in oneResult)
                    {
                        tmp_id = book.id.ToString();
                        tmp_length = book.length;
                        tmp_name = book.name;
                        tmp_rating = book.rating;
                        tmp_releaseYear = book.releaseYear;
                    }

                    success = true;
                }
                catch (NullReferenceException)
                {
                    MessageBox.Show("A funkció használatához be kell jelentkezni!");
                }
                catch (EndpointNotFoundException)
                {
                    MessageBox.Show("Hiba a kiszolgálóval!");
                }
                catch (FaultException<LoginFailedFault> ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (FaultException<BookNotFoundFault> ex)
                {
                    MessageBox.Show(ex.Reason.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("hiba: " + ex.Message);
                }
            }
            else { throw new Exception("Id csak szám lehet!"); }
        }

        private void Button_like_Click(object sender, EventArgs e)
        {
            
            try
            {
                likeordislike();
                if (success)
                {
                    string id = tmp_id;
                    string name = tmp_name;
                    string rating = (int.Parse(tmp_rating) + 1).ToString();
                    string length = tmp_length;
                    string releaseYear = tmp_releaseYear;



                    bool updateResult = client.Update(id, name, rating, length, releaseYear, userClient, "Zsolti|wcf");

                    if (updateResult)
                    {
                        Button_List_Click(sender, e);
                        MessageBox.Show("Sikeres Likeolás!");
                    }
                    else
                    {
                        MessageBox.Show("Sikertelen likeolás!");
                    }
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("A funkció használatához be kell jelentkezni!");
            }
            catch (EndpointNotFoundException)
            {
                MessageBox.Show("Hiba a kiszolgálóval!");
            }
            catch (FaultException<LoginFailedFault> ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba: " + ex.Message);
            }


            Button_List_Click(sender,e);


        }

        private void Button_dislike_Click(object sender, EventArgs e)
        {
            try
            {
                likeordislike();
                if (success&&int.Parse(tmp_rating)>0)
                {
                    string id = tmp_id;
                    string name = tmp_name;

                    
                    string rating = (int.Parse(tmp_rating) - 1).ToString();
                    string length = tmp_length;
                    string releaseYear = tmp_releaseYear;



                    bool updateResult = client.Update(id, name, rating, length, releaseYear, userClient, "Zsolti|wcf");

                    if (updateResult)
                    {
                        Button_List_Click(sender, e);
                        MessageBox.Show("Sikeres DisLikeolás!");
                    }
                    else
                    {
                        MessageBox.Show("Sikertelen Dislikeolás!");
                    }
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("A funkció használatához be kell jelentkezni!");
            }
            catch (EndpointNotFoundException)
            {
                MessageBox.Show("Hiba a kiszolgálóval!");
            }
            catch (FaultException<LoginFailedFault> ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba: " + ex.Message);
            }


            Button_List_Click(sender, e);


        }

        private void Button_login_Click(object sender, EventArgs e)
        {
            
            Login login = new Login();
            this.Hide();
            
            login.ShowDialog();
            this.Close();

        }
    }
    }

    

