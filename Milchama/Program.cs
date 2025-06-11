using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the game מלחמה!");
        Console.WriteLine("Press Enter to play a round, or type 'q' to quit.\n");

        // game loop

        Console.WriteLine("\nGame over!");

        // who won
    }
    
        public static int CardValue(char card)
    {
        if (card >= '2' && card <= '9')
            return card - '2' + 2; // 2-9
        if (card == 'T')
            return 8; // 10
        if (card == 'J')
            return 9; // Jack
        if (card == 'Q')
            return 10; // Queen 
        if (card == 'K')
            return 11; // King
        if (card == 'A')
            return 12; // Ace
        return -1; // Invalid card
    }
}
