using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class TicTacToeBoard
    {
        private bool _isP1Turn = true;
        private bool _isValidInput = false;
        private bool _gameOver = false;
        private bool _isTie = false;

        //static int[,] board = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        static string[,] board = { { "1", "2", "3" }, { "4", "5", "6" }, { "7", "8", "9" } };
        public TicTacToeBoard()
        {

            StartGame();

        }

        public void StartGame()
        {
            ResetBoard();
            while (!_gameOver && !_isTie)
            {
                RenderBoard(board);

                while (!_isValidInput)
                {
                    int input = RenderMessage();
                    ValidateInput(input);
                }
                _isValidInput = false;
                _gameOver = WinChecker(board);
                _isTie |= TieChecker(board);

                if (_isTie)
                {
                    Console.WriteLine("Game Is A Tie! Starting over.");
                }



            }

            if (_gameOver)
            {
                if (!_isP1Turn)
                {
                    Console.WriteLine("Game Over! Player X WINS!");
                }
                else
                {
                    Console.WriteLine("Game Over! Player O WINS!");
                }
            }


        }
        public void ResetBoard()
        {
            board[0, 0] = "1";
            board[0, 1] = "2";
            board[0, 2] = "3";
            board[1, 0] = "4";
            board[1, 1] = "5";
            board[1, 2] = "6";
            board[2, 0] = "7";
            board[2, 1] = "8";
            board[2, 2] = "9";
        }
        public void RenderBoard(string[,] board)
        {
            Console.WriteLine("|   |   |   |");
            Console.WriteLine("| {0} | {1} | {2} |", board[0, 0], board[0, 1], board[0, 2]);
            Console.WriteLine("|   |   |   |");
            Console.WriteLine("| {0} | {1} | {2} |", board[1, 0], board[1, 1], board[1, 2]);
            Console.WriteLine("|   |   |   |");
            Console.WriteLine("| {0} | {1} | {2} |", board[2, 0], board[2, 1], board[2, 2]);
            Console.WriteLine("|   |   |   |");
        }

        public int RenderMessage()
        {

            int input;

            if (_isP1Turn)
            {
                Console.WriteLine("Player X: choose your field");
                input = GetInput();


            }
            else
            {
                Console.WriteLine("Player O: choose your field");
                input = GetInput();

            }
            return input;


        }

        public int GetInput()
        {
            bool successfield = int.TryParse(Console.ReadLine(), out int field);
            if (successfield)
            {
                return field;
            }
            else
            {
                return 0;
            }

        }

        public void ValidateInput(int input)
        {
            switch (input)
            {
                case 1:
                    if (board[0, 0] != "X" && board[0, 0] != "O")
                    {
                        if (_isP1Turn)
                        {
                            board[0, 0] = "X";
                            _isP1Turn = false;
                        }
                        else
                        {
                            board[0, 0] = "O";
                            _isP1Turn = true;
                        }
                        _isValidInput = true;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Spot #1 has already been taken");
                        break;
                    }
                case 2:
                    if (board[0, 1] != "X" && board[0, 1] != "O")
                    {
                        if (_isP1Turn)
                        {
                            board[0, 1] = "X";
                            _isP1Turn = false;
                        }
                        else
                        {
                            board[0, 1] = "O";
                            _isP1Turn = true;
                        }
                        _isValidInput = true;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Spot #2 has already been taken");
                        break;
                    }
                case 3:
                    if (board[0, 2] != "X" && board[0, 2] != "O")
                    {
                        if (_isP1Turn)
                        {
                            board[0, 2] = "X";
                            _isP1Turn = false;
                        }
                        else
                        {
                            board[0, 2] = "O";
                            _isP1Turn = true;
                        }
                        _isValidInput = true;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Spot #3 has already been taken");
                        break;
                    }
                case 4:
                    if (board[1, 0] != "X" && board[1, 0] != "O")
                    {
                        if (_isP1Turn)
                        {
                            board[1, 0] = "X";
                            _isP1Turn = false;
                        }
                        else
                        {
                            board[1, 0] = "O";
                            _isP1Turn = true;
                        }
                        _isValidInput = true;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Spot #4 has already been taken");
                        break;
                    }
                case 5:
                    if (board[1, 1] != "X" && board[1, 1] != "O")
                    {
                        if (_isP1Turn)
                        {
                            board[1, 1] = "X";
                            _isP1Turn = false;
                        }
                        else
                        {
                            board[1, 1] = "O";
                            _isP1Turn = true;
                        }
                        _isValidInput = true;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Spot #5 has already been taken");
                        break;
                    }
                case 6:
                    if (board[1, 2] != "X" && board[1, 2] != "O")
                    {
                        if (_isP1Turn)
                        {
                            board[1, 2] = "X";
                            _isP1Turn = false;
                        }
                        else
                        {
                            board[1, 2] = "O";
                            _isP1Turn = true;
                        }
                        _isValidInput = true;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Spot #6 has already been taken");
                        break;
                    }
                case 7:
                    if (board[2, 0] != "X" && board[2, 0] != "O")
                    {
                        if (_isP1Turn)
                        {
                            board[2, 0] = "X";
                            _isP1Turn = false;
                        }
                        else
                        {
                            board[2, 0] = "O";
                            _isP1Turn = true;
                        }
                        _isValidInput = true;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Spot #7 has already been taken");
                        break;
                    }
                case 8:
                    if (board[2, 1] != "X" && board[2, 1] != "O")
                    {
                        if (_isP1Turn)
                        {
                            board[2, 1] = "X";
                            _isP1Turn = false;
                        }
                        else
                        {
                            board[2, 1] = "O";
                            _isP1Turn = true;
                        }
                        _isValidInput = true;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Spot #8 has already been taken");
                        break;
                    }
                case 9:
                    if (board[2, 2] != "X" && board[2, 2] != "O")
                    {
                        if (_isP1Turn)
                        {
                            board[2, 2] = "X";
                            _isP1Turn = false;
                        }
                        else
                        {
                            board[2, 2] = "O";
                            _isP1Turn = true;
                        }
                        _isValidInput = true;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Spot #9 has already been taken");
                        break;
                    }

                default:
                    Console.WriteLine("Not a valid selection");
                    break;

            }
        }

        public bool WinChecker(string[,] board)
        {
            //horizontal and vertical check
            for (int i = 0; i < board.GetLength(0); i++)
            {

                if ((board[i, 0] == board[i, 1] && board[i, 0] == board[i, 2]) || (board[0, i] == board[1, i] && board[1, i] == board[2, i]))
                {
                    return true;
                }

            }
            if ((board[0, 0] == board[1, 1] && board[0, 0] == board[2, 2]) || (board[0, 2] == board[1, 1] && board[0, 2] == board[2, 0]))
            {
                return true;
            }



            return false;

        }

        public bool TieChecker(string[,] board)
        {

            if ((board[0, 0] != "1") && (board[0, 1] != "2") && (board[0, 2] != "3") && (board[1, 0] != "4") && (board[1, 1] != "5") && (board[1, 2] != "6") && (board[2, 0] != "7") && (board[2, 1] != "8") && (board[2, 2] != "9"))
            {
                return true;
            }
            else
            {
                return false;
            }


        }




    }
}
