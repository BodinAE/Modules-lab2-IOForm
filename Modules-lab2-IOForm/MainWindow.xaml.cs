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

namespace Modules_lab2_IOForm
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {   
        List<User> Users = new List<User>();
        public MainWindow()
        {
            InitializeComponent();
            UserListBox.ItemsSource = Users;
        }

        private void InputButton_Click(object sender, RoutedEventArgs e)
        {
            string education = "None";
            if (EducationCheckBox.IsChecked == true)
            {
                education = EducationInput.Text;
            }
            Users.Add(new User(LoginInputBox.Text, PasswordInputBox.Password, NameInputBox.Text, LastnameInputBox.Text, DoBInput.SelectedDate, education));
            ResetInput();
            UserListBox.Items.Refresh();
        }

        private void EducationCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            EducationInput.IsEnabled = true;
        }

        private void EducationCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            EducationInput.IsEnabled = false;
        }
        //private void OutputComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    if (OutputComboBox.SelectedItem is User user) 
        //    {
        //        LoginOutput.Text = user.Login;
        //        PasswordOutput.Text = user.Password;
        //        NameOutput.Text = user.Name;
        //        LastnameOutput.Text = user.Lastname;
        //        string? dob = DoBInput.SelectedDate.ToString();
        //        DoBOutput.SelectedDate = user.DoB;
        //        int eduIndex = 0;
        //        switch (user.Education)
        //        {
        //            case "None":
        //                eduIndex = 0; break;
        //            case "Low":
        //                eduIndex = 1; break;
        //            case "Medium":
        //                eduIndex = 2; break;
        //            case "High":
        //                eduIndex = 3; break;
        //        }
        //        EducationOutput.SelectedIndex = eduIndex;
        //    }
        //}
        private void ResetOutput()
        {
            LoginOutput.Text = "N/A";
            PasswordOutput.Text = "N/A";
            NameOutput.Text = "N/A";
            LastnameOutput.Text = "N/A";
            DoBOutput.SelectedDate = null;
            EducationOutput.SelectedIndex = -1;
        }
        
        private void ResetInput()
        {
            LoginInputBox.Clear();
            PasswordInputBox.Clear();
            NameInputBox.Clear();
            LastnameInputBox.Clear();
            DoBInput.SelectedDate = null;
            EducationCheckBox.IsChecked = false;
            EducationInput.SelectedIndex = -1;
        }

        private void RemoveUserButton_Click(object sender, RoutedEventArgs e)
        {
            if (UserListBox.SelectedItem is User user)
            { 
                Users.Remove(user);
            }
            UserListBox.Items.Refresh();
            ResetOutput();
        }

        private void EditUserButton_Click(object sender, RoutedEventArgs e)
        {
            if (UserListBox.SelectedItem is User user)
            {
                user.Login = LoginOutput.Text;
                user.Password = PasswordOutput.Text;
                user.Name = NameOutput.Text;
                user.Lastname = LastnameOutput.Text;
                user.DoB = DoBOutput.SelectedDate;
                user.Education = EducationOutput.Text;
                UserListBox.Items.Refresh();
            }
        }

        private void UserListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (UserListBox.SelectedItem is User user)
            {
                LoginOutput.Text = user.Login;
                PasswordOutput.Text = user.Password;
                NameOutput.Text = user.Name;
                LastnameOutput.Text = user.Lastname;
                string? dob = DoBInput.SelectedDate.ToString();
                DoBOutput.SelectedDate = user.DoB;
                int eduIndex = 0;
                switch (user.Education)
                {
                    case "None":
                        eduIndex = 0; break;
                    case "Low":
                        eduIndex = 1; break;
                    case "Medium":
                        eduIndex = 2; break;
                    case "High":
                        eduIndex = 3; break;
                }
                EducationOutput.SelectedIndex = eduIndex;
            }
        }
    }
}