using RockPaperScissorsDIandUnitTested.RockPaperScissorsGameVariants;

namespace RockPaperScissorsDIandUnitTested
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inject the standard variant
            StandardRockPaperScissorsGame standardRockPaperScissorsGame = new StandardRockPaperScissorsGame();
            RockPaperScissorsGameManager rockPaperScissorsGameManager = new RockPaperScissorsGameManager(standardRockPaperScissorsGame);
            rockPaperScissorsGameManager.StartGameLoop();

            // Inject an example of a different variant
            RockPaperScissorsSpockLizardGame rockPaperScissorsSpockLizardGame = new RockPaperScissorsSpockLizardGame();
            rockPaperScissorsGameManager = new RockPaperScissorsGameManager(rockPaperScissorsSpockLizardGame);
            rockPaperScissorsGameManager.StartGameLoop();
        }
    }
}
