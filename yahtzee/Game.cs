using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using yahtzee.Scoring;

namespace yahtzee
{
    public class Game
    {
        // fields


        // properties
        public List<Player> Players { get; set; }

        public int NumPlayers { get { return Players.Count; } }

        public Player ActivePlayer { get { return MainWindow.Singleton.CurrentGame.Players.First(p => p.IsActive); } }

        public List<ScoringHands> LowerScoringHands { get; set; }

        public List<ScoringHands> UpperScoringHands { get; set; }

        // constructors
        public Game() { }

        public Game(List<Player> players)
        {
            Players = players;

            // make the first player active
            Players[0].IsActive = true;

            // create list of all scoring hands in order
            LowerScoringHands = new List<ScoringHands>();
            UpperScoringHands = new List<ScoringHands>();
            ScoringHands[] topHalf = {
                                                 new TopHalfScoringHands(1, "Ones"),
                                                 new TopHalfScoringHands(2, "Twos"),
                                                 new TopHalfScoringHands(3, "Threes"),
                                                 new TopHalfScoringHands(4, "Fours"),
                                                 new TopHalfScoringHands(5, "Fives"),
                                                 new TopHalfScoringHands(6, "Sixes"),
                                                 new UpperBonus()
                                             };
            ScoringHands[] botHalf = {
                                                 new ThreeOfAKind(),
                                                 new FourOfAKind(),
                                                 new FullHouse(),
                                                 new SmallStraight(),
                                                 new LargeStraight(),
                                                 new Yahtzee(),
                                                 new Chance()
                                             };
            UpperScoringHands.AddRange(topHalf);
            LowerScoringHands.AddRange(botHalf);
            

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
        /*
        public void CheckRolls(int rollNumber)
        {
            if (rollNumber == 3)
            {
                NewTurn();
                ActivePlayer.CU
            }
        }
        */
        // static methods
        static public Game NewDefaultGame()
        {
            List<Player> players = new List<Player>(2) { new Player("Oli"), new Player("Nick") };

            // start a new game with these players
            return new Game(players);
        }



    }
}
