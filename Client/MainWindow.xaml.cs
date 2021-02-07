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
  public partial class MainWindow : Window
  {
    public string UserName { get; set; }
    public string Password { get; set; }
    DebugInfo debugWindow;
    public MainWindow()
    {
      InitializeComponent();
      debugWindow = Application.Current.Windows.OfType<DebugInfo>().FirstOrDefault();
    }

    private void Login_Button_Click(object sender, RoutedEventArgs e)
    {
      debugWindow.WriteDebugLine("Username: " + UserName + "\t Password: " + Password);
    }
  }
}
