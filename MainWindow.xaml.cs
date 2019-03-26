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
            TextEntered = TextEntered.Replace("see you", "CU");
            TextEntered = TextEntered.Replace(":-)", "I'm happy");
            TextEntered = TextEntered.Replace("I'm happy", ":-)");
            TextEntered = TextEntered.Replace(":-(", "I'm unhappy");
            TextEntered = TextEntered.Replace("I'm unhappy", ":-(");
            TextEntered = TextEntered.Replace(";-)", "wink");
            TextEntered = TextEntered.Replace("wink", ";-)");
            TextEntered = TextEntered.Replace(":-P", "stick out tongue");
            TextEntered = TextEntered.Replace("stick out tongue", ":-P");
            TextEntered = TextEntered.Replace("(˜.˜)", "sleepy");
            TextEntered = TextEntered.Replace("sleepy", "(˜.˜)");
            TextEntered = TextEntered.Replace("TA", "totally awesome");
            TextEntered = TextEntered.Replace("totally awesome", "TA");
            TextEntered = TextEntered.Replace("CCC", "Canadian Computing Competition");
            TextEntered = TextEntered.Replace("Canadian Computing Competition", "CCC");
            TextEntered = TextEntered.Replace("CUZ", "because");
            TextEntered = TextEntered.Replace("because", "CUZ");
            TextEntered = TextEntered.Replace("TY", "thank-you");
            TextEntered = TextEntered.Replace("thank-you", "TY");
            TextEntered = TextEntered.Replace("YW", "you're welcome");
            TextEntered = TextEntered.Replace("you're welcome", "YW");
            TextEntered = TextEntered.Replace("TTYL", "talk to you later");
            TextEntered = TextEntered.Replace("talk to you later", "TTYL");
            lblLabel.Content = TextEntered;
        }
    }
}
