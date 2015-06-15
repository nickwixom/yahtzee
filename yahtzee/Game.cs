﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using yahtzee.Scoring;

namespace yahtzee
{
    public class Game : INotifyPropertyChanged
    {
        // fields

        private List<Player> players = new List<Player>();
        // properties
        public List<Player> Players 
        {
            get { return players; }
            set
            {
                players = value;

                PropertyChanged.Raise(this, "Players");
            }
        }

        public int NumPlayers { get { return Players.Count; } }

        public Player ActivePlayer 
        {
            get { return MainWindow.Singleton.CurrentGame.Players.First(p => p.IsActive); }
            set
            {
                Player p = value;

                PropertyChanged.Raise(this, "ActivePlayer");
            }
        }

        // constructors
        public Game() { }

        public Game(List<Player> players)
        {
            Players = players;

            // make the first player active
            Players[0].IsActive = true;

            

            // initialize players into game
            Players.ForEach(p => p.InitializeIntoGame(this));
        }

        // methods
        public void NewTurn()
        {
            // make the next player active
            MainWindow.Singleton.CurrentGame.ActivePlayer.Next().IsActive = true;
            // give a new hand
            MainWindow.Singleton.CurrentGame.ActivePlayer.CurrentHand.Reset();
        }

        // static methods
        static public Game NewDefaultGame()
        {
            List<Player> players = new List<Player>(2) { new Player("Oli"), new Player("Nick") };

            // start a new game with these players
            return new Game(players);
        }




        public event PropertyChangedEventHandler PropertyChanged;
    }
}
