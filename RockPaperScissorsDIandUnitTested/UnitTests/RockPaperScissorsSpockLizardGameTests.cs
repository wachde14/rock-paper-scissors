using NUnit.Framework;
using RockPaperScissorsDIandUnitTested.Enums;
using RockPaperScissorsDIandUnitTested.RockPaperScissorsGameVariants;

namespace RockPaperScissorsDIandUnitTested.UnitTests
{
    [TestFixture]
    public class RockPaperScissorsSpockLizardGameTests
    {
        [TestCase(StandardAndSpockLizardGameOption.Rock, StandardAndSpockLizardGameOption.Rock, "draw")]
        [TestCase(StandardAndSpockLizardGameOption.Rock, StandardAndSpockLizardGameOption.Paper, "lose")]
        [TestCase(StandardAndSpockLizardGameOption.Rock, StandardAndSpockLizardGameOption.Spock, "lose")]
        [TestCase(StandardAndSpockLizardGameOption.Rock, StandardAndSpockLizardGameOption.Scissors, "win")]
        [TestCase(StandardAndSpockLizardGameOption.Rock, StandardAndSpockLizardGameOption.Lizard, "win")]
        [TestCase(StandardAndSpockLizardGameOption.Paper, StandardAndSpockLizardGameOption.Paper, "draw")]
        [TestCase(StandardAndSpockLizardGameOption.Paper, StandardAndSpockLizardGameOption.Scissors, "lose")]
        [TestCase(StandardAndSpockLizardGameOption.Paper, StandardAndSpockLizardGameOption.Lizard, "lose")]
        [TestCase(StandardAndSpockLizardGameOption.Paper, StandardAndSpockLizardGameOption.Rock, "win")]
        [TestCase(StandardAndSpockLizardGameOption.Paper, StandardAndSpockLizardGameOption.Spock, "win")]
        [TestCase(StandardAndSpockLizardGameOption.Scissors, StandardAndSpockLizardGameOption.Scissors, "draw")]
        [TestCase(StandardAndSpockLizardGameOption.Scissors, StandardAndSpockLizardGameOption.Rock, "lose")]
        [TestCase(StandardAndSpockLizardGameOption.Scissors, StandardAndSpockLizardGameOption.Spock, "lose")]
        [TestCase(StandardAndSpockLizardGameOption.Scissors, StandardAndSpockLizardGameOption.Paper, "win")]
        [TestCase(StandardAndSpockLizardGameOption.Scissors, StandardAndSpockLizardGameOption.Lizard, "win")]
        [TestCase(StandardAndSpockLizardGameOption.Spock, StandardAndSpockLizardGameOption.Spock, "draw")]
        [TestCase(StandardAndSpockLizardGameOption.Spock, StandardAndSpockLizardGameOption.Paper, "lose")]
        [TestCase(StandardAndSpockLizardGameOption.Spock, StandardAndSpockLizardGameOption.Lizard, "lose")]
        [TestCase(StandardAndSpockLizardGameOption.Spock, StandardAndSpockLizardGameOption.Scissors, "win")]
        [TestCase(StandardAndSpockLizardGameOption.Spock, StandardAndSpockLizardGameOption.Rock, "win")]
        [TestCase(StandardAndSpockLizardGameOption.Lizard, StandardAndSpockLizardGameOption.Lizard, "draw")]
        [TestCase(StandardAndSpockLizardGameOption.Lizard, StandardAndSpockLizardGameOption.Rock, "lose")]
        [TestCase(StandardAndSpockLizardGameOption.Lizard, StandardAndSpockLizardGameOption.Scissors, "lose")]
        [TestCase(StandardAndSpockLizardGameOption.Lizard, StandardAndSpockLizardGameOption.Spock, "win")]
        [TestCase(StandardAndSpockLizardGameOption.Lizard, StandardAndSpockLizardGameOption.Paper, "win")]
        public void GetGameResultText_WithTestCases_ShouldContainExpectedText(StandardAndSpockLizardGameOption userGameOption, StandardAndSpockLizardGameOption computerGameOption, string expectedTextInResult)
        {
            // Arrange
            RockPaperScissorsSpockLizardGame rockPaperScissorsSpockLizardGame = new RockPaperScissorsSpockLizardGame();

            // Act
            string result = rockPaperScissorsSpockLizardGame.GetGameResultText(userGameOption, computerGameOption);

            // Assert
            StringAssert.Contains(expectedTextInResult, result);
        }
    }
}
