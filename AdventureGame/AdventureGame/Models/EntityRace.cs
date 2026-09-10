namespace AdventureGame.Models
{
    public class EntityRace
    {
        public string Name { get; set; }
        public string Sprite { get; set; }
        public string DisplayMenuName => $"{Name}:  {Sprite}";

    }

    public class Entitylist
    {
        public Dictionary<int, EntityRace> EntityList = new Dictionary<int, EntityRace>
        {
            { 1, new EntityRace { Name = "Warrior", Sprite = "💂‍" } },
            { 2, new EntityRace { Name = "Wizard", Sprite = "🧙‍" } },
            { 3, new EntityRace { Name = "Thief", Sprite = "🕵️" } },
            { 4, new EntityRace { Name = "Robot", Sprite = "🤖" } }
        };
    }

}
