using Avalonia.Controls;
using System.Threading.Tasks;

namespace MyFile.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    public async void EnterClick(object sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        var input1 = LoginTextBox.Text; var input2 = PasswordTextBox.Text;
        //�������� ������ � ������
        if (input1 == "n" && input1 == input2)
        {
            StatusMessage.Text = "�������!"; StatusMessage.Foreground = new Avalonia.Media.SolidColorBrush(Avalonia.Media.Colors.Green); //����� ����� �� �������
            await Task.Delay(2000);
            var newWindow = new Window1();
            newWindow.Show();
            this.Close();
        }
        else
        {
            StatusMessage.Text = "������ �� ��������� ��� �������.";
            StatusMessage.Foreground = new Avalonia.Media.SolidColorBrush(Avalonia.Media.Colors.Red); //����� ����� �� �������
        }
    }
}
