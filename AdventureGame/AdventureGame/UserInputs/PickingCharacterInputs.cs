using AdventureGame.Extensions;
using AdventureGame.Models;
using System.Text.RegularExpressions;

namespace AdventureGame.UserInputs
{
    public static class PickingCharacterInputs
    {
        public static void PickRace(Character character)
        {
            Console.WriteLine("🫃");
            Console.WriteLine("Pick a race");
            EntityCollection championList = new EntityCollection();
            foreach (var charachter in championList.EntityDictionary)
            {
                Console.WriteLine(charachter.Key + "  " +
                charachter.Value.DisplayMenuName);
            }
            bool userPickInpuit = true;
            int selectedCharScoped = 0;
            while (userPickInpuit)
            {
                int.TryParse(Console.ReadLine(), out int selectedChar);
                var classtype = championList.GetRaceEnum(selectedChar);

                if (classtype is EntityCollection.ClassEnum.Invalid)
                {
                    Console.WriteLine("Wrong input");
                }
                else
                {
                    userPickInpuit = false;
                }
                selectedCharScoped = selectedChar;
            }
            var thisClass = championList.EntityDictionary[selectedCharScoped];
            Console.WriteLine("You chose: " + thisClass.DisplayMenuName + "!");
            character.Class =  thisClass;

        }
        public static string PickName(Character character )
        {
            Console.WriteLine($"👲💬: 'Whatcha name, {character.Class.ClassTypeEnum}'?'");
            //Console.WriteLine($"👲💬: 'Whatcha name, lardface'?'");
            string input = Console.ReadLine();
            bool result = ValidatePlayerName(input);
            if( result)
            {
                input = input.Capitalize();
                Console.WriteLine($"👲💬: 'Oh... it's {input}... intersting (They have a slight grin on their face)'");
                return input;
            }
            else
            {
                Console.WriteLine($"👲💬: 'I can't say that, that's gibberish! I'm calling you Jeff'");
                return "Jeff";
            }
            
           
        }
        public static bool ValidatePlayerName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return false;
            }
            Regex namePattern = new Regex(@"^([a-z]{3,15})$");

            return namePattern.IsMatch(name.ToLower());

        }
    }
}
