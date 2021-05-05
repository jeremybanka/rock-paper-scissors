using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockPaperScissors;

namespace RockPaperScissors.Tests
{
  [TestClass]
  public class GameTests
  {
    [TestMethod]
    public void PlayLongForm_returnsWinner_0()
    {
      string output = Game.PlayLongform("paper", "rock");
      Assert.AreEqual(output, "Player 0 Wins!");
    }

    [TestMethod]
    public void PlayLongForm_returnsWinner_1()
    {
      string output = Game.PlayLongform("paper", "scissors");
      Assert.AreEqual(output, "Player 1 Wins!");
    }
    [TestMethod]
    public void PlayLongForm_returnsWinner_Draw()
    {
      string output = Game.PlayLongform("paper", "paper");
      Assert.AreEqual(output, "Draw!");
    }
    [TestMethod]
    public void WrapAround_Simplifies_Degree()
    {
      int output = Game.WrapAround(460, 0, 360);
      Assert.AreEqual(output, 100);
    }
  }
}
// public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()
// {
//   any necessary logic to prep for test; instantiating new classes, etc.
//   Assert.AreEqual(EXPECTED RESULT, CODE TO TEST);
// }