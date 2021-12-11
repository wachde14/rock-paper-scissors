using RockPaperScissorsDIandUnitTested.Enums;
using System;
using System.Collections.Generic;

namespace RockPaperScissorsDIandUnitTested.RockPaperScissorsGameVariants
{
    public class RockPaperScissorsSpockLizardGame : IRockPaperScissorsVariant
    {
        public void PlayRound()
        {
            StandardAndSpockLizardGameOption userGameOptionSelection = GetGameOptionUserSelection();
            StandardAndSpockLizardGameOption computerGameOptionSelection = GetGameOptionComputerSelection();

            string gameRoundResult = GetGameResultText(userGameOptionSelection, computerGameOptionSelection);
            Console.Write("\n" + gameRoundResult + "\n");
        }

        public string GetGameResultText(StandardAndSpockLizardGameOption userGameOptionSelection, StandardAndSpockLizardGameOption computerGameOptionSelection)
        {
            if (userGameOptionSelection == computerGameOptionSelection)
            {
                return "\nThe AI chose " + computerGameOptionSelection.ToString() + ". It's a draw.\n";
            }

            if (userGameOptionSelection == StandardAndSpockLizardGameOption.Paper && computerGameOptionSelection == StandardAndSpockLizardGameOption.Scissors ||
                userGameOptionSelection == StandardAndSpockLizardGameOption.Paper && computerGameOptionSelection == StandardAndSpockLizardGameOption.Lizard ||
                userGameOptionSelection == StandardAndSpockLizardGameOption.Rock && computerGameOptionSelection == StandardAndSpockLizardGameOption.Paper ||
                userGameOptionSelection == StandardAndSpockLizardGameOption.Rock && computerGameOptionSelection == StandardAndSpockLizardGameOption.Spock ||
                userGameOptionSelection == StandardAndSpockLizardGameOption.Scissors && computerGameOptionSelection == StandardAndSpockLizardGameOption.Rock ||
                userGameOptionSelection == StandardAndSpockLizardGameOption.Scissors && computerGameOptionSelection == StandardAndSpockLizardGameOption.Spock ||
                userGameOptionSelection == StandardAndSpockLizardGameOption.Spock && computerGameOptionSelection == StandardAndSpockLizardGameOption.Paper ||
                userGameOptionSelection == StandardAndSpockLizardGameOption.Spock && computerGameOptionSelection == StandardAndSpockLizardGameOption.Lizard ||
                userGameOptionSelection == StandardAndSpockLizardGameOption.Lizard && computerGameOptionSelection == StandardAndSpockLizardGameOption.Rock ||
                userGameOptionSelection == StandardAndSpockLizardGameOption.Lizard && computerGameOptionSelection == StandardAndSpockLizardGameOption.Scissors)
            {
                return "\nThe AI chose " + computerGameOptionSelection.ToString() + ". You lose.\n";
            }

            if (userGameOptionSelection == StandardAndSpockLizardGameOption.Paper && computerGameOptionSelection == StandardAndSpockLizardGameOption.Rock ||
                userGameOptionSelection == StandardAndSpockLizardGameOption.Paper && computerGameOptionSelection == StandardAndSpockLizardGameOption.Spock ||
                userGameOptionSelection == StandardAndSpockLizardGameOption.Rock && computerGameOptionSelection == StandardAndSpockLizardGameOption.Scissors ||
                userGameOptionSelection == StandardAndSpockLizardGameOption.Rock && computerGameOptionSelection == StandardAndSpockLizardGameOption.Lizard ||
                userGameOptionSelection == StandardAndSpockLizardGameOption.Scissors && computerGameOptionSelection == StandardAndSpockLizardGameOption.Paper ||
                userGameOptionSelection == StandardAndSpockLizardGameOption.Scissors && computerGameOptionSelection == StandardAndSpockLizardGameOption.Lizard ||
                userGameOptionSelection == StandardAndSpockLizardGameOption.Spock && computerGameOptionSelection == StandardAndSpockLizardGameOption.Scissors ||
                userGameOptionSelection == StandardAndSpockLizardGameOption.Spock && computerGameOptionSelection == StandardAndSpockLizardGameOption.Rock ||
                userGameOptionSelection == StandardAndSpockLizardGameOption.Lizard && computerGameOptionSelection == StandardAndSpockLizardGameOption.Spock ||
                userGameOptionSelection == StandardAndSpockLizardGameOption.Lizard && computerGameOptionSelection == StandardAndSpockLizardGameOption.Paper)
            {
                return "\nThe AI chose " + computerGameOptionSelection.ToString() + ". You win!\n";
            }

            throw new Exception("Unable to calculate the game result");
        }

        private StandardAndSpockLizardGameOption GetGameOptionComputerSelection()
        {
            Random rnd = new Random();
            int randomInt = rnd.Next(1, 6);
            switch (randomInt)
            {
                case 1:
                    return StandardAndSpockLizardGameOption.Rock;
                case 2:
                    return StandardAndSpockLizardGameOption.Paper;
                case 3:
                    return StandardAndSpockLizardGameOption.Scissors;
                case 4:
                    return StandardAndSpockLizardGameOption.Spock;
                case 5:
                    return StandardAndSpockLizardGameOption.Lizard;
            }

            return StandardAndSpockLizardGameOption.Rock;
        }

        private StandardAndSpockLizardGameOption GetGameOptionUserSelection()
        {
            Dictionary<int, StandardAndSpockLizardGameOption> intGameSelectionDictionary = new Dictionary<int, StandardAndSpockLizardGameOption>();
            intGameSelectionDictionary.Add(1, StandardAndSpockLizardGameOption.Rock);
            intGameSelectionDictionary.Add(2, StandardAndSpockLizardGameOption.Paper);
            intGameSelectionDictionary.Add(3, StandardAndSpockLizardGameOption.Scissors);
            intGameSelectionDictionary.Add(4, StandardAndSpockLizardGameOption.Spock);
            intGameSelectionDictionary.Add(5, StandardAndSpockLizardGameOption.Lizard);

            while (true)
            {
                Console.Write("1 - Rock\n2 - Paper\n3 - Scissors\n4 - Spock\n5 - Lizard\n\nPlease make a selection: ");

                int userInputInteger;
                if (int.TryParse(Console.ReadLine(), out userInputInteger))
                {
                    if (intGameSelectionDictionary.ContainsKey(userInputInteger))
                    {
                        return intGameSelectionDictionary[userInputInteger];
                    }
                }
                Console.Write("Invalid selection. Please try again.\n");
            }
        }

        public void ShowHelpText()
        {
            Console.WriteLine("\n\nYou select an option and the computer will select an option.\n" +
                                    "Paper beats rock and Spock, but loses to scissors and lizard\n" +
                                    "Rock beats scissors and lizard, but loses to paper and Spock\n" +
                                    "Scissors beats paper and lizard, but loses to rock and Spock\n" +
                                    "Spock beats scissors and rock, but loses to paper and lizard\n" +
                                    "Lizard beats Spock and paper, but loses to rock and scissors\n" +
                                    "\nPress Enter to continue....\n\n");
            Console.ReadLine();
        }
    }
}
