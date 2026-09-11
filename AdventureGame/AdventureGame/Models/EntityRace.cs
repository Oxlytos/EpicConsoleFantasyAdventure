using static AdventureGame.Models.EntityCollection;

namespace AdventureGame.Models
{
    public class EntityRace
    {
        public EntityEnum EntityType { get; set; }
        public string Sprite { get; set; }
        public string DisplayMenuName => $"{EntityType}:  {Sprite}";

    }

    public class EntityCollection
    {
        public Dictionary<int, EntityRace> EntityDictionary = new Dictionary<int, EntityRace>
        {
            { 1, new EntityRace { EntityType=EntityEnum.Warrior, Sprite = "💂‍" } },
            { 2, new EntityRace { EntityType=EntityEnum.Wizard, Sprite = "🧙‍" } },
            { 3, new EntityRace { EntityType=EntityEnum.Theif, Sprite = "🕵️" } },
            { 4, new EntityRace { EntityType=EntityEnum.Robot, Sprite = "🤖" } }
        };

        public EntityRace? getRace(int? id)
        {
            switch (id)
            {
                case null:
                    return null;
                case 0:
                    return null;
                case > 4:
                    return null;
                default:
                    return EntityDictionary[id.Value];
            }
        }
        public EntityEnum GetRaceEnum(int? id)
        {
            switch (id)
            {
                case null:
                    return EntityEnum.Invalid;
                case 0:
                    return EntityEnum.Invalid;
                case > 4:
                    return EntityEnum.Invalid;
                default:
                    return EntityDictionary[id.Value].EntityType;
            }
        }

        public enum EntityEnum
        {
            Invalid =0,
            Warrior = 1,
            Wizard = 2,
            Theif = 3,
            Robot = 4
        }

    }

}




