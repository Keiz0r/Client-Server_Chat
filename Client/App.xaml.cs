using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Client
{
  /// <summary>
  /// Interaction logic for App.xaml
  /// </summary>
  public partial class App : Application
  {
    void App_Startup(object sender, StartupEventArgs e)
    {
      DebugInfo debugWindow = new DebugInfo();
      debugWindow.Top = 100;
      debugWindow.Left = 800;
      debugWindow.Show();
    }
  }
}
