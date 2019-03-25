using System;
using System.Collections.Generic;

namespace hwapp
{
  class Program
  {
    static void Main(string[] args)
    {
      int playing = 0;
      int playerWins = 0;
      int compWins = 0;
      Console.WriteLine("Tournament style, best of 5!!");
      Console.WriteLine("Make your choice: rock, paper, scissors");

      while (playing < 5)
      {

        Random random = new Random();
        int cChoice = random.Next(0, 3);
        string[] choices = { "rock", "paper", "scissors" };
        var compChoice = choices[cChoice];

        string userChoice = Console.ReadLine().ToLower();

        Console.WriteLine($"Your choice is { userChoice } & the computer chose {compChoice}");

        if (compChoice == userChoice)
        {
          Console.WriteLine("Tie Game!");
          playing--;
        }
        else if (userChoice == "rock" && compChoice == "scissors")
        {
          Console.WriteLine($"Player wins!");
          playerWins++;
        }
        else if (userChoice == "rock" && compChoice == "paper")
        {
          Console.WriteLine($"Computer wins!");
          compWins++;
        }
        else if (userChoice == "paper" && compChoice == "rock")
        {
          Console.WriteLine($"Player wins!");
          playerWins++;
        }
        else if (userChoice == "paper" && compChoice == "scissors")
        {
          Console.WriteLine($"Computer wins!");
          compWins++;
        }
        else if (userChoice == "scissors" && compChoice == "paper")
        {
          Console.WriteLine($"Player wins!");
          playerWins++;
        }
        else if (userChoice == "scissors" && compChoice == "rock")
        {
          Console.WriteLine($"Computer wins!");
          compWins++;
        };
        playing++;
        Console.WriteLine($"You are on game of {playing} of 5");

        if (playerWins == 3)
        {
          Console.WriteLine("WOO HOO! Player wins!");
        }
        else if (compWins == 3)
        {
          Console.WriteLine("Game over, computer wins!");
        }
        else if (playerWins == 3 || compWins == 3)
        {
          playing = 5;
        }
        else if (playerWins > 4 && compWins < 3)
        {
          Console.WriteLine("WOO HOOO! Player wins!");
          playing = 5;
        }
        else if (compWins > 4 && playerWins < 3)
        {
          playing = 5;
          Console.WriteLine("Game over, computer wins!");
          Console.Beep();
        };
      };
    }
  }
}
