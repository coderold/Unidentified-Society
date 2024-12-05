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
                    new Pet();
                    BackToMainMenu();
                    break;
                case 2:
                    Console.Clear();
                    new LoadGame();
                    BackToMainMenu();
                    break;
                case 3:
                    Console.Clear();
                    new CampaignMode();
                    BackToMainMenu();
                    break;
                case 4:
                    Console.Clear();
                    new Credits();
                    BackToMainMenu();
                    break;
                case 5:
                    Console.Clear();
                    Console.WriteLine("\nThanks for Playing!");
                    Environment.Exit(1);
                    break;
                default:
                    Console.Clear();
                    break;
                    
            }

        }
        void BackToMainMenu()
        {
            Console.WriteLine("\nGo back to Main Menu?");
            Console.WriteLine("[1] YES");
            Console.WriteLine("[2] NO");
            Console.Write(":");
            switch (Console.ReadLine())
            {
                case "1":
                    Console.Clear();
                    new Game();
                    break;
                case "2":
                    Console.WriteLine("\nThanks for Playing!");
                    System.Environment.Exit(1);
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Invalid input. Try again.\n");
                    BackToMainMenu();
                    break;
            }
        }
    }

    class LoadGame
    {
        public LoadGame()
        {
            Console.WriteLine("\nPlace holder palang po!");
        }
    }
    class CampaignMode
    {
        public CampaignMode()
        {
            Console.WriteLine("Welcome to the **Unidentified Society**!");
            Console.WriteLine("An Extraterrestrial World where your creativity, love, and care will shape the destiny of your alien companion.");
            Console.WriteLine();
            Console.WriteLine("In Campaign Mode, you’ll embark on a journey unlike any other, where the bonds you form and the choices you make will determine your alien’s future.");
            Console.WriteLine();
            Console.WriteLine("Experience the wonder of nurturing a life from the Extraterrestrial World, customizing your character with incredible abilities, and exploring diverse, breathtaking worlds filled with challenges, mysteries, and surprises.");
            Console.WriteLine();
            Console.WriteLine("Every decision you make shapes not only the story but also the unique connection between you and your alien.");
            Console.WriteLine();
            Console.WriteLine("Will you rise to the challenge and become the Hero of this Unidentified Society in the Extraterrestrial World?");
            Console.WriteLine();
            Console.WriteLine("Your partner is waiting… Let’s gooo!!!");
            Console.WriteLine();

        }
    }
    class Credits
    {
        public Credits()
        {
            Console.WriteLine("\n--- Credits ---");
            Console.WriteLine("Unidentified Society Game");
            Console.WriteLine();
            Console.WriteLine("Developed by:");
            Console.WriteLine("- Matthew Molina: Lead Programmer. Spearheaded the development of the core systems and gameplay mechanics.");
            Console.WriteLine("- Lance Anthony Montierro: Co-Lead Programmer. Contributed to system development and implemented key game functionalities.");
            Console.WriteLine("- Jheshiro Jevs Macado: Documentation Specialist. Authored and maintained detailed documentation for the game’s development process.");
            Console.WriteLine();
            Console.WriteLine("\nThank you for playing!");

        }
    }
}

