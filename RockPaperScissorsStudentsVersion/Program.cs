using System;

namespace RockPaperScissorsStudentsVersion
{
    class Program
    {
        static void Main(string[] args)
        {
            static void game()
            {
                try
                {
                    int rock = 1;
                    int paper = 2;
                    int scissors = 3;
                    int help = 8;
                    int quit = 9;
                    int coins = 0;

                    Console.Write("1 - Rock\n2 - Paper\n3 - Scissors\n\n8 - Help\n9 - Quit the game\n\nPlease make a selection: ");
                    int selection = Convert.ToInt32(Console.ReadLine());
                    Random rnd = new Random();
                    int AI_selection = rnd.Next(1, 4);
                    while (quit == 9)
                    {
                        if (selection == rock)
                        {
                            if (AI_selection == rock)
                            {
                                Console.WriteLine("I chose Rock!\nYou have a draw\n\n");
                                game();
                            }
                            else if (AI_selection == paper)
                            {
                                Console.WriteLine("I chose paper!\nYou lose!\n\n");
                                game();
                            }
                            else if (AI_selection == scissors)
                            {
                                Console.WriteLine("I chose Scissors!\n You win!\n\n");
                                coins = coins + 1;
                                Console.WriteLine("You currently have " + coins + " coins in the bank!\n\n");
                                game();
                            }
                        }
                        else if (selection == paper)
                        {
                            if (AI_selection == rock)
                            {
                                Console.WriteLine("I chose Rock!\nYou win!\n\n");
                                coins = coins + 1;
                                Console.WriteLine("You currently have " + coins + " coins in the bank!\n\n");
                                game();
                            }
                            else if (AI_selection == paper)
                            {
                                Console.WriteLine("I chose Paper!\nYou have a draw\n\n");
                                game();
                            }
                            else if (AI_selection == scissors)
                            {
                                Console.WriteLine("I chose Scissors!\n You lose!\n\n");
                                game();
                            }
                        }
                        else if (selection == scissors)
                        {
                            if (AI_selection == rock)
                            {
                                Console.WriteLine("I chose Rock!\nYou Lose!\n\n");
                                game();
                            }
                            else if (AI_selection == paper)
                            {
                                Console.WriteLine("I chose Paper!\nYou win!\n\n");
                                coins = coins + 1;
                                Console.WriteLine("You currently have " + coins + " in the bank!\n\n");
                                game();
                            }
                            else if (AI_selection == scissors)
                            {
                                Console.WriteLine("I chose Scissors!\nYou have a draw\n\n");
                                game();
                            }
                        }
                        else if (selection == help)
                        {
                            Console.WriteLine("\n\n\nYou have selected the Help option.\n\nTo play, simply type numbers only into the console. The options are the following: \n\n1 - Rock\n\n2 - Paper\n\n3 - Scissors\n\n8 - Help (Which is the prompt you are getting now)\n\n9 - Quit the game\n\n\nPress any to continue....");
                            Console.ReadLine();
                            game();
                        }
                        else if (selection == quit)
                        {
                            Console.Write("\n\nAre you sure you want to quit the game?: \n\n'Yes' or 'No': ");
                            string quitConfirmation = Console.ReadLine();
                            if (quitConfirmation == "Yes")
                            {
                                System.Environment.Exit(1);
                            }
                            else if (quitConfirmation == "No")
                            {
                                Console.WriteLine("Okay, resetting the game...\n\n\n");
                                game();
                            }
                        }
                    }
                }

                catch
                {
                    Console.WriteLine("\n\nINVALID ENTRY!!\n\nPlease enter one of the valid following options: \n\n");
                    game();
                }
            }
            game();
            Console.Read();
        }
    }
}
