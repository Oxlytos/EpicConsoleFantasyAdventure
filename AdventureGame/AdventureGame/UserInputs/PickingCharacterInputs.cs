using AdventureGame.Models;

namespace AdventureGame.UserInputs
{
    public static class PickingCharacterInputs
    {
        public static ClassType PickRace()
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
                selectedCharScoped = selectedChar;
            }
            var thisClass = championList.EntityDictionary[selectedCharScoped];
            Console.WriteLine("You chose: " + thisClass.DisplayMenuName + "!");
            return thisClass;

        }
    }
}
