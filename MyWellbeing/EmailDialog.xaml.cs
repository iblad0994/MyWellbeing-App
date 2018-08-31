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
using System.Net.Mail;
using System.Net.Http;



namespace MyWellbeing
{
    /// <summary>
    /// Interaction logic for EmailDialog.xaml
    /// </summary>
    public partial class EmailDialog : Window
    {
        public EmailDialog()
        {
            InitializeComponent();
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
               txt_FixedEmail.Text = SecondPage.mailingAdd;
           //   WeightManagementEmail = Welcome.WeightManagementWelcomes;
           //   QuitSmokingEmail = Welcome.QuitSmokingWelcomes;
           //   ReduceStressEmail = Welcome.ReduceStressWelcomes;
           //   ImproveHydrationEmail = Welcome.ImproveHydrationWelcomes;
           // BeMoreActiveEmail = Welcome.BeMoreActiveWelcomes;
           //// EmotionalWellbeingEmail = Welcome.EmotionalWellbeingWelcomes;
           // FinancialEmail = Welcome.FinancialWelcomes;
           // AHealthyYouEmail = Welcome.AHealthyYouWelcomes;
           // WorkLifeBalanceEmail = Welcome.WorkLifeBalanceWelcomes;


            // Syntax new

           
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
//       public string greetings = @"<p><strong>Thank You!</strong> You choose to enhance the following below:&nbsp;</p>
//<p>Please click on each of the preference to go to the website.</p>
//<p>Thanks,</p>";

        public string greetings = @"<html>
                      <body>
                      <p><h2>Thank you for using the Well-being app!&nbsp; See below for suggestions on how to improve your well-being based on the responses you provided.</h2></p>
                      <p><h3>*******************************************************************************************************************************************</h3></p>
                      </body>
                      </html>
                     ";
        //public string greetings = @"<html>
        //              <body>
        //              <p>Thank you for using the myWellbeing app!&nbsp; See below for suggestions on how to enhance your wellbeing based on the responses you provided.</p>
        //              <p><h3>In health,</h3><h3>Health Services</h3></p>
        //              </body>
        //              </html>
        //             ";
        private void Button_Click(object sender, RoutedEventArgs e)
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

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            CustomizedEmail see = new CustomizedEmail();
            this.Hide();
            see.Show();
            //MessageBox.Show("You have to contact the Health Services department to have your correct email loaded on file. Sorry for the inconvenience \n \n Click on Exit to Logout");
            
           // return;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MainWindow ss = new MainWindow();
            this.Hide();
            ss.Show();
        }
    }
}
