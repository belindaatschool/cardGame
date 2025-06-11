using System;

public class Player
{
    private char[] cardTypes = { '2', '3', '4', '5', '6', '7', '8', '9', 'T', 'J', 'Q', 'K', 'A' };
    private char[] deck;
    private int currentIndex = 0;
    private int points = 0;

    public Player(Random random)
    {
        deck = new char[26];

        for (int i = 0; i < deck.Length; i++)
        {
            deck[i] = cardTypes[random.Next(cardTypes.Length)];
        }

        this.points = 0;
        this.currentIndex = deck.Length - 1;
    }

    public char GetTopCard()
    {
        return deck[currentIndex--];
    }
}
