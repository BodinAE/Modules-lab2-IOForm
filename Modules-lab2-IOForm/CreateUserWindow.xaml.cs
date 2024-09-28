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

namespace Modules_lab2_IOForm
{
    /// <summary>
    /// Логика взаимодействия для CreateUserWindow.xaml
    /// </summary>
    public partial class CreateUserWindow : Window
    {
        public MainWindow mw {  get; set; }
        public CreateUserWindow()
        {
            InitializeComponent();
        }
        private void InputButton_Click(object sender, RoutedEventArgs e)
        {
            string education = "None";
            if (EducationCheckBox.IsChecked == true)
            {
                education = EducationInput.Text;
            }
            MainWindow.Users.Add(new User(LoginInputBox.Text, PasswordInputBox.Password, NameInputBox.Text, LastnameInputBox.Text, DoBInput.SelectedDate, education));
            mw.UserListBox.Items.Refresh();
            this.Close();
            
        }

        private void EducationCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            EducationInput.IsEnabled = true;
        }

        private void EducationCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            EducationInput.IsEnabled = false;
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
    }
}
