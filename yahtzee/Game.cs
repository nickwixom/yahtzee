using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yahtzee
{
    public class Game
    {
        // properties
        public List<Player> Players { get; set; }

        public int NumPlayers { get { return Players.Count; } }

        public Player ActivePlayer { get { return MainWindow.Singleton.CurrentGame.Players.First(p => p.IsActive); } }

        // constructors
        public Game() { }

        public Game(List<Player> players)
        {
            Players = players;

        }

        // methods
        public void NewTurn()
        {
            // make the next player active
            MainWindow.Singleton.CurrentGame.ActivePlayer.Next().IsActive = true;
        }

        
        // static methods
        static public Game NewDefaultGame()
        {
            List<Player> players = new List<Player>(2) { new Player("Oli"), new Player("Nick") };

            // start a new game with these players

            return new Game(players);
        }

    }
}
