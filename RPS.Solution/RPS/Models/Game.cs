using System;
using System.Collections.Generic;

namespace RPS.Models
{
  public class Game{
    public static string CheckWin(string input1, string input2)
    {
      if (input1 == input2)
      {
        return "draw";
      }
      else if((input1 == "paper" && input2 == "rock")
      || (input1 == "rock" && input2 == "scissors")
      || (input1 == "scissors" && input2 == "paper"))
      {
        return "Player1 wins!";
      }
      else{
        return "Player2 wins!";
      }
    }
  }
}