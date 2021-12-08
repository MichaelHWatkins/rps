using System;
using RPS.Models;
using System.Collections.Generic;

public class Program
{
  public static void Main()
  {
    Game newGame = new Game();
    Console.WriteLine("Welcome to Rock Paper Scissors!");
    string player1Choice = "";
    string player2Choice = "";
    while(true){
      Console.WriteLine("Player 1 what do you choose?");
      player1Choice = Console.ReadLine().ToLower();
      if(player1Choice != "rock" && player1Choice != "paper" && player1Choice != "scissors"){
        Console.WriteLine("Please choose rock paper or scissors");
      }
      else{
        break;
      }
    }
    while(true){
      Console.WriteLine("Player 2 what do you choose?");
      player2Choice = Console.ReadLine().ToLower();  
      if(player2Choice != "rock" && player2Choice != "paper" && player2Choice != "scissors"){
        Console.WriteLine("Please choose rock paper or scissors");
      }
      else{
        break;
      }
    }
    
    Console.WriteLine(Game.CheckWin(player1Choice, player2Choice));
  }
}