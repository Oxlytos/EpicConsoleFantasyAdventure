using AdventureGame.Models;

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
        public static void PickName(Character character)
        {
            Console.WriteLine($"👲💬: 'Whatcha name, {character.Class.ClassTypeEnum}'?'");
            string input = Console.ReadLine();
            Console.WriteLine($"👲💬: 'Oh... it's {input}... intersting (They have a slight grin on their face)'");
            character.PlayerName = input;
        }
    }
}
