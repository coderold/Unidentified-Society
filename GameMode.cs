using Microsoft.VisualBasic.FileIO;
using System;

namespace UnidentifiedSociety
{
    //interface
    public interface IGameMode
    {
        void Start();
    }

    abstract class GameMode : IGameMode
    {
        public abstract void Start();
    }

    // Inherited class with method overriding
    class LoadGame : GameMode
    {
        public override void Start()
        {
            try
            {
                Console.WriteLine("\n--- Load Game ---");

                var characters = DatabaseHelper.GetAllCharacters().Result;

                if (characters.Count == 0)
                {
                    Console.WriteLine("No saved characters found. Please create a new character.");
                    return;
                }

                DisplayMenu();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        private void DisplayMenu()
        {
            while (true)
            {
                var characters = DatabaseHelper.GetAllCharacters().Result;
                Console.WriteLine("\n[1] View all characters");
                Console.WriteLine("[2] View a specific character");
                Console.WriteLine("[3] Delete a character");
                Console.WriteLine("[4] Go back to Main Menu");
                Console.Write(": ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        DisplayAllCharacters(characters);
                        break;
                    case "2":
                        ViewSpecificCharacter(characters);
                        break;
                    case "3":
                        DeleteCharacter();
                        break;
                    case "4":
                        Console.Clear();
                        return;
                    default:
                        Console.Clear();
                        Console.WriteLine("Invalid input. Please try again.");
                        break;
                }
            }
        }

        private void DisplayAllCharacters(Dictionary<string, object> characters)
        {
            Console.Clear();
            if (characters.Count == 0)
            {
                Console.WriteLine("No characters available to display");
                return;
            }
            Console.WriteLine("--- All Character Information ---");
            foreach (var character in characters)
            {
                Console.WriteLine($"Name: {character.Key}");
                Console.WriteLine($"Details: {character.Value}");
                Console.WriteLine("--------------------------------");
            }

            AskToGoBack();
        }

        private void ViewSpecificCharacter(Dictionary<string, object> characters)
        {
            Console.Clear();

            if (characters.Count == 0)
            {
                Console.WriteLine("No specific characters available to view");
                return;
                
            }
            Console.WriteLine("\nAvailable Characters:\n");
            foreach (var character in characters)
            {
                Console.WriteLine($"- {character.Key}");
            }
            Console.Write("\nEnter the name of the character you want to view: ");
            string characterName = Console.ReadLine();

            if (characters.ContainsKey(characterName))
            {
                Console.Clear();
                Console.WriteLine($"\n--- Character Info: {characterName} ---");
                Console.WriteLine(characters[characterName]);
            }
            else
            {
                Console.Clear();
                Console.WriteLine($"\nCharacter '{characterName}' not found.");
            }

            AskToGoBack();
        }

        private void DeleteCharacter()
        {
            while (true)
            {
                var characters = DatabaseHelper.GetAllCharacters().Result; 
                if (characters.Count == 0)
                {
                    Console.Clear();
                    Console.WriteLine("No characters available to delete.");
                    return;
                }

                Console.Clear();
                Console.WriteLine("\nAvailable characters to delete:");
                foreach (var character in characters)
                {
                    Console.WriteLine($"- {character.Key}");
                }

                Console.Write("\nEnter the name of the character to delete: ");
                string name = Console.ReadLine();

                if (!characters.ContainsKey(name))
                {
                    Console.WriteLine($"\nCharacter '{name}' not found. Please try again.");
                    Console.WriteLine("Press any key to input another valid name");
                    Console.ReadKey();
                    continue;
                }

                Console.WriteLine();
                Console.WriteLine($"Are you sure you want to delete the character '{name}'?");
                Console.WriteLine("[1] Yes");
                Console.WriteLine("[2] No");
                Console.Write(": ");
                string confirmation = Console.ReadLine();

                if (confirmation == "1")
                {
                    DatabaseHelper.DeleteCharacter(name).Wait();
                    Console.WriteLine($"Character '{name}' deleted successfully.");
                }
                else if (confirmation == "2")
                {
                    Console.WriteLine("Character deletion canceled.");
                }
                else
                {
                    Console.WriteLine("Invalid input. Returning to the menu.");
                }

                AskToGoBack();
                return;
            }
        }

        private void AskToGoBack()
        {
            while (true)
            {
                Console.WriteLine("\nDo you want to go back?");
                Console.WriteLine("[1] Yes");
                Console.WriteLine("[2] No");
                Console.Write(": ");
                string input = Console.ReadLine();

                if (input == "1")
                {
                    Console.Clear();
                    return;
                }
                else if (input == "2")
                {
                    Console.WriteLine("\nThanks for playing!");
                    Console.WriteLine("Press any key to exit.");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Invalid input. Please enter '1' or '2'.");
                }
            }
        }
    }

    // Inherited class with method overriding
    class CampaignMode : GameMode
    {
        public override void Start()
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

    // Credits class with overriding Start
    class Credits : GameMode
    {
        public override void Start()
        {
            Console.WriteLine("\n--- Credits ---");
            Console.WriteLine("Unidentified Society Game");
            Console.WriteLine();
            Console.WriteLine("Developed by:");
            Console.WriteLine("- Matthew Molina: Lead Programmer.");
            Console.WriteLine("- Lance Anthony Montierro: Co-Lead Programmer.");
            Console.WriteLine("- Jheshiro Jevs Macado: Documentation Specialist.");
            Console.WriteLine();
            Console.WriteLine("\nThank you for playing!");
        }
    }

    // NewGame class with method overriding and encapsulation
    class NewGame : GameMode
    {
        public override void Start()
        {
            try
            {
                Console.WriteLine("\nCreating your new alien...");
                new Pet();   
            }
            catch (Exception ex)
            {
                // Exception handling 
                Console.WriteLine($"An error occurred while creating your new alien: {ex.Message}");
            }
        }
    }
}