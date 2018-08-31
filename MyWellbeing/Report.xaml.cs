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
using System.Data;
using System.Windows.Navigation;

using System.ComponentModel;
using System.Drawing;
using System.Diagnostics;
using System.IO;
using System.Data.SqlClient;
using System.Threading;

namespace MyWellbeing
{
    /// <summary>
    /// Interaction logic for Report.xaml
    /// </summary>
    public partial class Report : Window
    {
        public Report()
        {
            InitializeComponent();
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Welcome wel = new Welcome();
            SqlConnection dbConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\SyngentaEmployee.mdf;Integrated Security=True;Connect Timeout=30");
            //try
            //{
                //dbConnection.Open();
               // string Query = " Select * from Syngentatable";
                dbConnection.Open();
                SqlCommand command4 = dbConnection.CreateCommand();
                command4.CommandType = CommandType.Text;
                command4.CommandText = " Select * from Description ";
                command4.ExecuteNonQuery();
                DataTable dTable5 = new DataTable();
                SqlDataAdapter dbAdapter5 = new SqlDataAdapter(command4);
                dbAdapter5.Fill(dTable5);
                dataGridView1.ItemsSource = dTable5.DefaultView;
                dbAdapter5.Update(dTable5);
                dbConnection.Close();
          
        }

    }
}
