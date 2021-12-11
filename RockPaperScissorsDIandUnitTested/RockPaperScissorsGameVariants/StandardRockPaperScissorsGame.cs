using RockPaperScissorsDIandUnitTested.Enums;
using System;
using System.Collections.Generic;

namespace RockPaperScissorsDIandUnitTested.RockPaperScissorsGameVariants
{
    public class StandardRockPaperScissorsGame: IRockPaperScissorsVariant
    {
        public void PlayRound()
        {
            StandardGameOption userGameOptionSelection = GetGameOptionUserSelection();
            StandardGameOption computerGameOptionSelection = GetGameOptionComputerSelection();

            string gameRoundResult = GetGameResultText(userGameOptionSelection,computerGameOptionSelection);
            Console.Write("\n" + gameRoundResult + "\n");
        }

        public string GetGameResultText(StandardGameOption userGameOptionSelection, StandardGameOption computerGameOptionSelection)
        {
            if (userGameOptionSelection == computerGameOptionSelection)
            {
                return "\nThe AI chose " + computerGameOptionSelection.ToString() + ". It's a draw.\n";
            }

            if (userGameOptionSelection == StandardGameOption.Paper && computerGameOptionSelection == StandardGameOption.Scissors ||
                userGameOptionSelection == StandardGameOption.Rock && computerGameOptionSelection == StandardGameOption.Paper ||
                userGameOptionSelection == StandardGameOption.Scissors && computerGameOptionSelection == StandardGameOption.Rock)
            {
                return "\nThe AI chose " + computerGameOptionSelection.ToString() + ". You lose.\n";
            }

            if (userGameOptionSelection == StandardGameOption.Paper && computerGameOptionSelection == StandardGameOption.Rock ||
                userGameOptionSelection == StandardGameOption.Rock && computerGameOptionSelection == StandardGameOption.Scissors ||
                userGameOptionSelection == StandardGameOption.Scissors && computerGameOptionSelection == StandardGameOption.Paper)
            {
                return "\nThe AI chose " + computerGameOptionSelection.ToString() + ". You win!\n";
            }

            throw new Exception("Unable to calculate the game result");
        }

        private StandardGameOption GetGameOptionComputerSelection()
        {
            Random rnd = new Random();
            int randomInt = rnd.Next(1, 4);
            switch (randomInt)
            {
                case 1:
                    return StandardGameOption.Rock;
                case 2:
                    return StandardGameOption.Paper;
                case 3:
                    return StandardGameOption.Scissors;
            }

            return StandardGameOption.Rock;
        }

        private StandardGameOption GetGameOptionUserSelection()
        {
            Dictionary<int, StandardGameOption> intGameSelectionDictionary = new Dictionary<int, StandardGameOption>();
            intGameSelectionDictionary.Add(1, StandardGameOption.Rock);
            intGameSelectionDictionary.Add(2, StandardGameOption.Paper);
            intGameSelectionDictionary.Add(3, StandardGameOption.Scissors);

            while (true)
            {
                Console.Write("1 - Rock\n2 - Paper\n3 - Scissors\n\nPlease make a selection: ");

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
                                    "Paper beats rock, but loses to scissors\n" +
                                    "Rock beats scissors and lizard, but loses to paper and Spock\n" +
                                    "Scissors beats paper, but loses to rock\n" +
                                    "\nPress Enter to continue....\n\n");
            Console.ReadLine();
        }
    }
}

