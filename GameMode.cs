using System;

namespace UnidentifiedSociety
{
    abstract class GameMode
    {
        public abstract void Start();
    }

    class LoadGame : GameMode
    {
        public override void Start()
        {
            Console.WriteLine("\nPlace holder palang po!");
        }
    }
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
    class Credits : GameMode
    {
        public override void Start()
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

    class NewGame : GameMode
    {
        public override void Start()
        {
            new Pet(); 
        }
    }
}
