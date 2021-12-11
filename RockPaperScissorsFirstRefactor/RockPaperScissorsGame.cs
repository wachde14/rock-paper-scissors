using RockPaperScissors.Enums;
using System;
using System.Collections.Generic;

namespace RockPaperScissorsFirstRefactor
{
    public class RockPaperScissorsGame
    {
        public void StartGameLoop()
        {
            bool hasPlayerQuit = false;
            while(!hasPlayerQuit)
            {
                MenuOption userSelection = GetPlayHelpOrQuitUserSelection();

                switch (userSelection)
                {
                    case MenuOption.Help:
                        ShowHelpText();
                        break;
                    case MenuOption.Quit:
                        ShowQuitGameText();
                        hasPlayerQuit = true;
                        break;
                    case MenuOption.Play:
                        PlayRockPaperScissorsRound();
                        break;
                    default:
                        throw new InvalidOperationException();
                }
            }
        }

        private void PlayRockPaperScissorsRound()
        {
            GameOption userGameOptionSelection = GetGameOptionUserSelection();
            GameOption computerGameOptionSelection = GetGameOptionComputerSelection();

            string gameRoundResult = GetGameResultText(userGameOptionSelection,computerGameOptionSelection);
            Console.Write("\n" + gameRoundResult + "\n");
        }

        private string GetGameResultText(GameOption userGameOptionSelection, GameOption computerGameOptionSelection)
        {
            if (userGameOptionSelection == computerGameOptionSelection)
            {
                return "\nThe AI chose " + computerGameOptionSelection.ToString() + ". It's a draw.\n";
            }

            if (userGameOptionSelection == GameOption.Paper && computerGameOptionSelection == GameOption.Scissors ||
                userGameOptionSelection == GameOption.Rock && computerGameOptionSelection == GameOption.Paper ||
                userGameOptionSelection == GameOption.Scissors && computerGameOptionSelection == GameOption.Rock)
            {
                return "\nThe AI chose " + computerGameOptionSelection.ToString() + ". You lose.\n";
            }

            if (userGameOptionSelection == GameOption.Paper && computerGameOptionSelection == GameOption.Rock ||
                userGameOptionSelection == GameOption.Rock && computerGameOptionSelection == GameOption.Scissors ||
                userGameOptionSelection == GameOption.Scissors && computerGameOptionSelection == GameOption.Paper)
            {
                return "\nThe AI chose " + computerGameOptionSelection.ToString() + ". You win!\n";
            }

            throw new Exception("Unable to calculate the game result");
        }

        private GameOption GetGameOptionComputerSelection()
        {
            Random rnd = new Random();
            int randomInt = rnd.Next(1, 4);
            switch (randomInt)
            {
                case 1:
                    return GameOption.Rock;
                case 2:
                    return GameOption.Paper;
                case 3:
                    return GameOption.Scissors;
            }

            return GameOption.Rock;
        }

        private GameOption GetGameOptionUserSelection()
        {
            Dictionary<int, GameOption> intGameSelectionDictionary = new Dictionary<int, GameOption>();
            intGameSelectionDictionary.Add(1, GameOption.Rock);
            intGameSelectionDictionary.Add(2, GameOption.Paper);
            intGameSelectionDictionary.Add(3, GameOption.Scissors);

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

        private MenuOption GetPlayHelpOrQuitUserSelection()
        {
            Dictionary<int, MenuOption> intMenuOptionDictionary = new Dictionary<int, MenuOption>();
            intMenuOptionDictionary.Add(1, MenuOption.Play);
            intMenuOptionDictionary.Add(2, MenuOption.Help);
            intMenuOptionDictionary.Add(3, MenuOption.Quit);

            while (true)
            {
                Console.Write("1 - Play\n2 - Help\n3 - Quit\n\nPlease make a selection: ");

                int userInputInteger;
                if (int.TryParse(Console.ReadLine(), out userInputInteger))
                {
                    if (intMenuOptionDictionary.ContainsKey(userInputInteger))
                    {
                        return intMenuOptionDictionary[userInputInteger];
                    }
                }
                Console.Write("Invalid selection. Please try again.\n");
            }
        }

        private void ShowHelpText()
        {
            Console.WriteLine("\n\nYou select an option and the computer will select an option. Rock > paper, paper > scissors, scissors > rock. \nPress Enter to continue....\n\n");
            Console.ReadLine();
        }

        private void ShowQuitGameText()
        {
            Console.WriteLine("\n\nOkay, see you later!\n");
            Console.WriteLine("Press any key to exit...\n\n");
            Console.ReadLine();
        }
    }
}

