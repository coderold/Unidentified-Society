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
            PrintTitle();
            MainMenu();
           
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

            if (MainMenuInput == 1)
            {
                Console.WriteLine("\n --- New Game ---");
                new Pet();
            }

        }
    }

    class Pet
    {
        public Pet()
        {
            Console.WriteLine("\nCreate your Pet!\n");
            CreatePet();
        }

        void CreatePet()
        {
            Console.WriteLine("1. What is your alien's name? \n" +
                              "    - Maximum of 8 Characters. \n" +
                              "    - Special Characters and Numbers are Allowed.");

            Console.Write(":");
            String name = Console.ReadLine();

            Console.WriteLine("\n2. What planet is your alien from?");
            Console.WriteLine("     [1] Aqua Planet Pampanga");
            Console.WriteLine("         - \"Endless oceans, karaoke, and glowing seafood feasts. Party central!\"");
            Console.WriteLine("     [2] Namec");
            Console.WriteLine("         - \"Green grass, blue skies, and chill warriors. Pure Zen.\"");
            Console.WriteLine("     [3] Kepler 22B");
            Console.WriteLine("         - \"Humid, cozy, and masarap magaluto\"");
            Console.WriteLine("     [4] Glacia");
            Console.WriteLine("         - \"A frozen world where snowstorms are the norm and ice caves hold hidden secrets.\" ");
            Console.WriteLine("     [5] Titan");
            Console.WriteLine("         - \"Methane rain, nitrogen pools, and frosty vibes. Cool in every way.\"");

            Console.Write(":");
            String planet = Console.ReadLine() switch
            {
                "1" => "Aqua Planet Pampanga",
                "2" => "Namec",
                "3" => "Kepler 22B",
                "4" => "Glacia",
                "5" => "TItan"
            };

            Console.WriteLine("\n3. Choose your alien's skin color:");
            Console.WriteLine("     [1] Green" +
                            "\n     [2] Gold " +
                            "\n     [3] Purple " +
                            "\n     [4] Chrome " +
                            "\n     [5] Charcoal");

            Console.Write(":");
            String skinColor = Console.ReadLine() switch
            {
                "1" => "Green",
                "2" => "Gold",
                "3" => "Purple",
                "4" => "Chrome",
                "5" => "Charcoal"
            };

            Console.WriteLine("\n4. How many eyes does your alien have (0-4)?");
            Console.Write(":");
            int eyes = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n5. Pick your alien's eye color: ");
            Console.WriteLine("     [1] Black " +
                            "\n     [2] Yellow " +
                            "\n     [3] Orange " +
                            "\n     [4] White " +
                            "\n     [5] Brown");

            Console.Write(":");
            String eyeColor = Console.ReadLine() switch
            {
                "1" => "Black",
                "2" => "Yellow",
                "3" => "Orange",
                "4" => "White",
                "5" => "Brown"
            };


            //Printing Pet Features
            Console.WriteLine("\nYou have successfully created your very own alien pet!");
            Console.WriteLine("\nName         : " + name);
            Console.WriteLine("Planet Origin  : " + planet);
            Console.WriteLine("Skin Color     : " + skinColor);
            Console.WriteLine("Eye Count      : " + eyes);
            Console.WriteLine("Eye Color      : " + eyeColor);

        }
    }
}
