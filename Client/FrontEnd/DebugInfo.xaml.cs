using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Client
{
  /// <summary>
  /// Interaction logic for DebugInfo.xaml
  /// </summary>
  public partial class DebugInfo : Window
  {
    TextBox txtbox;
    List<string> buffer;
    public DebugInfo()
    {
      InitializeComponent();
      buffer = new List<string>(100);
      txtbox = (TextBox)FindName("Debug_TextBox");
    }

    public void WriteDebugLine(string s)
    {
      buffer.Add(s);
      StringBuilder sb = new StringBuilder();
      foreach (string str in buffer)
      {
        sb.Append(str + System.Environment.NewLine);
      }
      txtbox.Text = sb.ToString();
    }
  }
}
