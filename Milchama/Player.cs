using System;

public class Player
{
    private string name;
    private char[] cardTypes = { '2', '3', '4', '5', '6', '7', '8', '9', 'T', 'J', 'Q', 'K', 'A' };
    private char[] deck;
    private int currentIndex = 0;
    private int points = 0;

    public Player(Random random, string name)
    {
        deck = new char[10];

        for (int i = 0; i < deck.Length; i++)
        {
            deck[i] = cardTypes[random.Next(cardTypes.Length)];
        }

        this.points = 0;
        this.currentIndex = deck.Length - 1;
        this.name = name;
    }

    public int GetCurrentIndex() { 
        return currentIndex; 
    }


    public char GetTopCard()
    {
        if (currentIndex < 0)
            return ' ';
        return deck[currentIndex--];
    }

    public void AddPoints(int points)
    {
        this.points += points;
    }

    public int GetPoint()
    {
        return points;
    }

    public string GetName()
    {
        return name;
    }
}
