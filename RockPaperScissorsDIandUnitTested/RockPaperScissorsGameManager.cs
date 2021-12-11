using RockPaperScissorsDIandUnitTested.Enums;
using RockPaperScissorsDIandUnitTested.RockPaperScissorsGameVariants;
using System;
using System.Collections.Generic;

namespace RockPaperScissorsDIandUnitTested
{
    public class RockPaperScissorsGameManager
    {
        IRockPaperScissorsVariant _rockPaperScissorsVariant;
        public RockPaperScissorsGameManager(IRockPaperScissorsVariant rockPaperScissorsVariant)
        {
            _rockPaperScissorsVariant = rockPaperScissorsVariant;
        }

        public void StartGameLoop()
        {
            bool hasPlayerQuit = false;
            while (!hasPlayerQuit)
            {
                MenuOption userSelection = GetPlayHelpOrQuitUserSelection();

                switch (userSelection)
                {
                    case MenuOption.Help:
                        _rockPaperScissorsVariant.ShowHelpText();
                        break;
                    case MenuOption.Quit:
                        ShowQuitGameText();
                        hasPlayerQuit = true;
                        break;
                    case MenuOption.Play:
                        _rockPaperScissorsVariant.PlayRound();
                        break;
                    default:
                        throw new InvalidOperationException();
                }
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

        private void ShowQuitGameText()
        {
            Console.WriteLine("\n\nOkay, see you later!\n");
            Console.WriteLine("Press any key to exit...\n\n");
            Console.ReadLine();
        }
    }
}
