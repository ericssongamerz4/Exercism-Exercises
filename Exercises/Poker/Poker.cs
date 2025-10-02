using System;

namespace Exercism_Exercises.Exercises.Poker
{
    public static class Poker
    {
        private static readonly Dictionary<int, string> _ranks = new()
        {
            {1,"A" }, {2,"2" }, {3,"3" }, {4,"4" }, {5,"5" }, {6,"6" }, {7,"7" }, {8,"8" }, {9,"9" }, {10,"10" },
            {11,"J" }, {12,"Q" }, {13,"K" }, {14,"A" },
        };

        private static (string[] cardRanks, string[] cardSuits) GetCardsFromHand(string hand)
        {
            string[] cards = hand.Split(' ');

            if (cards.Length != 5)
                throw new ArgumentException("Not enough cards in the hand.");

            List<string> cardRanks = [];
            List<string> cardSuits = [];

            foreach (var c in cards.OrderByDescending(x => x))
            {
                cardRanks.Add(c.Substring(0, 1));
                cardSuits.Add(c.Substring(1, 1));
            }

            return (cardRanks.ToArray(), cardSuits.ToArray());
        }











        public static IEnumerable<string> BestHands(IEnumerable<string> hands)
        {

            throw new NotImplementedException("You need to implement this method.");
        }
    }

}//Made by ericssonGamerz4

