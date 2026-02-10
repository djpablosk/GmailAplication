using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GmailAplication
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

       

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
            
            
                SendedEmails.Items.Remove(SendedEmails.SelectedItem);
            
        }

       

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // create and populate email object from UI
            var email = new EmailFormat
            {
                Reciptient = GmailClient.Text,
                Subject = subejctBox.Text ,
                Content = ContentBox.Text
            };  

            // add the EmailFormat object to the ListBox (ToString used for display)
            SendedEmails.Items.Add(email);

            // clear inputs
            GmailClient.Clear();
            subejctBox.Clear();
            ContentBox.Clear();
        }

        private void GmailClient_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (SendedEmails.SelectedItem is EmailFormat selectedEmail)
            {
                // Display the email details including content in a message box
                string details = $"To: {selectedEmail.Reciptient}\nSubject: {selectedEmail.Subject}\n\n{selectedEmail.Content}";
                MessageBox.Show(details, "Email Details", MessageBoxButton.OK, MessageBoxImage.Information);
            }

        }
    }
}