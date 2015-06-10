﻿using System;
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
using yahtzee.Scoring;

using Mogre;
using MogreNewt;

namespace yahtzee
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Game CurrentGame { get; set; }

        public static MainWindow Singleton { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            Singleton = this;

            CurrentGame = Game.NewDefaultGame();

            DataContext = CurrentGame;

        }

        // opens a window to input number/names of players on start click
        private void start_Click(object sender, RoutedEventArgs e)
        {
            /*
            bool validEntry = true;

            int numPlayers = 1;

            while (validEntry)
            {
                string numPlayersString = Interaction.InputBox("How many players (up to 4)?", "Players", "1");

                // convert string to a number and ensure it is within bounds
                
                bool success = Int32.TryParse(numPlayersString, out numPlayers);

                if (!success)
                {
                    MessageBox.Show("Not a number");
                }
                else if (numPlayers < 1 || numPlayers > 4)
                {
                    MessageBox.Show("Number of players is incorrect");
                }
                else
                {
                    // succesful entry
                    validEntry = false;
                }
            }

            
            List<Player> players = new List<Player>();
            string playerName;

            for (int i = 0; i < numPlayers; i++)
			{
			    playerName = Interaction.InputBox(string.Format("Enter Player {0} name: ", i + 1), string.Format("Player {0} name", i + 1), string.Format("Player {0}", i + 1));

                players.Add(new Player(playerName));
			}
            */

            // short way...
       //     List<Player> players = new List<Player>(2) { new Player("Oli"), new Player("Nick") };

            // start a new game with these players

      //      CurrentGame = new Game(players);

            
            // even shorter way....

            // make the first player active
            
        }

        private void roll_Click(object sender, RoutedEventArgs e)
        {
            CurrentGame.ActivePlayer.CurrentHand.Roll();


        }




    }
}
