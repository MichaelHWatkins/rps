using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using RPS.Models;
using System;

namespace RPS.Tests
{
  [TestClass]
  public class GameTests 
  {

    // public void Dispose()
    // {
    //   Item.ClearAll();
    // }

    
    [TestMethod]
    public void CheckWin_ReturnsWhoWon_String()
    {
      Assert.AreEqual("draw", Game.CheckWin("paper", "paper"));
    }
    [TestMethod]
    public void CheckWin_ReturnsPlayer1Win_String()
    {
      Assert.AreEqual("Player1 wins!", Game.CheckWin("paper", "rock"));
      Assert.AreEqual("Player1 wins!", Game.CheckWin("rock", "scissors"));
      Assert.AreEqual("Player1 wins!", Game.CheckWin("scissors", "paper"));
    }
    [TestMethod]
    public void CheckWin_ReturnsPlayer2Win_String()
    {
      Assert.AreEqual("Player2 wins!", Game.CheckWin("scissors", "rock"));
      Assert.AreEqual("Player2 wins!", Game.CheckWin("paper", "scissors"));
      Assert.AreEqual("Player2 wins!", Game.CheckWin("rock", "paper"));
    }
  }
}