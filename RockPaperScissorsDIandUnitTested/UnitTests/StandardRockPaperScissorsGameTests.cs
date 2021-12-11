using NUnit.Framework;
using RockPaperScissorsDIandUnitTested.Enums;
using RockPaperScissorsDIandUnitTested.RockPaperScissorsGameVariants;

namespace RockPaperScissorsDIandUnitTested.UnitTests
{
    [TestFixture]
    public class StandardRockPaperScissorsGameTests
    {
        [TestCase(StandardGameOption.Rock, StandardGameOption.Rock, "draw")]
        [TestCase(StandardGameOption.Rock, StandardGameOption.Paper, "lose")]
        [TestCase(StandardGameOption.Rock, StandardGameOption.Scissors, "win")]
        [TestCase(StandardGameOption.Paper, StandardGameOption.Paper, "draw")]
        [TestCase(StandardGameOption.Paper, StandardGameOption.Scissors, "lose")]
        [TestCase(StandardGameOption.Paper, StandardGameOption.Rock, "win")]
        [TestCase(StandardGameOption.Scissors, StandardGameOption.Scissors, "draw")]
        [TestCase(StandardGameOption.Scissors, StandardGameOption.Rock, "lose")]
        [TestCase(StandardGameOption.Scissors, StandardGameOption.Paper, "win")]
        public void GetGameResultText_WithTestCases_ShouldContainExpectedText(StandardGameOption userGameOption, StandardGameOption computerGameOption, string expectedTextInResult)
        {
            // Arrange
            StandardRockPaperScissorsGame standardRockPaperScissorsGame = new StandardRockPaperScissorsGame();

            // Act
            string result = standardRockPaperScissorsGame.GetGameResultText(userGameOption, computerGameOption);

            // Assert
            StringAssert.Contains(expectedTextInResult, result);
        }
    }
}
