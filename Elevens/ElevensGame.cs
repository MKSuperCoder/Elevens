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

    public bool PlayTurn(int index1, int index2)
    {
        if (!IsGameActive)
        {
            Console.WriteLine("No game is active.");
            return false;
        }

        // Check for win/lose before doing anything
        if (deck.CardsLeft == 0 && !board.CheckRemainingPairs())
        {
            EndGame(true);
            return false;
        }
        else if (!board.CheckRemainingPairs())
        {
            EndGame(false);
            return false;
        }

        board.SelectCard(index1);
        board.SelectCard(index2);

        if (board.IsSelectedPairValid())
        {
            board.ReplaceCards();

            // Check again after replacing
            if (deck.CardsLeft == 0 && !board.CheckRemainingPairs())
            {
                EndGame(true);
            }
            else if (!board.CheckRemainingPairs())
            {
                EndGame(false);
            }

            return true;
        }
        else
        {
            Console.WriteLine("Invalid move: selected cards do not add up to 11.");
            board.SelectedCardIndices.Clear();
            return false;
        }   
    }


    public void QuitGame()
    {
        Console.WriteLine("You quit the game. Game over.");
        IsGameActive = false;
    }

    private void EndGame(bool won)
    {
        if (won)
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

    public void DisplayBoard()
    {
        board.DisplayBoard();
    }
}
