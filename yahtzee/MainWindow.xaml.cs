using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualBasic;
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

namespace yahtzee
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
        // opens a window to input number/names of players on start click
        private void start_Click(object sender, RoutedEventArgs e)
        {
            string numPlayersString = Interaction.InputBox("How many players (up to 4)?", "Players", "1");
            int numPlayers=Convert.ToInt32(numPlayersString);
            if (numPlayers == 1)
            {
                string player1Name = Interaction.InputBox("Enter Player 1 name: ", "Player 1 name","Player 1");
            }
            else if (numPlayers == 2)
            {
                string player1Name = Interaction.InputBox("Enter Player 1 name: ", "Player 1 name", "Player 1");
                string player2Name = Interaction.InputBox("Enter Player 2 name: ", "Player 2 name", "Player 2");
            }
            else if (numPlayers == 3)
            {
                string player1Name = Interaction.InputBox("Enter Player 1 name: ", "Player 1 name", "Player 1");
                string player2Name = Interaction.InputBox("Enter Player 2 name: ", "Player 2 name", "Player 2");
                string player3Name = Interaction.InputBox("Enter Player 3 name: ", "Player 3 name", "Player 3");
            }
            else if (numPlayers == 4)
            {
                string player1Name = Interaction.InputBox("Enter Player 1 name: ", "Player 1 name", "Player 1");
                string player2Name = Interaction.InputBox("Enter Player 2 name: ", "Player 2 name", "Player 2");
                string player3Name = Interaction.InputBox("Enter Player 3 name: ", "Player 3 name", "Player 3");
                string player4Name = Interaction.InputBox("Enter Player 4 name: ", "Player 4 name", "Player 4");
            }
        }

        private void lockOne_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("temp", "temp", MessageBoxButton.OKCancel, MessageBoxImage.Information);
        }

        private void lockTwo_Click(object sender, RoutedEventArgs e)
        {

        }

        private void lockThree_Click(object sender, RoutedEventArgs e)
        {

        }

        private void lockFour_Click(object sender, RoutedEventArgs e)
        {

        }

        private void lockFive_Click(object sender, RoutedEventArgs e)
        {

        }



    }
}
