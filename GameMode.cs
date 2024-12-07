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
            //try
            //{
            //    Console.WriteLine("\nYour recenet Alienm character");
            //    await DatabaseHelper.SelectMostRecentCharacter();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"An error occurred while loading the game: {ex.Message}");
            //}
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
