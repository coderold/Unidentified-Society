using System;
using System.Threading.Tasks;
using Firebase.Database;
using Firebase.Database.Query;

namespace UnidentifiedSociety
{
    static class DatabaseHelper
    {
        private static readonly FirebaseClient firebaseClient = new FirebaseClient("https://alien-7b6aa-default-rtdb.firebaseio.com/");


        public static async Task InsertCharacter(string name, PhysicalAttributes physicalAttributes, AppearanceAttributes appearanceAttributes, OtherAttributes otherAttributes)
        {
            await firebaseClient
                .Child("Characters")
                .Child(name)
                .PutAsync(new
                {
                    Name = name,
                    PhysicalAttributes = physicalAttributes,
                    AppearanceAttributes = appearanceAttributes,
                    OtherAttributes = otherAttributes
                });
            Console.WriteLine("Character saved successfully!");

           
        }



        public static async Task SelectAllCharacters()
        {
            var characters = await firebaseClient
                .Child("Characters")
                .OnceAsync<object>();

            foreach (var character in characters)
            {
                Console.WriteLine(character.Key);
                Console.WriteLine(character.Object.ToString());
                Console.WriteLine("----------------------------");
            }
        }



        public static async Task<Dictionary<string, object>> GetAllCharacters()
        {
            var characters = await firebaseClient
                .Child("Characters")
                .OnceAsync<object>();

            return characters.ToDictionary(c => c.Key, c => c.Object);
        }


        // revisions:-character name --"Character name already taken"
        public static async Task<bool> IsCharacterNameTaken(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                return false;

            var characters = await firebaseClient
                .Child("Characters")
                .OnceAsync<object>();

            return characters.Any(c => c.Key.Equals(name, StringComparison.OrdinalIgnoreCase));
        }



        // confrimation 
        public static async Task DeleteCharacter(string name)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(name))
                {
                    Console.WriteLine("Error: Character name cannot be empty.");
                    return;
                }

                var character = await firebaseClient
                    .Child("Characters")
                    .Child(name)
                    .OnceSingleAsync<object>();

                if (character == null)
                {
                    Console.WriteLine($"Error: Character with the name '{name}' does not exist in the database.");
                    return;
                }

                await firebaseClient
                    .Child("Characters")
                    .Child(name)
                    .DeleteAsync();

             
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while deleting the character: {ex.Message}");
            }
        }
    }
}

        

    

