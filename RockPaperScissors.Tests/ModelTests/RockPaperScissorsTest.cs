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
      int output = Game.Play("paper", "rock");
      Assert.AreEqual(output, 0);
    }

    [TestMethod]
    public void Play_returnsWinner_1()
    {
      int output = Game.Play("paper", "scissors");
      Assert.AreEqual(output, 1);
    }
  }
}
// public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()
// {
//   any necessary logic to prep for test; instantiating new classes, etc.
//   Assert.AreEqual(EXPECTED RESULT, CODE TO TEST);
// }