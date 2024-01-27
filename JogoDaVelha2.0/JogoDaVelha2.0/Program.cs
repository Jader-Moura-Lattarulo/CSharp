using System;

class Program
{
    static char[] board = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
    static int currentPlayer = 1; // 1 for player 1, 2 for player 2, 0 for computer

    static void Main()
    {
        Console.WriteLine("Bem-vindo ao Jogo da Velha 2.0!");

        Console.WriteLine("Escolha o modo de jogo:");
        Console.WriteLine("1 - Dois Jogadores");
        Console.WriteLine("2 - Jogar contra o Computador");
        int gameMode = int.Parse(Console.ReadLine());

        do
        {
            Console.Clear();
            Console.WriteLine("Jogo da Velha - Player {0}", currentPlayer);
            Console.WriteLine("Player 1 (X) - Player 2 (O)\n");

            DrawBoard();

            int choice;
            bool validInput;

            if (currentPlayer == 0 && gameMode == 2)
            {
                choice = GetComputerMove();
                validInput = true;
            }
            else
            {
                do
                {
                    Console.WriteLine("Player {0}, escolha uma posição: ", currentPlayer);
                    validInput = int.TryParse(Console.ReadLine(), out choice);

                    if (!validInput || choice < 1 || choice > 9 || board[choice - 1] == 'X' || board[choice - 1] == 'O')
                    {
                        Console.WriteLine("Escolha inválida. Tente novamente.");
                        validInput = false;
                    }
                } while (!validInput);
            }

            char playerSymbol = (currentPlayer == 1) ? 'X' : 'O';
            board[choice - 1] = playerSymbol;

            if (CheckForWin())
            {
                Console.Clear();
                DrawBoard();
                Console.WriteLine("Parabéns! Player {0} venceu!", currentPlayer);
                break;
            }

            if (CheckForTie())
            {
                Console.Clear();
                DrawBoard();
                Console.WriteLine("O jogo empatou!");
                break;
            }

            currentPlayer = (currentPlayer == 1) ? 2 : (currentPlayer == 2) ? 1 : 0;

        } while (true);

        Console.ReadLine();
    }

    static void DrawBoard()
    {
        Console.WriteLine("     |     |      ");
        Console.WriteLine("  {0}  |  {1}  |  {2}", board[0], board[1], board[2]);
        Console.WriteLine("_____|_____|_____ ");
        Console.WriteLine("     |     |      ");
        Console.WriteLine("  {0}  |  {1}  |  {2}", board[3], board[4], board[5]);
        Console.WriteLine("_____|_____|_____ ");
        Console.WriteLine("     |     |      ");
        Console.WriteLine("  {0}  |  {1}  |  {2}", board[6], board[7], board[8]);
        Console.WriteLine("     |     |      ");
    }

    static bool CheckForWin()
    {
        return (CheckRows() || CheckColumns() || CheckDiagonals());
    }

    static bool CheckRows()
    {
        for (int i = 0; i < 3; i++)
        {
            if (board[i * 3] == board[i * 3 + 1] && board[i * 3 + 1] == board[i * 3 + 2])
            {
                return true;
            }
        }
        return false;
    }

    static bool CheckColumns()
    {
        for (int i = 0; i < 3; i++)
        {
            if (board[i] == board[i + 3] && board[i + 3] == board[i + 6])
            {
                return true;
            }
        }
        return false;
    }

    static bool CheckDiagonals()
    {
        if ((board[0] == board[4] && board[4] == board[8]) || (board[2] == board[4] && board[4] == board[6]))
        {
            return true;
        }
        return false;
    }

    static bool CheckForTie()
    {
        for (int i = 0; i < 9; i++)
        {
            if (board[i] != 'X' && board[i] != 'O')
            {
                return false;
            }
        }
        return true;
    }

    static int GetComputerMove()
    {
        Random random = new Random();
        int randomMove;

        do
        {
            randomMove = random.Next(1, 10);
        } while (board[randomMove - 1] == 'X' || board[randomMove - 1] == 'O');

        return randomMove;
    }
}

