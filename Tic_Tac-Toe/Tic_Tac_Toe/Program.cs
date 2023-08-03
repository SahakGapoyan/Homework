using System.Diagnostics.SymbolStore;
using System.Security.Cryptography.X509Certificates;

namespace Tic_Tac_Toe
{
    internal class Program
    {
        static char[] board = { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        static char CurrentPlayer = 'X';
        static bool IsFinished = false;

        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Welcome to Tic-Tac-Toe game");
                DisplayBoard();
                int move;

                do
                {
                    Console.Write($"Player {CurrentPlayer}, enter your move (move 1-9): ");

                } while (!int.TryParse(Console.ReadLine(), out move) || move < 1 || move > 9 || board[move - 1] != ' ');

                board[move - 1] = CurrentPlayer;
                Console.Clear();
                DisplayBoard();

                if (CheckForWin())
                {
                    Console.WriteLine($"Player {CurrentPlayer} wins!");
                    IsFinished = true;
                }
                else if (CheckForTie())
                {
                    Console.WriteLine("It's a tie!");
                    IsFinished = true;
                }
                CurrentPlayer = (CurrentPlayer == 'X') ? 'O' : 'X';
            } while (!IsFinished);

            Console.WriteLine("Would yo like to play again (yes/no)");
            string playAgain = Console.ReadLine();
            if (playAgain.ToLower() == "yes")
            {
                ResetGame();
                Main(args);
            }
            else
            {
                Console.WriteLine("Thanks for playing!");
            }

            static void DisplayBoard()
            {
                //Console.Clear();
                Console.WriteLine($"  {board[0]} | {board[1]} | {board[2]} ");
                Console.WriteLine(" ---|---|--- ");
                Console.WriteLine($"  {board[3]} | {board[4]} | {board[5]} ");
                Console.WriteLine(" ---|---|--- ");
                Console.WriteLine($"  {board[6]} | {board[7]} | {board[8]} ");
            }

            static bool CheckForWin()
            {
                // Check rows, columns, and diagonals for a win
                return (board[0] == board[1] && board[1] == board[2] && board[0] != ' ') ||
                       (board[3] == board[4] && board[4] == board[5] && board[3] != ' ') ||
                       (board[6] == board[7] && board[7] == board[8] && board[6] != ' ') ||
                       (board[0] == board[3] && board[3] == board[6] && board[0] != ' ') ||
                       (board[1] == board[4] && board[4] == board[7] && board[1] != ' ') ||
                       (board[2] == board[5] && board[5] == board[8] && board[2] != ' ') ||
                       (board[0] == board[4] && board[4] == board[8] && board[0] != ' ') ||
                       (board[2] == board[4] && board[4] == board[6] && board[2] != ' ');
            }

            static bool CheckForTie()
            {
                // Check if the board is full
                foreach (char cell in board)
                {
                    if (cell == ' ')
                    {
                        return false;
                    }
                }
                return true;
            }

            static void ResetGame()
            {
                board = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
                CurrentPlayer = 'X';
                IsFinished = false;
            }
        }
    }
}