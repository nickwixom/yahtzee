using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using yahtzee.Scoring;

namespace yahtzee
{
    public class Player
    {
        // fields


        // properties
        public string Name { get; set; }

        public int CurrentScore { get; set; }

        public Hand CurrentHand { get; set; }

        private bool isActive = false;
        public bool IsActive 
        {
            get { return isActive; }
            set
            {
                isActive = value;

                if (isActive)
                {
                    // if this player is active, make all the other players inactive

                    // => indicates LINQ ... look it up
                    if (MainWindow.Singleton.CurrentGame != null) MainWindow.Singleton.CurrentGame.Players.ForEach(p => { if (p != this && p.IsActive) { p.IsActive = false; } });

                //    MainWindow.Singleton.CurrentGame.Players.Any(p => p.IsActive);

                    // give the active player a new hand
                    CurrentHand.Reset();


                }
            }
        }

        public List<ScoringHands> LowerScores { get; set; }
        public List<ScoringHands> UpperScores { get; set; }

        // constructors
        public Player() : this("") { }

        public Player(string name)
        {
            Name = name;

            CurrentHand = new Hand();
        }


        // methods
        public Player Next()
        {
            // get the index of the current player
            int index = MainWindow.Singleton.CurrentGame.Players.IndexOf(MainWindow.Singleton.CurrentGame.ActivePlayer);

            // increment this by one to get the next player
            index++;

            // but if this is greater than the number of players, go back to zero
            if (index > MainWindow.Singleton.CurrentGame.NumPlayers - 1) index = 0;

            // return the next player
            return MainWindow.Singleton.CurrentGame.Players[index];
        }

        public void InitializeIntoGame(Game g)
        {
            // create list of all scoring hands in order
            UpperScores = new List<ScoringHands>();
            LowerScores = new List<ScoringHands>();
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

            UpperScores.AddRange(topHalf);
            LowerScores.AddRange(botHalf);

            UpperScores.ForEach(s => s.AssociatedPlayer = this);
            LowerScores.ForEach(s => s.AssociatedPlayer = this);
        }

        public void CheckScores()
        {
            CurrentHand.CheckScores(CurrentHand, UpperScores, LowerScores);
        }
    }
}
