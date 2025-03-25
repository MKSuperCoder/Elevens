using System;

class Test
{
    static void Main(string[] args)
    {
        ElevensGame game = new ElevensGame();
        game.StartGame();

        // Simulate selecting two cards (you'll want to use a loop or UI later)
        game.PlayTurn(0, 1);
    }
}