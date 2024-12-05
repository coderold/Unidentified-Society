using System;

namespace UnidentifiedSociety
{
    class Pet
    {
        private string name;
        public Pet()
        {
            Console.WriteLine("\n --- New Game ---");
            Console.WriteLine("\nCreate your Pet!\n");
            CreatePet();
        }

        void setPetName()
        {

            while (true)
            {
                Console.WriteLine("1. What is your alien's name? \n" +
                  "    - Maximum of 8 Characters. \n" +
                  "    - Special Characters and Numbers are Allowed.");

                Console.Write(":");
                String input = Console.ReadLine();


                if (input.Length <= 8 && input != " ")
                {
                    name = input;
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Invalid input. Please select a valid option.\n");

                }

            }
        }
        int AskNumericQuestion(string prompt, int min, int max)
        {
            while (true)
            {
                Console.WriteLine(prompt);
                Console.Write(": ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int value) && value >= min && value <= max)
                {
                    return value;
                }

                Console.Clear();
                Console.WriteLine($"Invalid input. Please enter a number between {min} and {max}.\n");
            }
        }
        string AskQuestion(string prompt, string[] choices)
        {
            while (true)
            {
                Console.WriteLine(prompt);
                for (int i = 0; i < choices.Length; i++)
                {
                    Console.WriteLine($"     [{i + 1}] {choices[i]}");
                }

                Console.Write(": ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int index) && index > 0 && index <= choices.Length)
                {
                    return choices[index - 1];
                }

                Console.Clear();
                Console.WriteLine("Invalid input. Try again.\n");
            }
        }

        string AskQuestion(string prompt, string[] choices, string[] desc)
        {
            while (true)
            {
                Console.WriteLine(prompt);
                for (int i = 0; i < choices.Length; i++)
                {
                    Console.WriteLine($"     [{i + 1}] {choices[i]}");
                    Console.WriteLine($"        {desc[i]}");
                }

                Console.Write(": ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int index) && index > 0 && index <= choices.Length)
                {
                    return choices[index - 1];
                }

                Console.Clear();
                Console.WriteLine("Invalid input. Try again.\n");
            }
        }
        void CreatePet()
        {
            setPetName();

            //Planet
            string planet = AskQuestion("\n2. What planet is your alien from?", new[] {
                "Aqua Planet Pampanga",
                "Namec",
                "Kepler 22B",
                "Glacia",
                "Titan"
            }, new[]
            {
                " - \"Endless oceans, karaoke, and glowing seafood feasts. Party central!\"",
                " - \"Green grass, blue skies, and chill warriors. Pure Zen.\"",
                " - \"Humid, cozy, and masarap magaluto\"",
                " - \"A frozen world where snowstorms are the norm and ice caves hold hidden secrets.\"",
                " - \"Methane rain, nitrogen pools, and frosty vibes. Cool in every way.\""
            });

            // Skin color selection
            string skinColor = AskQuestion("\n3. Choose your alien's skin color:", new[] {
                "Green", "Gold", "Purple", "Chrome", "Charcoal"
            });

            // Eyes count
            int eyes = AskNumericQuestion("\n4. How many eyes does your alien have (0-4)?", 0, 4);

            // Eye color
            string eyeColor = AskQuestion("\n5. Pick your alien's eye color:", new[] {
                "Black", "Yellow", "Orange", "White", "Brown"
            });

            // Hairstyle
            string hairstyle = AskQuestion("\n6. Choose your alien's hairstyle:", new[] {
                "V-Cut Burst fade", "Mullet", "Avatar Cut", "2 by 3", "Kalbo"
            });

            // Arms count
            int arms = AskNumericQuestion("\n7. How many arms does your alien have (0-4)?", 0, 4);

            // Body type
            string bodyType = AskQuestion("\n8. What is your alien's body type?", new[] {
                "Slimy", "Furry", "Smooth", "Scaly", "Spiky"
            });

            // Clothe
            string clothe = AskQuestion("\n9. What is your preferred clothe?", new[] {
                "Shirt", "Long sleeve", "Dress", "Crop top", "Jumpsuit"
            });

            // Accessory
            string accessory = AskQuestion("\n10. Choose an accessory?", new[] {
                "Hat", "Crown", "Rolex", "Eye Glasses", "Bandana"
            });

            // Has Tail
            bool hasTail = AskQuestion("\n11. Does your alien have a tail?", new[] {
                "Yes", "No"
            }) == "Yes";

            // Favorite Food
            string favoriteFood = AskQuestion("\n12. What is your alien's favorite food?", new[] {
                "Diwata pares", "Coco Crunch", "Graham Bar", "San Marino Maanghang", "Calderetang Aso"
            });

            // Special Ability
            string specialAbility = AskQuestion("\n13. Choose your alien's special ability:", new[] {
                "Invisibility",
                "Shape-shifting",
                "Telepathy",
                "Super speed",
                "Nonchalant"
            }, new[]
            {
                " - \"Perfect for sneaking around or making a dramatic exit. Out of sight, out of mind!\"",
                " - \"Become anyone or anything. Master of disguise with endless possibilities!\"",
                " - \"No need for words. Read minds and communicate with a thought!\"",
                " - \"Zoom through life like a blur. Blink and you'll miss it!\"",
                " - \"Stay calm, cool, and collected in any situation. Nothing fazes you.\""
            });


            // Has Wings
            bool hasWings = AskQuestion("\n14. Does your alien have wings?", new[] {
                "Yes", "No"
            }) == "Yes";

            // Glows in Dark
            bool glowsInDark = AskQuestion("\n15. Does your alien glow in the dark?", new[] {
                "Yes", "No"
            }) == "Yes";

            // Favorite Activity
            string favoriteActivity = AskQuestion("\n16. What is your alien's favorite activity?", new[] {
                "Playing Video Games",
                "Taking over the world",
                "Guitar",
                "Programming",
                "Cyberbullying"
            }, new[]
            {
                " - \"Leveling up, collecting loot, and mastering every game in the galaxy!\"",
                " - \"World domination? Just another day at the office.\"",
                " - \"Shredding solos and creating intergalactic rock anthems.\"",
                " - \"Coding your way to the future, one algorithm at a time.\"",
                " - \"Keyboard warrior, causing chaos across the web.\""
            });


            // Transportation
            string transportation = AskQuestion("\n17. What is your alien's preferred mode of transportation?", new[] {
                "Hoverboard",
                "Space Scooter",
                "Teleportation",
                "Flying Saucer",
                "Walking"
            }, new[]
            {
                " - \"Glide through the air with ease. Speed and style in one!\"",
                " - \"For those who like to zip around with a bit of flair. It's a short-distance, intergalactic joyride!\"",
                " - \"Why bother with roads when you can just blink from one place to another?\"",
                " - \"Classic alien style cruise through the cosmos in your own UFO!\"",
                " - \"Who needs fancy tech? Sometimes, the journey is best taken one step at a time.\""
            });

            // Favorite Exercise
            string favoriteExercise = AskQuestion("\n18. What is your alien's favorite exercise?", new[] {
                "Jog", "Climb rocks", "Go to another planet", "Pushups", "Arnis Advance Sinawali"
            });

            // Preferred Soap
            string preferredSoap = AskQuestion("\n19. What is your alien's preferred soap?", new[] {
                "Kagayaku soap", "Kojic", "Sulfur Soap", "Tide Bar", "Bioderm"
            });

            // Special Talent
            string specialTalent = AskQuestion("\n20. What is your alien's special talent?", new[] {
                "Magic", "Acting", "Painting", "Playing an Instrument", "Singing"
            });

            // Printing Pet Features
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
}
