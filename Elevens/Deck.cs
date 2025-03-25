using System;
using System.Collections.Generic;

public class Deck
{
    private List<Card> cards = new List<Card>();
    private static string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };
    private static string[] ranks = { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };

    public Deck()
    {
        foreach (string suit in suits)
        {
            for (int i = 1; i <= 13; i++)
            {
                string rank = ranks[i - 1];
                cards.Add(new Card($"{rank} of {suit}", i > 10 ? 10 : i)); // J/Q/K = 10
            }
        }
    }

    public void Shuffle()
    {
        Random rng = new Random();
        int n = cards.Count;
        while (n > 1)
        {
            int k = rng.Next(n--);
            (cards[n], cards[k]) = (cards[k], cards[n]);
        }
    }

    public Card DealCard()
    {
        if (cards.Count == 0) return null;
        Card dealt = cards[0];
        cards.RemoveAt(0);
        return dealt;
    }

    public int CardsLeft => cards.Count;
}