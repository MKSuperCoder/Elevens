using System;

public class ElevensGame
{
    private Deck deck;
    private Board board;
    public bool IsGameActive { get; private set; }
    private int winCount;

    public ElevensGame()
    {
        winCount = 0;
    }

    public void StartGame()
    {
        deck = new Deck();
        deck.Shuffle();
        board = new Board(deck);
        IsGameActive = true;
    }

    public void PlayTurn(int index1, int index2)
    {
        if (!IsGameActive) return;

        board.SelectCard(index1);
        board.SelectCard(index2);

        if (board.IsSelectedPairValid())
        {
            board.ReplaceCards();
            UpdateGameStatus();
        }
        else
        {
            Console.WriteLine("Invalid move: selected cards do not add up to 11.");
            board.SelectedCardIndices.Clear();
        }
    }

    public void QuitGame()
    {
        Console.WriteLine("You quit the game. Game over.");
        IsGameActive = false;
    }

    public void UpdateGameStatus()
    {
        if (!board.CheckRemainingPairs())
        {
            EndGame();
        }
    }

    public void EndGame()
    {
        if (deck.CardsLeft == 0 && !board.CheckRemainingPairs())
        {
            Console.WriteLine("You win!");
            winCount++;
        }
        else
        {
            Console.WriteLine("No more valid moves. You lost.");
        }

        IsGameActive = false;
    }

    public int GetWinCount() => winCount;
}