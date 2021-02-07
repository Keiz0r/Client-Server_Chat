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

namespace Client
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    DebugInfo debugWindow;
    TextBox username_txtbox;
    public MainWindow()
    {
      InitializeComponent();
      debugWindow = Application.Current.Windows.OfType<DebugInfo>().FirstOrDefault();
      username_txtbox = (TextBox)FindName("Name_TextBox");
    }

    private void Name_TextBox_TextChanged(object sender, TextChangedEventArgs e)
    {

    }

    private void Password_TextBox_TextChanged(object sender, TextChangedEventArgs e)
    {

    }

    private void Login_Button_Click(object sender, RoutedEventArgs e)
    {
      debugWindow.WriteDebugLine(username_txtbox.Text);
    }
  }
}
