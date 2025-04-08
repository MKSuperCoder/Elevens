using System;
using System.Collections.Generic;
using System.Linq;

public class Board
{
    public int NumOfCards => 9;
    public int CardsRemaining => deck.CardsLeft;

    private Deck deck;
    public Card[] Cards { get; private set; }
    public List<int> SelectedCardIndices { get; private set; }

    public Board(Deck d)
    {
        deck = d;
        Cards = new Card[NumOfCards];
        SelectedCardIndices = new List<int>();
        for (int i = 0; i < NumOfCards; i++)
        {
            Cards[i] = deck.DealCard();
        }
    }

    public void ReplaceCards()
    {
        foreach (int index in SelectedCardIndices)
        {
            Cards[index] = deck.DealCard();
        }
        SelectedCardIndices.Clear();
    }

    public bool CheckRemainingPairs()
    {
        for (int i = 0; i < Cards.Length; i++)
        {
            for (int j = i + 1; j < Cards.Length; j++)
            {
                if (Cards[i] != null && Cards[j] != null)
                {
                    if (Cards[i].Num + Cards[j].Num == 11)
                        return true;
                }
            }
        }
        return false;
    }

    public void SelectCard(int index)
    {
        if (!SelectedCardIndices.Contains(index) && index >= 0 && index < Cards.Length)
            SelectedCardIndices.Add(index);
    }

    public bool IsSelectedPairValid()
    {
        if (SelectedCardIndices.Count == 2)
        {
            int sum = Cards[SelectedCardIndices[0]].Num + Cards[SelectedCardIndices[1]].Num;
            return sum == 11;
        }
        return false;
    }

    public void DisplayBoard()
    {
        Console.WriteLine("\nCurrent Board:");
        for (int i = 0; i < Cards.Length; i++)
        {
            var card = Cards[i];
            if (card != null)
                Console.WriteLine($"[{i}] {card.Name} ({card.Num})");
            else
                Console.WriteLine($"[{i}] Empty");
        }
    }
}
