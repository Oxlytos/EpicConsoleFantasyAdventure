using System.Xml.Linq;

namespace AdventureGame.Models
{
    public class EntityRace
    {
        public string Name { get; set; }
        public string Sprite { get; set; }

    }

    public class Entitylist
    {
        Dictionary<int, EntityRace> entityList = new Dictionary<int, EntityRace>
        {
            {1, EntityRace {Name = "Warrior", Sprite = "W"  };
        };
    }




}
