using System.Windows;

namespace Client;

public partial class LoginWindow : Window
{
    public LoginWindow()
    {
        InitializeComponent();
    }
    
    
    
    private void LoginButton_OnClick(object sender, RoutedEventArgs e)
    {
        HelpClass helpClass = new HelpClass();
        //Closes LoginWindow.xaml and opens MainWindow.xaml
        if (helpClass.ReturnTrueIfNotEmpty(UserTextBox.Text))
        {
            MainWindow mainWindow = new MainWindow(UserTextBox.Text);
            mainWindow.Show();
            this.Close();
        }
        else
        {
            MessageBox.Show("Fill in a username before you login to the server!", "Invalid username.", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }

    
    
}