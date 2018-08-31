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

namespace MyWellbeing
{
    /// <summary>
    /// Interaction logic for CustomizedEmail.xaml
    /// </summary>
    public partial class CustomizedEmail : Window
    {
        // This code disallows copy and paste
        private void Foo(object sender, ExecutedRoutedEventArgs e)
        {
            e.Handled = true;
        }
        private void coo(object sender, ExecutedRoutedEventArgs e)
        {
            e.Handled = true;
        }

        public CustomizedEmail()
        {
            InitializeComponent();
            txt_customizedEmail.CommandBindings.Add(new CommandBinding(ApplicationCommands.Paste, Foo));
            txt_customiseEmailSEC.CommandBindings.Add(new CommandBinding(ApplicationCommands.Paste, coo));
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
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
                      <p><h2>Thank you for starting your journey to a healthy you!&nbsp; See below for suggestions on how to improve your well-being based on your selections.</h2></p>
                      <p><h3>*******************************************************************************************************************************************</h3></p>
                      </body>
                      </html>
                     ";
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(txt_customizedEmail.ToString() != txt_customiseEmailSEC.ToString())
            {
                MessageBox.Show("Your Email address does not match, Please retype");
            }
            else
            { 
            try
            {
                Outlook.Application _app = new Outlook.Application();
                Outlook.MailItem mail = (Outlook.MailItem)_app.CreateItem(Outlook.OlItemType.olMailItem);
                mail.Subject = "Your Wellbeing Plan"; //txtSubject.Text;  
                mail.To = txt_customizedEmail.Text;
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
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            this.Hide();
            SecondPage me = new SecondPage();
            me.Show();
        }

        private void txt_customizedEmail_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
