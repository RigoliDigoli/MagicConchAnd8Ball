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


namespace HelloWPF
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
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Generates random number based on setting
            Random rand;
            rand = new Random();

            // randNum for Magic Conch
            // Calls Magic Conch function
            if (Proj.Text == "Magic Conch")
            {
                askButton.Content = "Consult Conch";
                mainWindow.Title = "Magic Conch";
                int randNum = rand.Next(0, 6);
                MagicConch(randNum);
            }
            else if (Proj.Text == "Magic 8 Ball")
            {
                askButton.Content = "Shake Ball";
                mainWindow.Title = "Magic 8 Ball";
                int randNum = rand.Next(0, 20);
                Magic8Ball(randNum);
            }

        }

        private void MagicConch(int randNum)
        {

            switch (randNum)
            {
                case 0:
                    DisplayText.Text = "No";
                    break;
                case 1:
                    DisplayText.Text = "NOoOoO";
                    break;
                case 2:
                    DisplayText.Text = "Try asking again";
                    break;
                case 3:
                    DisplayText.Text = "I don't think so";
                    break;
                case 4:
                    DisplayText.Text = "Nothing";
                    break;
                case 5:
                    DisplayText.Text = "Neither";
                    break;
            }
        }

        private void Magic8Ball(int randNum)
        {
            switch (randNum)
            {
                case 0:
                    DisplayText.Text = "It is certain";
                    break;
                case 1:
                    DisplayText.Text = "It is decidedly so";
                    break;
                case 2:
                    DisplayText.Text = "Without a doubt";
                    break;
                case 3:
                    DisplayText.Text = "Yes definitely";
                    break;
                case 4:
                    DisplayText.Text = "You may rely on it";
                    break;
                case 5:
                    DisplayText.Text = "As I see it, yes";
                    break;
                case 6:
                    DisplayText.Text = "Most likely";
                    break;
                case 7:
                    DisplayText.Text = "Outlook good";
                    break;
                case 8:
                    DisplayText.Text = "Yes";
                    break;
                case 9:
                    DisplayText.Text = "Signs point to yes";
                    break;
                case 10:
                    DisplayText.Text = "Reply hazy, try again";
                    break;
                case 11:
                    DisplayText.Text = "Ask again later";
                    break;
                case 12:
                    DisplayText.Text = "Better not tell you now";
                    break;
                case 13:
                    DisplayText.Text = "Cannot predict now";
                    break;
                case 14:
                    DisplayText.Text = "Concentrate and ask again";
                    break;
                case 15:
                    DisplayText.Text = "Don’t count on it";
                    break;
                case 16:
                    DisplayText.Text = "My reply is no";
                    break;
                case 17:
                    DisplayText.Text = "My sources say no";
                    break;
                case 18:
                    DisplayText.Text = "Outlook not so good";
                    break;
                case 19:
                    DisplayText.Text = "Very doubtful";
                    break;


            }
        }

    }
}
