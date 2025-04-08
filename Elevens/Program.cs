using System;

class Test
{
    static void Main(string[] args)
    {
        ElevensGame game = new ElevensGame();
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("\n=== Elevens Game Menu ===");
            Console.WriteLine("1. Start New Game");
            Console.WriteLine("2. Play Turn");
            Console.WriteLine("3. Show Win Count");
            Console.WriteLine("4. Quit Game");
            Console.WriteLine("5. Exit Program");
            Console.Write("Choose an option (1-5): ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    game.StartGame();
                    Console.WriteLine("Game started!");
                    break;

                case "2":
                    if (!game.IsGameActive)
                    {
                        Console.WriteLine("No active game. Please start a new game first.");
                        break;
                    }

                    int attempts = 3;
                    bool validMove = false;

                    while (attempts > 0 && !validMove)
                    {
                        game.DisplayBoard();

                        Console.Write("Enter index of first card (0-8): ");
                        if (!int.TryParse(Console.ReadLine(), out int index1))
                        {
                            Console.WriteLine("Invalid input. Try again.");
                            continue;
                        }

                        Console.Write("Enter index of second card (0-8): ");
                        if (!int.TryParse(Console.ReadLine(), out int index2))
                        {
                            Console.WriteLine("Invalid input. Try again.");
                            continue;
                        }

                        if (index1 == index2)
                        {
                            Console.WriteLine("Please select two different cards.");
                            continue;
                        }

                        if (!game.PlayTurn(index1, index2))
                        {
                            attempts--;
                            Console.WriteLine($"Invalid move. Tries remaining: {attempts}");
                        }
                        else
                        {
                            validMove = true;
                        }
                    }

                    if (!validMove)
                    {
                        Console.WriteLine("You used all your tries. Returning to menu.");
                    }

                    break;

                case "3":
                    Console.WriteLine($"Win Count: {game.GetWinCount()}");
                    break;

                case "4":
                    game.QuitGame();
                    break;

                case "5":
                    exit = true;
                    Console.WriteLine("Exiting the program...");
                    break;

                default:
                    Console.WriteLine("Invalid option. Please choose again.");
                    break;
            }
        }
    }
}
