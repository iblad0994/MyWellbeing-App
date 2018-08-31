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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.IO;
using System.Data.SqlClient;
using System.Threading;


namespace MyWellbeing
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
        // SqlConnection dbConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Mr.Oladipo\Documents\MyWellbeing.mdf"; Integrated Security=True;Connect Timeout=30");
        //   SqlConnection dbConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Kinect\Kinect\GaitDatabase_original\GaitDatabase.mdf;Integrated Security=True;Connect Timeout=30");

       // public System.Windows.SizeToContent SizeToContent { get; set; }
       

        internal class UserInformation
        {
            public static string CurrentLoggedInUser
            {
                get;
                set;
            }

            public static string CurrentLoggedInUser2
            {
                get;
                set;
            }
        }

        public string currentEmail;

        private void Button_Click(object sender, RoutedEventArgs e)
        {


              using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\SyngentaEmployee.mdf;Integrated Security=True;Connect Timeout=30"))
           // using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Mr.Oladipo\Desktop\SyngentaEmployee.mdf;Integrated Security=True;Connect Timeout=30"))
            //using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Mr.Oladipo\Desktop\SyngentaEmployee.mdf";Integrated Security=True;Connect Timeout=30"))
            {
                using (SqlCommand cmd = new SqlCommand(" select * from SyngentaTable WHERE LastName = @LastName AND Personnel = @personnel"))
                {
                    
                    cmd.Connection = conn;
                    conn.Open();
                    cmd.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = btn_LastName.Text;
                    cmd.Parameters.Add("@personnel", SqlDbType.NVarChar).Value = btn_EmployeeNumber.Text;
                    using (SqlDataReader re = cmd.ExecuteReader())
                    {

                        if (re.Read())
                        {
                            UserInformation.CurrentLoggedInUser = (string)re["KnownAs"];
                            UserInformation.CurrentLoggedInUser2 = (string)re["Email"];
                            SecondPage se = new SecondPage();
                            Welcome we = new Welcome();
                            we.Show();
                            this.Hide();
                            we.txt_welcome.Text = "Welcome " + UserInformation.CurrentLoggedInUser;
                            we.txt_Emails.Text = UserInformation.CurrentLoggedInUser2;

                           // MessageBox.Show("login success");

                            //se.txt_YourEmail.Text = UserInformation.CurrentLoggedInUser2;
                        }
                        else
                        {
                        //    MessageBox.Show("Please enter the correct credentials", "alert", MessageBoxButton.OK, MessageBoxImage.Error);
                            MessageBox.Show("Invalid login credentials. Please try again or email health.services@syngenta.com for assistance", "alert", MessageBoxButton.OK, MessageBoxImage.Error);
                        }

                    }
                }
            }


        }

        private void Name_TextChanged(object sender, TextChangedEventArgs e)
        {
          
        }
    }
}
