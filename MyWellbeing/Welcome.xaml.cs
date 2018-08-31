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
    /// Interaction logic for Welcome.xaml
    /// </summary>
    public partial class Welcome : Window
    {
      //  MainWindow MS = new MainWindow();

        public Welcome()
        {

           
            InitializeComponent();
         
        }
        
  



        //*****************************************************************

        public static string WeightManagementWelcomes;
        public static string QuitSmokingWelcomes;
        public static string ReduceStressWelcomes;
        public static string ImproveHydrationWelcomes;
        public static string BeMoreActiveWelcomes;
      //  public static string EmotionalWellbeingWelcomes;
        public static string FinancialWelcomes;
        public static string AHealthyYouWelcomes;
        public static string WorkLifeBalanceWelcomes;


        //******************************************************************************
        //SecondPage we = new SecondPage();
        Thirdpage thirds = new Thirdpage();

       
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        public void SelectAll()
        {
            if (chk_SelectAll.IsChecked == true)
            {
                chk_Weight.IsChecked = true;
                chk_AHealthy.IsChecked = true;
                chk_Financial.IsChecked = true;
                chk_Improve.IsChecked = true;
                chk_Quit.IsChecked = true;
                chk_Reduce.IsChecked = true;
                chk_ImproveHydration.IsChecked = true;
                chk_WorkLife.IsChecked = true;
                    
            }
        }

        public static string userEmail;


        public static bool WeightManagementCHECKED;
        public static bool QuitSmokingingCHECKED;
        public static bool QuitChecked;
        public static bool ReduceStressCHECKED;
        public static bool ImproveHydrationCHECKED;
        public static bool ImproveStaminaCHECKED;
        public static bool FinancialCHECKED;
        public static bool AHealthyYouCHECKED;
        public static bool WorkLifeBalanceCHECKED;

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if ((chk_Weight.IsChecked == false) && (chk_AHealthy.IsChecked == false) && (chk_Financial.IsChecked == false) && (chk_Improve.IsChecked == false) && (chk_ImproveHydration.IsChecked == false) && (chk_Quit.IsChecked == false) && (chk_Reduce.IsChecked == false) && (chk_WorkLife.IsChecked == false))
            {
                MessageBox.Show("Please, select at least one checkbox to continue", "Alert", MessageBoxButton.OK, MessageBoxImage.Error);
                return;

            }
            else
            {

                // ************************************ Insert of the string values

                if (chk_Weight.IsChecked == true)
                {
                    
                    WeightManagementCHECKED = true;
//                       
                }
                else
                {
                    WeightManagementWelcomes = "";
                }
                

                if(chk_Quit.IsChecked == true)
                {
                    
                    QuitChecked = true;
 //                 
                }
                else
                {
                    QuitSmokingWelcomes = "";
                }


                if (chk_Reduce.IsChecked == true)
                {
                    ReduceStressCHECKED = true;
//                   
                }
                else
                {
                    ReduceStressWelcomes = "";
                }

                if(chk_ImproveHydration.IsChecked == true)
                {
                    ImproveHydrationCHECKED = true;
//                   
                }

                else
                {
                    ImproveHydrationWelcomes = "";
                }

                if(chk_Improve.IsChecked == true)
                {
                    ImproveStaminaCHECKED = true;
//                   
                }
                else
                {
                    BeMoreActiveWelcomes = "";
                }

//                

                if(chk_Financial.IsChecked == true)
                {
                    FinancialCHECKED = true;
//                   
                }
                else
                {
                    FinancialWelcomes = "";
                }


                if(chk_AHealthy.IsChecked == true)
                {
                    AHealthyYouCHECKED = true;
//               
                }
                else
                {
                    AHealthyYouWelcomes = "";
                }
                   

                if(chk_WorkLife.IsChecked == true)
                {
                    WorkLifeBalanceCHECKED = true;
//                 
                }
                else
                {
                    WorkLifeBalanceWelcomes = "";
                }


                //************************************************************************
              //  **************work here
                if (chk_Weight.IsChecked == false)
                {
                    thirds.tabWeightMgt.Visibility = Visibility.Collapsed;
                    //thirds.tabWeightManagement.Visibility = Visibility.Collapsed;
                   // thirds.tabWeightMgt.IsEnabled = false;
                    
                    //thirds.tabWeightMgt.IsEnabled = true;
                    //thirds.tabWeightManagement.Visibility = Visibility.Visible;
                }

            if (chk_AHealthy.IsChecked == false)
            {
                    thirds.tabAhealthyYou.Visibility = Visibility.Collapsed;
                  //  thirds.tabAhealthyYou.IsEnabled = false;
                    //thirds.tab2A_Healthy_You.Visibility = Visibility.Hidden;
                    //thirds.tabAhealthyYou.Visibility = Visibility.Collapsed;
                    //  thirds.tabAhealthyYou.IsEnabled = true;
                }
              
                //if (chk_Emotional.IsChecked == false)
                //{
                //    thirds.tabEmotionalWellbeing.Visibility = Visibility.Collapsed;
                //    //thirds.tabEmotionalWellbeing.IsEnabled = true;
                //}
            if (chk_Financial.IsChecked == false)
            {
                thirds.tabFinancial.Visibility = Visibility.Collapsed;
                    //thirds.tabFinancial.IsEnabled = false;
                    // thirds.tabFinancial.IsEnabled = true;
                }
            if (chk_Improve.IsChecked == false)
            {
                thirds.tabImproveStamina.Visibility = Visibility.Collapsed;
                    //thirds.tabImproveStamina.IsEnabled = false;
                    //thirds.tabImproveStamina.IsEnabled = true;
                }
            if (chk_ImproveHydration.IsChecked == false)
            {
                thirds.tabImproveHyd.Visibility = Visibility.Collapsed;
                   // thirds.tabImproveHyd.IsEnabled = false;

                    // thirds.tabImproveHyd.IsEnabled = true;
                }
            if (chk_Quit.IsChecked == false)
            {
                thirds.tabQuitSmoking.Visibility = Visibility.Collapsed;
                    //thirds.tabQuitSmoking.IsEnabled = false;
                    //thirds.tabQuitSmoking.IsEnabled = true;
                }
            if (chk_Reduce.IsChecked == false)
            {
               thirds.tabReduceStress.Visibility = Visibility.Collapsed;
                   // thirds.tabReduceStress.IsEnabled = false;
                    //thirds.tabReduceStress.IsEnabled = true;
                }
            if (chk_WorkLife.IsChecked == false)
            {
               thirds.tabWorkLife.Visibility = Visibility.Collapsed;
                  //  thirds.tabWorkLife.IsEnabled = false;

                    // thirds.tabWorkLife.IsEnabled = true;
                }

        
        }
            userEmail = txt_Emails.Text;           
            this.Hide();
            thirds.Show(); 
            
         
        }

        private void chk_Weight_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void chk_SelectAll_Checked(object sender, RoutedEventArgs e)
        {
            chk_Weight.IsChecked = true;
            chk_AHealthy.IsChecked = true;
            chk_Financial.IsChecked = true;
            chk_Improve.IsChecked = true;
            chk_Quit.IsChecked = true;
            chk_Reduce.IsChecked = true;
            chk_ImproveHydration.IsChecked = true;
            chk_WorkLife.IsChecked = true;

        }

        private void chk_SelectAll_Unchecked(object sender, RoutedEventArgs e)
        {
            chk_Weight.IsChecked = false;
            chk_AHealthy.IsChecked = false;
            chk_Financial.IsChecked = false;
            chk_Improve.IsChecked = false;
            chk_Quit.IsChecked = false;
            chk_Reduce.IsChecked = false;
            chk_ImproveHydration.IsChecked = false;
            chk_WorkLife.IsChecked = false;
        }
    }
}
