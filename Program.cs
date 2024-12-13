using System;

namespace UnidentifiedSociety
{
    class Program
    {
        public static void Main(string[] args)
        {
            new Game();

        }
    }

    class Game
    {

        public Game()
        {
            while (true)
            {
                PrintTitle();
                MainMenu();
            }
        }

        void PrintTitle()
        {
            Console.WriteLine("\r\n  __  __     ____   __         __  _ ____        __\r\n / / / /__  /  _/__/ /__ ___  / /_(_) _(_)__ ___/ /\r\n/ /_/ / _ \\_/ // _  / -_) _ \\/ __/ / _/ / -_) _  / \r\n\\____/_//_/___/\\_,_/\\__/_//_/\\__/_/_//_/\\__/\\_,_/  \r\n         / __/__  ____(_)__ / /___ __              \r\n        _\\ \\/ _ \\/ __/ / -_) __/ // /              \r\n       /___/\\___/\\__/_/\\__/\\__/\\_, /               \r\n                              /___/                \r\n");
        }

        void MainMenu()
        {

            try
            {

                Console.WriteLine(" --- Main Menu ---\n");
                Console.WriteLine("[1] NEW GAME ");
                Console.WriteLine("[2] LOAD GAME ");
                Console.WriteLine("[3] CAMPAIGN MODE ");
                Console.WriteLine("[4] CREDITS ");
                Console.WriteLine("[5] EXIT ");

                byte MainMenuInput = Convert.ToByte(Console.ReadLine());

                switch (MainMenuInput)
                {
                    case 1:
                        Console.Clear();
                        PrintTitle();
                        GameMode game = new NewGame();
                        game.Start();
                        BackToMainMenu();
                        break;
                    case 2:
                        Console.Clear();
                        GameMode loadGame = new LoadGame();
                        loadGame.Start();
                        BackToMainMenu();
                        break;
                    case 3:
                        Console.Clear();
                        GameMode campaign = new CampaignMode();
                        campaign.Start();
                        BackToMainMenu();
                        break;
                    case 4:
                        Console.Clear();
                        GameMode credits = new Credits();
                        credits.Start();
                        BackToMainMenu();
                        break;
                    case 5:
                        Console.WriteLine("\nThanks for Playing!");
                        Console.WriteLine("Press any key to exit");
                        Console.ReadKey();
                        System.Environment.Exit(1);
                        break;
                    default:
                        Console.Clear();
                        throw new InvalidOperationException("Invalid menu selection.");

                }

            }
            catch (FormatException)
            {
                Console.Clear();
                Console.WriteLine("Invalid input. Please enter a valid number.\n");
                PrintTitle();
                MainMenu();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

        }

        void BackToMainMenu()
        {

            Console.WriteLine("\nGo back to Main Menu?");
            Console.WriteLine("[1] YES");
            Console.WriteLine("[2] NO");
            Console.Write(":");

            try
            {
                byte input = Convert.ToByte(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        Console.Clear();
                        new Game();

                        break;
                    case 2:
                        Console.WriteLine("\nThanks for Playing!");
                        Console.WriteLine("Press any key to exit");
                        Console.ReadKey();
                        System.Environment.Exit(1);
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Invalid input. Try again.\n");
                        BackToMainMenu();
                        break;
                }
            } catch (FormatException e)
            {
                Console.Clear();
                Console.WriteLine("Invalid input. Try again.\n");
                BackToMainMenu();
            }
        }
    } 
    }

