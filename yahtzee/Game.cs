using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yahtzee
{
    public class Game
    {
        // fields


        // properties
        public List<Player> Players { get; set; }

        public int NumPlayers { get { return Players.Count; } }

        public Player ActivePlayer { get { return MainWindow.Singleton.CurrentGame.Players.First(p => p.IsActive); } }

        public List<Scoring.ScoringHands> AllScoringHands { get; set; }

        // constructors
        public Game() { }

        public Game(List<Player> players)
        {
            Players = players;

            // make the first player active
            Players[0].IsActive = true;

            //c create list of all scoring hands in order
            AllScoringHands = new List<Scoring.ScoringHands>();
            Scoring.ScoringHands[] topHalf = {
                                                 new Scoring.TopHalfScoringHands(1, "ones"),
                                                 new Scoring.TopHalfScoringHands(2, "twos"),
                                                 new Scoring.TopHalfScoringHands(3, "threes"),
                                                 new Scoring.TopHalfScoringHands(4, "fours"),
                                                 new Scoring.TopHalfScoringHands(5, "fives"),
                                                 new Scoring.TopHalfScoringHands(6, "sixes")
                                             };
            Scoring.ScoringHands[] botHalf = {
                                                 new Scoring.ThreeOfAKind(),
                                                 new Scoring.FourOfAKind(),
                                                 new Scoring.FullHouse(),
                                                 new Scoring.SmallStraight(),
                                                 new Scoring.LargeStraight(),
                                                 new Scoring.Yahtzee(),
                                                 new Scoring.Chance()
                                             };
            AllScoringHands.AddRange(topHalf);
            AllScoringHands.AddRange(botHalf);
            

            // initialize players into game
            Players.ForEach(p => p.InitializeIntoGame(this));
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
