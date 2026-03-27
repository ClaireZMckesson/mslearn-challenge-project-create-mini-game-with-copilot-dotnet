// you'll enter code and comments here
//write 'hello world' to the console
using System;

Console.WriteLine("Hello, World!");

//create a simple rock paper scissors game
//The computer will be your opponent and can randomly choose one of the elements (rock, paper, or scissors).
// Your game interaction will be through the console (Terminal). The player can choose one of the three options: rock, paper, or scissors, and should be warned if they enter an invalid option.
//At each round, the player must enter one of the options in the list and be informed if they won, lost, or tied with the opponent.
//By the end of each round, the player can choose whether to play again.
//Display the player's score at the end of the game.
//The minigame must handle user inputs, putting them in lowercase and informing the user if the option is invalid.
//In your GitHub Codespaces, follow the given instructions to set up prompts that GitHub Copilot can understand and use to help you build the minigame. Keep in mind that GitHub Copilot relies on comments to grasp the context and give you helpful suggestions while you're working on your project.
//create a list of options for the game
string[] options = { "rock", "paper", "scissors" };
//create a random number generator
Random random = new Random();
//create a variable to keep track of the player's score
int playerScore = 0;
//create a variable to keep track of the computer's score
int computerScore = 0;
//create a variable to keep track of the number of rounds played
int roundsPlayed = 0;
//create a variable to keep track of whether the player wants to play again
bool playAgain = true;
//start the game loop
while (playAgain)
{    //prompt the player to enter their choice
    Console.WriteLine("Enter your choice (rock, paper, or scissors):");
    string playerChoice = Console.ReadLine().ToLower();
    //check if the player's choice is valid
    if (Array.Exists(options, option => option == playerChoice))
    {        //generate a random choice for the computer
        string computerChoice = options[random.Next(options.Length)];
        Console.WriteLine($"Computer chose: {computerChoice}");
        //determine the winner of the round
        if (playerChoice == computerChoice)
        {            Console.WriteLine("It's a tie!");
        }
        else if ((playerChoice == "rock" && computerChoice == "scissors") ||
                 (playerChoice == "paper" && computerChoice == "rock") ||
                 (playerChoice == "scissors" && computerChoice == "paper"))
        {
            Console.WriteLine("You win!");
            playerScore++;
        }
        else
        {
            Console.WriteLine("You lose!");
            computerScore++;
        }
        roundsPlayed++;
        //ask the player if they want to play again
        Console.WriteLine("Do you want to play again? (yes or no)");
        string playAgainInput = Console.ReadLine().ToLower();
        playAgain = (playAgainInput == "yes");
    }
    else
    {
        Console.WriteLine("Invalid choice. Please enter rock, paper, or scissors.");
    }
}
Console.WriteLine($"Game over! You won {playerScore} out of {roundsPlayed} rounds.");
