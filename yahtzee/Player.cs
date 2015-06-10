using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public Dictionary<Scoring.ScoringHands, bool> Scores { get; set; }

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
            Scores = new Dictionary<Scoring.ScoringHands, bool>(g.AllScoringHands.Count);

            foreach (Scoring.ScoringHands h in g.AllScoringHands)
            {
                Scores.Add(h, false);
            }
        }
    }
}
