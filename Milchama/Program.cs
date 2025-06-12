using System;

class Program
{
     public static void Main(String[] args)
    {
        Random random = new Random();

        Console.WriteLine("Welcome to the game מלחמה!");
        Console.WriteLine("Press Enter to play a round, or type 'q' to quit.\n");
        
        // Create 2 players
        Player player1 = new Player(random, "Naama");
        Player player2 = new Player(random, "Noa");

        Console.WriteLine("Press q to quit");
        // game loop
        while ( player1.GetCurrentIndex() > 0 &&
                player2.GetCurrentIndex() > 0)
        {
            ////if q then end game
            Console.WriteLine("Press Enter to play next round:");
            String input = Console.ReadLine();
            if (input == "q")
                break;

            //// each player takes a card
            char card1 = player1.GetTopCard();
            char card2 = player2.GetTopCard();

            Console.WriteLine(  player1.GetName() + " card-" + card1 + "\t" +
                                player2.GetName() + " card-" + card2);

            //// who wins turn? wins points
            if (CardValue(card1) < CardValue(card2))
            {
                player2.AddPoints(1);
                Console.WriteLine(player2.GetName() + " won this turn.");
            }
            else if (CardValue(card2) < CardValue(card1))
            {
                player1.AddPoints(1);
                Console.WriteLine(player1.GetName() + " won this turn.");
            }
            else
                Console.WriteLine("It's a tie!!");
            

        }// end game loop

        Console.WriteLine("\nGame over!");

        // who won the game?
        Console.WriteLine("And the winner is....");
        if(player1.GetPoint() > player2.GetPoint())
            Console.WriteLine(player1.GetName() +  " WINS ! ! !");        
        else
            Console.WriteLine(player2.GetName() + " WINS ! ! !");
    }


    public static int CardValue(char card)
    {
        if (card >= '2' && card <= '9')
            return card - '2' + 2; // 2-9
        if (card == 'T')
            return 10; // 10
        if (card == 'J')
            return 11; // Jack
        if (card == 'Q')
            return 12; // Queen 
        if (card == 'K')
            return 13; // King
        if (card == 'A')
            return 14; // Ace
        return -1; // Invalid card
    }
}
