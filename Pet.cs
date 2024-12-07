    using System;

    namespace UnidentifiedSociety
    {
        // Struct para sa physical attribute ng alien kopal!
        struct PhysicalAttributes
        {
            public int Eyes { get; set; }
            public int Arms { get; set; }
            public string SkinColor { get; set; }

            public PhysicalAttributes(int eyes, int arms, string skinColor)
            {
                Eyes = eyes;
                Arms = arms;
                SkinColor = skinColor;
            }

            public override string ToString()
            {
                return $"Eye Count        : {Eyes}\n" +
                       $"Arm Count        : {Arms}\n" +
                       $"Skin Color       : {SkinColor}";
            }
        }

        // Struct para sa appearance ng alien kopal!
        struct AppearanceAttributes
        {
            public string Planet { get; set; }
            public string EyeColor { get; set; }
            public string Hairstyle { get; set; }
            public string BodyType { get; set; }
            public string Clothing { get; set; }
            public string Accessory { get; set; }

            public AppearanceAttributes(string planet, string eyeColor, string hairstyle, string bodyType, string clothing, string accessory)
            {
                Planet = planet;
                EyeColor = eyeColor;
                Hairstyle = hairstyle;
                BodyType = bodyType;
                Clothing = clothing;
                Accessory = accessory;
            }

            public override string ToString()
            {
                return $"Planet Origin    : {Planet}\n" +
                       $"Eye Color        : {EyeColor}\n" +
                       $"Hairstyle        : {Hairstyle}\n" +
                       $"Body Type        : {BodyType}\n" +
                       $"Clothing         : {Clothing}\n" +
                       $"Accessory        : {Accessory}";
            }
        }

        // Struct sa ibang attribute ng alien kopal!
        struct OtherAttributes
        {
            public bool HasTail { get; set; }
            public string FavoriteFood { get; set; }
            public string SpecialAbility { get; set; }
            public bool HasWings { get; set; }
            public bool GlowsInDark { get; set; }
            public string FavoriteActivity { get; set; }
            public string Transportation { get; set; }
            public string FavoriteExercise { get; set; }
            public string PreferredSoap { get; set; }
            public string SpecialTalent { get; set; }
           

        public OtherAttributes(bool hasTail, string favoriteFood, string specialAbility, bool hasWings, bool glowsInDark,
                                   string favoriteActivity, string transportation, string favoriteExercise, string preferredSoap, string specialTalent)
            {
                HasTail = hasTail;
                FavoriteFood = favoriteFood;
                SpecialAbility = specialAbility;
                HasWings = hasWings;
                GlowsInDark = glowsInDark;
                FavoriteActivity = favoriteActivity;
                Transportation = transportation;
                FavoriteExercise = favoriteExercise;
                PreferredSoap = preferredSoap;
                SpecialTalent = specialTalent;
            }

            public override string ToString()
            {
                return $"Has Tail         : {(HasTail ? "Yes" : "No")}\n" +
                       $"Favorite Food    : {FavoriteFood}\n" +
                       $"Special Ability  : {SpecialAbility}\n" +
                       $"Has Wings        : {(HasWings ? "Yes" : "No")}\n" +
                       $"Glows in Dark    : {(GlowsInDark ? "Yes" : "No")}\n" +
                       $"Favorite Activity: {FavoriteActivity}\n" +
                       $"Transportation   : {Transportation}\n" +
                       $"Favorite Exercise: {FavoriteExercise}\n" +
                       $"Preferred Soap   : {PreferredSoap}\n" +
                       $"Special Talent   : {SpecialTalent}";
            }
        }

    class Pet
    {
        private string name;

        public Pet()
        {
            Console.WriteLine("\n --- New Game ---");
            Console.WriteLine("\nCreate your Pet!\n");
            CreatePet();
        }

        private void SetPetName()
        {
            while (true)
            {
                Console.WriteLine("1. What is your alien's name? \n" +
                                  "    - Maximum of 8 Characters. \n" +
                                  "    - Special Characters and Numbers are Allowed.");
                Console.Write(": ");
                string input = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(input) && input.Length <= 8)
                {
                    this.name = input;
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Invalid input. Please select a valid option.\n");
                }
            }
        }

        private int AskNumericQuestion(string prompt, int min, int max)
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

        private string AskQuestion(string prompt, string[] choices)
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

        private string AskQuestion(string prompt, string[] choices, string[] descriptions)
        {
            while (true)
            {
                Console.WriteLine(prompt);
                for (int i = 0; i < choices.Length; i++)
                {
                    Console.WriteLine($"     [{i + 1}] {choices[i]}");
                    Console.WriteLine($"        {descriptions[i]}");
                }
                Console.Write(": ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int index) && index > 0 && index <= choices.Length)
                {
                    return choices[index - 1];
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Invalid input. Try again.\n");
                }

            }
        }

        private void CreatePet()
        {
            SetPetName();

            DateTime lastPlayed = DateTime.UtcNow;


            string planet = AskQuestion("\n2. What planet is your alien from?", new[] {
                "Aqua Planet Pampanga", "Namec", "Kepler 22B", "Glacia", "Titan"
            }, new[] {
                " - \"Endless oceans, karaoke, and glowing seafood feasts. Party central!\"",
                " - \"Green grass, blue skies, and chill warriors. Pure Zen.\"",
                " - \"Humid, cozy, and masarap magluto!\"",
                " - \"A frozen world where snowstorms are the norm and ice caves hold hidden secrets.\"",
                " - \"Methane rain, nitrogen pools, and frosty vibes. Cool in every way.\""
            });

            string skinColor = AskQuestion("\n3. Choose your alien's skin color:", new[] {
                "Green", "Gold", "Purple", "Chrome", "Charcoal"
            });

            int eyes = AskNumericQuestion("\n4. How many eyes does your alien have (0-4)?", 0, 4);
            string eyeColor = AskQuestion("\n5. Pick your alien's eye color:", new[] {
                "Black", "Yellow", "Orange", "White", "Brown"
            });

            string hairstyle = AskQuestion("\n6. Choose your alien's hairstyle:", new[] {
                "V-Cut Burst Fade", "Mullet", "Avatar Cut", "2 by 3", "Kalbo"
            });

            int arms = AskNumericQuestion("\n7. How many arms does your alien have (0-4)?", 0, 4);
            string bodyType = AskQuestion("\n8. What is your alien's body type?", new[] {
                "Slimy", "Furry", "Smooth", "Scaly", "Spiky"
            });

            string clothe = AskQuestion("\n9. What is your preferred clothing?", new[] {
                "Shirt", "Long sleeve", "Dress", "Crop top", "Jumpsuit"
            });

            string accessory = AskQuestion("\n10. Choose an accessory:", new[] {
                "Hat", "Crown", "Rolex", "Eye Glasses", "Bandana"
            });

            bool hasTail = AskQuestion("\n11. Does your alien have a tail?", new[] { "Yes", "No" }) == "Yes";

            string favoriteFood = AskQuestion("\n12. What is your alien's favorite food?", new[] {
                "Diwata pares", "Coco Crunch", "Graham Bar", "San Marino Maanghang", "Calderetang Aso"
            });

            string specialAbility = AskQuestion("\n13. Choose your alien's special ability:", new[] {
                "Invisibility", "Shape-shifting", "Telepathy", "Super speed", "Nonchalant"
            }, new[] {
                " - \"Perfect for sneaking around or making a dramatic exit. Out of sight, out of mind!\"",
                " - \"Become anyone or anything. Master of disguise with endless possibilities!\"",
                " - \"No need for words. Read minds and communicate with a thought!\"",
                " - \"Zoom through life like a blur. Blink and you'll miss it!\"",
                " - \"Stay calm, cool, and collected in any situation. Nothing fazes you.\""
            });

            bool hasWings = AskQuestion("\n14. Does your alien have wings?", new[] { "Yes", "No" }) == "Yes";
            bool glowsInDark = AskQuestion("\n15. Does your alien glow in the dark?", new[] { "Yes", "No" }) == "Yes";

            string favoriteActivity = AskQuestion("\n16. What is your alien's favorite activity?", new[] {
                "Playing Video Games", "Taking over the world", "Guitar", "Programming", "Cyberbullying"
            }, new[] {
                " - \"Leveling up, collecting loot, and mastering every game in the galaxy!\"",
                " - \"World domination? Just another day at the office.\"",
                " - \"Shredding solos and creating intergalactic rock anthems.\"",
                " - \"Coding your way to the future, one algorithm at a time.\"",
                " - \"Keyboard warrior, causing chaos across the web.\""
            });

            string transportation = AskQuestion("\n17. What is your alien's preferred mode of transportation?", new[] {
                "Hoverboard", "Space Scooter", "Teleportation", "Flying Saucer", "Walking"
            }, new[] {
                " - \"Glide through the air with ease. Speed and style in one!\"",
                " - \"Zip around with a bit of flair. It's a short-distance, intergalactic joyride!\"",
                " - \"Why bother with roads when you can just blink from one place to another?\"",
                " - \"Classic alien style cruise through the cosmos in your own UFO!\"",
                " - \"Who needs fancy tech? Sometimes, the journey is best taken one step at a time.\""
            });

            string favoriteExercise = AskQuestion("\n18. What is your alien's favorite exercise?", new[] {
                "Jog", "Climb rocks", "Go to another planet", "Pushups", "Arnis Advance Sinawali"
            });

            string preferredSoap = AskQuestion("\n19. What is your alien's preferred soap?", new[] {
                "Kagayaku Soap", "Kojic", "Sulfur Soap", "Tide Bar", "Bioderm"
            });

            string specialTalent = AskQuestion("\n20. What is your alien's special talent?", new[] {
                "Magic", "Acting", "Painting", "Playing an Instrument", "Singing"
            });

            // Instantiate structs
            var physicalAttributes = new PhysicalAttributes(eyes, arms, skinColor);
            var appearanceAttributes = new AppearanceAttributes(planet, eyeColor, hairstyle, bodyType, clothe, accessory);
            var otherAttributes = new OtherAttributes(hasTail, favoriteFood, specialAbility, hasWings, glowsInDark, favoriteActivity,
                                                     transportation, favoriteExercise, preferredSoap, specialTalent);

            // Print the pet details
            Console.Clear();
            Console.WriteLine("\nYou have successfully created your very own alien pet!");
            Console.WriteLine("\nName             : " + name);
            Console.WriteLine(physicalAttributes);
            Console.WriteLine(appearanceAttributes);
            Console.WriteLine(otherAttributes);

            DatabaseHelper.InsertCharacter(name, physicalAttributes, appearanceAttributes, otherAttributes).Wait();
        }
    }
}
