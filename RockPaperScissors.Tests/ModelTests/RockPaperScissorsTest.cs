using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockPaperScissors;

namespace RockPaperScissors.Tests
{
  [TestClass]
  public class GameTests
  {
    [TestMethod]
    public void Play_returnsWinner_0()
    {
      string output = Game.Play("paper", "rock");
      Assert.AreEqual(output, "Player 0 Wins!");
    }

    [TestMethod]
    public void Play_returnsWinner_1()
    {
      string output = Game.Play("paper", "scissors");
      Assert.AreEqual(output, "Player 1 Wins!");
    }
    [TestMethod]
    public void Play_returnsWinner_Draw()
    {
      string output = Game.Play("paper", "paper");
      Assert.AreEqual(output, "Draw!");
    }
  }
}
// public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()
// {
//   any necessary logic to prep for test; instantiating new classes, etc.
//   Assert.AreEqual(EXPECTED RESULT, CODE TO TEST);
// }