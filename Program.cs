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
        private bool RunGame;
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
                    System.Environment.Exit(1);
                    break;
            }
        }
    }

    class Pet
    {
        public Pet()
        {
            Console.WriteLine("\n --- New Game ---");
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
                "5" => "Titan"
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

            Console.WriteLine("\n6. Choose your alien's hairstyle:");
            Console.WriteLine("     [1] V-Cut Burst fade " +
                            "\n     [2] Mullet " +
                            "\n     [3] Avatar Cut " +
                            "\n     [4] 2 by 3 " +
                            "\n     [5] Kalbo");

            Console.Write(":");
            String hairstyle = Console.ReadLine() switch
            {
                "1" => "V-Cut Burst fade",
                "2" => "Mullet",
                "3" => "Avatar Cut",
                "4" => "2 by 3",
                "5" => "Kalbo"
            };

            Console.WriteLine("\n7. How many arms does your alien have (0-4)?");
            Console.Write(":");
            int arms = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n8. What is your alien's body type?");
            Console.WriteLine("     [1] Slimy " +
                            "\n     [2] Furry " +
                            "\n     [3] Smooth " +
                            "\n     [4] Scaly " +
                            "\n     [5] Spiky");

            Console.Write(":");
            String bodyType = Console.ReadLine() switch
            {
                "1" => "Slimy",
                "2" => "Furry",
                "3" => "Smooth",
                "4" => "Scaly",
                "5" => "Spiky"
            };

            Console.WriteLine("\n9. What is your preferred clothe?");
            Console.WriteLine("     [1] Shirt " +
                            "\n     [2] Long sleeve " +
                            "\n     [3] Dress " +
                            "\n     [4] Crop top " +
                            "\n     [5] Jumpsuit");

            Console.Write(":");
            String clothe = Console.ReadLine() switch
            {
                "1" => "Shirt",
                "2" => "Long sleeve",
                "3" => "Dress",
                "4" => "Crop top",
                "5" => "Jumpsuit"
            };

            Console.WriteLine("\n10. Choose an accessory?");
            Console.WriteLine("     [1] Hat " +
                            "\n     [2] Crown " +
                            "\n     [3] Rolex " +
                            "\n     [4] Eye Glasses " +
                            "\n     [5] Bandana");

            Console.Write(":");
            String accessory = Console.ReadLine() switch
            {
                "1" => "Hat",
                "2" => "Crown",
                "3" => "Rolex",
                "4" => "Eye Glasses",
                "5" => "Bandana"
            };

            Console.WriteLine("\n11. Does your alien have a tail?");
            Console.WriteLine("     [1] Yes " +
                            "\n     [2] No");

            Console.Write(":");
            bool hasTail = Console.ReadLine() == "1";

            Console.WriteLine("\n12. What is your alien's favorite food?");
            Console.WriteLine("     [1] Diwata pares " +
                            "\n     [2] Coco Crunch " +
                            "\n     [3] Graham Bar " +
                            "\n     [4] San Marino Maanghang " +
                            "\n     [5] Calderetang Aso");

            Console.Write(":");
            String favoriteFood = Console.ReadLine() switch
            {
                "1" => "Diwata pares",
                "2" => "Coco Crunch",
                "3" => "Graham Bar",
                "4" => "San Marino Maanghang",
                "5" => "Calderetang Aso"
            };

            Console.WriteLine("\n13. Choose your alien's special ability:");
            Console.WriteLine("     [1] Invisibility " +
                            "\n         - \"Perfect for sneaking around or making a dramatic exit. Out of sight, out of mind!\"" +
                            "\n     [2] Shape-shifting " +
                            "\n         - \"Become anyone or anything. Master of disguise with endless possibilities!\"" +
                            "\n     [3] Telepathy " +
                            "\n         - \"No need for words. Read minds and communicate with a thought!\"" +
                            "\n     [4] Super speed " +
                            "\n         - \"Zoom through life like a blur. Blink and you'll miss it!\"" +
                            "\n     [5] Nonchalant " +
                            "\n         - \"Stay calm, cool, and collected in any situation. Nothing fazes you.\"");

            Console.Write(":");
            String specialAbility = Console.ReadLine() switch
            {
                "1" => "Invisibility",
                "2" => "Shape-shifting",
                "3" => "Telepathy",
                "4" => "Super speed",
                "5" => "Nonchalant"
            };

            Console.WriteLine("\n14. Does your alien have wings?");
            Console.WriteLine("     [1] Yes " +
                            "\n     [2] No");

            Console.Write(":");
            bool hasWings = Console.ReadLine() == "1";

            Console.WriteLine("\n15. Does your alien glow in the dark?");
            Console.WriteLine("     [1] Yes " +
                            "\n     [2] No");

            Console.Write(":");
            bool glowsInDark = Console.ReadLine() == "1";

            Console.WriteLine("\n16. What is your alien's favorite activity?");
            Console.WriteLine("     [1] Playing Video Games " +
                            "\n         - \"Leveling up, collecting loot, and mastering every game in the galaxy!\"" +
                            "\n     [2] Taking over the world " +
                            "\n         - \"World domination? Just another day at the office.\"" +
                            "\n     [3] Guitar " +
                            "\n         - \"Shredding solos and creating intergalactic rock anthems.\"" +
                            "\n     [4] Programming " +
                            "\n         - \"Coding your way to the future, one algorithm at a time.\"" +
                            "\n     [5] Cyberbullying " +
                            "\n         - \"Keyboard warrior, causing chaos across the web.\"");

            Console.Write(":");
            String favoriteActivity = Console.ReadLine() switch
            {
                "1" => "Playing Video Games",
                "2" => "Taking over the world",
                "3" => "Guitar",
                "4" => "Programming",
                "5" => "Cyberbullying"
            };

            Console.WriteLine("\n17. What is your alien's preferred mode of transportation?");
            Console.WriteLine("     [1] Hoverboard " +
                            "\n         - \"Glide through the air with ease. Speed and style in one!\"" +
                            "\n     [2] Space Scooter " +
                            "\n         - \"For those who like to zip around with a bit of flair. It's a short-distance, intergalactic joyride!\"" +
                            "\n     [3] Teleportation " +
                            "\n         - \"Why bother with roads when you can just blink from one place to another?\"" +
                            "\n     [4] Flying Saucer " +
                            "\n         - \"Classic alien style cruise through the cosmos in your own UFO!\"" +
                            "\n     [5] Walking " +
                            "\n         - \"Who needs fancy tech? Sometimes, the journey is best taken one step at a time.\"");

            Console.Write(":");
            String transportation = Console.ReadLine() switch
            {
                "1" => "Hoverboard",
                "2" => "Space Scooter",
                "3" => "Teleportation",
                "4" => "Flying Saucer",
                "5" => "Walking"
            };

            Console.WriteLine("\n18. What is your alien's favorite exercise?");
            Console.WriteLine("     [1] Jog " +
                            "\n     [2] Climb rocks " +
                            "\n     [3] Go to another planet " +
                            "\n     [4] Pushups " +
                            "\n     [5] Arnis Advance Sinawali");

            Console.Write(":");
            String favoriteExercise = Console.ReadLine() switch
            {
                "1" => "Jog",
                "2" => "Climb rocks",
                "3" => "Go to another planet",
                "4" => "Pushups",
                "5" => "Arnis Advance Sinawali"
            };

            Console.WriteLine("\n19. What is your alien's preferred soap?");
            Console.WriteLine("     [1] Kagayaku soap " +
                            "\n     [2] Kojic " +
                            "\n     [3] Sulfur Soap " +
                            "\n     [4] Tide Bar " +
                            "\n     [5] Bioderm");

            Console.Write(":");
            String preferredSoap = Console.ReadLine() switch
            {
                "1" => "Kagayaku soap",
                "2" => "Kojic",
                "3" => "Sulfur Soap",
                "4" => "Tide Bar",
                "5" => "Bioderm"
            };

            Console.WriteLine("\n20. What is your alien's special talent?");
            Console.WriteLine("     [1] Magic " +
                            "\n     [2] Acting " +
                            "\n     [3] Painting " +
                            "\n     [4] Playing an Instrument " +
                            "\n     [5] Singing");

            Console.Write(":");
            String specialTalent = Console.ReadLine() switch
            {
                "1" => "Magic",
                "2" => "Acting",
                "3" => "Painting",
                "4" => "Playing an Instrument",
                "5" => "Singing"
            };

            //Printing Pet Features
            Console.Clear();
            Console.WriteLine("\nYou have successfully created your very own alien pet!");
            Console.WriteLine("\nName             : " + name);
            Console.WriteLine("Planet Origin    : " + planet);
            Console.WriteLine("Skin Color       : " + skinColor);
            Console.WriteLine("Eye Count        : " + eyes);
            Console.WriteLine("Eye Color        : " + eyeColor);
            Console.WriteLine("Hairstyle        : " + hairstyle);
            Console.WriteLine("Arm Count        : " + arms);
            Console.WriteLine("Body Type        : " + bodyType);
            Console.WriteLine("Clothe           : " + clothe);
            Console.WriteLine("Accessory        : " + accessory);
            Console.WriteLine("Has Tail         : " + (hasTail ? "Yes" : "No"));
            Console.WriteLine("Favorite Food    : " + favoriteFood);
            Console.WriteLine("Special Ability  : " + specialAbility);
            Console.WriteLine("Has Wings        : " + (hasWings ? "Yes" : "No"));
            Console.WriteLine("Glows in Dark    : " + (glowsInDark ? "Yes" : "No"));
            Console.WriteLine("Favorite Activity: " + favoriteActivity);
            Console.WriteLine("Transportation   : " + transportation);
            Console.WriteLine("Favorite Exercise: " + favoriteExercise);
            Console.WriteLine("Preferred Soap   : " + preferredSoap);
            Console.WriteLine("Special Talent   : " + specialTalent);
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

