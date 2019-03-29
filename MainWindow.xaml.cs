/*Jesse Stanley
 *3/27/2019
 *TXT Message translater
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
            if (txtInput.Text == "CU") 
            {
                lblLabel.Content = "see you";
            }
            else if (txtInput.Text == ":-)")
            {
                lblLabel.Content = "I'm happy";
            }
            else if (txtInput.Text == ":-(")
            {
                lblLabel.Content = "I'm unhappy";
            }
            else if (txtInput.Text == ";-)")
            {
                lblLabel.Content = "wink";
            }
            else if (txtInput.Text == ":-P")
            {
                lblLabel.Content = "Stick out toungue";
            }
            else if (txtInput.Text == "(~.~)")
            {
                lblLabel.Content = "sleepy";
            }
            else if (txtInput.Text == "TA")
            {
                lblLabel.Content = "totally awesome";
            }
            else if (txtInput.Text == "CCC")
            {
                lblLabel.Content = "Canadian Computing Competition";
            }
            else if (txtInput.Text == "CUZ")
            {
                lblLabel.Content = "because";
            }
            else if (txtInput.Text == "TY")
            {
                lblLabel.Content = "thank-you";
            }
            else if (txtInput.Text == "YW")
            {
                lblLabel.Content = "you're welcome";
            }
            else if (txtInput.Text == "TTYL")
            {
                lblLabel.Content = "talk to you later";
            }
        }
    }
}
