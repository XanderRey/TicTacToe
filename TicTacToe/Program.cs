using TicTacToe;

bool playAgain = false;
string userInput;

do
{
    playAgain = false;

    TicTacToeBoard game = new TicTacToeBoard();

    while (true)
    {
        Console.WriteLine("Would you like to play again? Please enter 'Y' for Yes or 'N' for No: ");
        userInput = Console.ReadLine().ToUpper();

        if (userInput == "Y")
        {
            playAgain = true;
            break;
        }
        else if (userInput == "N")
        {
            playAgain = false;
            break;
        }
        else
        {
            Console.WriteLine(">>>> Invalid Input! <<<<");
        }
    }


} while (playAgain);

Console.WriteLine("Thanks for playing! Press any key to close the program!");

