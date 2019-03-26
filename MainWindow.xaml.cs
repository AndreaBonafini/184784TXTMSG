/*Jesse Stanley
* 3/26/2019
* text message translater
*/
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

namespace _184784TXTMSG
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
        private void btnButton_Click_1(object sender, RoutedEventArgs e)
        {
            string TextEntered = txtTextbox.Text;
            TextEntered = TextEntered.Replace("CU", "see you");
            TextEntered = TextEntered.Replace(":-)", "I'm happy");
            TextEntered = TextEntered.Replace(":-(", "I'm unhappy");
            TextEntered = TextEntered.Replace(";-)", "wink");
            TextEntered = TextEntered.Replace(":-P", "stick out tongue");
            TextEntered = TextEntered.Replace("(˜.˜)", "sleepy");
            TextEntered = TextEntered.Replace("TA", "totally awesome");
            TextEntered = TextEntered.Replace("CCC", "Canadian Computing Competition");
            TextEntered = TextEntered.Replace("CUZ", "because");
            TextEntered = TextEntered.Replace("TY", "thank-you");
            TextEntered = TextEntered.Replace("YW", "you're welcome");
            TextEntered = TextEntered.Replace("TTYL", "talk to you later");
            lblLabel.Content = TextEntered;
        }
    }
}
