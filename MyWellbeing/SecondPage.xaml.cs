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
using Outlook = Microsoft.Office.Interop.Outlook;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.IO;
using System.Data.SqlClient;
using System.Threading;
using System.Windows.Navigation;
using System.Windows.Media.Animation;




namespace MyWellbeing
{
    /// <summary>
    /// Interaction logic for SecondPage.xaml
    /// </summary>
    /// 

   

    public partial class SecondPage : Window
    {
        private void Too(object sender, ExecutedRoutedEventArgs e)
        {
            e.Handled = true;
        }

        public SecondPage()
        {
           InitializeComponent();
            txt_FixedEmail.CommandBindings.Add(new CommandBinding(ApplicationCommands.Paste, Too));
           
        }

        public string WeightManagementEmail;
        public string QuitSmokingEmail;
        public string ReduceStressEmail;
        public string ImproveHydrationEmail;
        public string BeMoreActiveEmail;
        //  public string EmotionalWellbeingEmail;
        public string FinancialEmail;
        public string AHealthyYouEmail;
        public string WorkLifeBalanceEmail;





             public string greetings = @"<html>
                      <body>
                       <p><h2>Thank you for using the Well-being app!&nbsp; See below for suggestions on how to improve your well-being based on the responses you provided.</h2></p>
                      <p><h3>*******************************************************************************************************************************************</h3></p>
                      </body>
                      </html>
                     ";

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Welcome gg = new Welcome();
            gg.Show();
            this.Hide();
        }
        public static string mailingAdd;

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string MessageBoxTitle = "";
            string MessageBoxContent = "Are you sure you want to start over?";

            MessageBoxResult dialogResult = MessageBox.Show(MessageBoxContent, MessageBoxTitle, MessageBoxButton.YesNo, MessageBoxImage.Error); //MessageBoxImage.Question, MessageBoxImage.Error);
            if (dialogResult == MessageBoxResult.Yes)
            {
                Welcome ss = new Welcome();
               // Thirdpage ss = new Thirdpage();
                this.Hide();

                ss.Show();
            }
            else if (dialogResult == MessageBoxResult.No)
            {
                return;
                //do something else
            }
     

        }

            
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            try
            {
                Outlook.Application _app = new Outlook.Application();
                Outlook.MailItem mail = (Outlook.MailItem)_app.CreateItem(Outlook.OlItemType.olMailItem);
                mail.Subject = "Your Wellbeing Plan"; //txtSubject.Text;  
                mail.To = txt_FixedEmail.Text;
                Thirdpage st = new Thirdpage();
                //mail.HTMLBody = st.WeightManagementThird;
                mail.HTMLBody = greetings + WeightManagementEmail + QuitSmokingEmail + ReduceStressEmail + ImproveHydrationEmail + BeMoreActiveEmail + FinancialEmail + AHealthyYouEmail + WorkLifeBalanceEmail;//"<p><a href=http://www.SyngentaWellbeing.com>Weight Management</a></p> ";//greetings +  WeightManagementEmail + QuitSmokingEmail + ReduceStressEmail + ImproveHydrationEmail + BeMoreActiveEmail  + FinancialEmail + AHealthyYouEmail + WorkLifeBalanceEmail;
                mail.Importance = Outlook.OlImportance.olImportanceNormal;
                ((Outlook._MailItem)mail).Send();
                MessageBox.Show("Your email has been successfully sent.", "Message", MessageBoxButton.OK, MessageBoxImage.Information);
                MainWindow ss = new MainWindow();
                this.Hide();
                ss.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }
        

        internal class UserInformation
        {
            public static string CurrentLoggedInUser
            {
                get;
                set;
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

            Report see = new Report();
            this.Hide();
            see.Show();
                     
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            string MessageBoxTitle = "Logout";
            string MessageBoxContent = "Are you sure you want to logout?";
           

            MessageBoxResult dialogResult = MessageBox.Show(MessageBoxContent, MessageBoxTitle, MessageBoxButton.YesNo, MessageBoxImage.Error); //MessageBoxImage.Question, MessageBoxImage.Error);
            if (dialogResult == MessageBoxResult.Yes)
            {
                MainWindow ms = new MainWindow();
                this.Hide();
                ms.Show();
            }
            else if (dialogResult == MessageBoxResult.No)
            {
                return;
             
            }
                   

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            txt_EmailFinal.Text = Thirdpage.emailReal;
           // txt_FixedEmail.Text = Welcome.userEmail;
            txt_FixedEmail.Text = MainWindow.UserInformation.CurrentLoggedInUser2;

            WeightManagementEmail = Thirdpage.WeightManagementWelcomes;
            QuitSmokingEmail = Thirdpage.QuitWelcome;
            ReduceStressEmail = Thirdpage.ReduceStressWelcomes;
            ImproveHydrationEmail = Thirdpage.ImproveHydrationWelcomes;
            BeMoreActiveEmail = Thirdpage.BeMoreActiveWelcomes;
            // EmotionalWellbeingEmail = Welcome.EmotionalWellbeingWelcomes;
            FinancialEmail = Thirdpage.FinancialWelcomes;
            AHealthyYouEmail = Thirdpage.AHealthyYouWelcomes;
            WorkLifeBalanceEmail = Thirdpage.WorkLifeBalanceWelcomes;
        }

        private void btn_Preffered(object sender, RoutedEventArgs e)
        {
            CustomizedEmail ss = new CustomizedEmail();
            this.Hide();
            ss.Show();
            
        }

        private void txt_FixedEmail_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}


