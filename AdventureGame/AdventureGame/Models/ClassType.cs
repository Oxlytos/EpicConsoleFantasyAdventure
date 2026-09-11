using static AdventureGame.Models.EntityCollection;

namespace AdventureGame.Models
{
    public class ClassType
    {
        public ClassEnum classType { get; set; }
        public string Sprite { get; set; }
        public string DisplayMenuName => $"{classType}:  {Sprite}";

    }

    public class EntityCollection
    {
        public Dictionary<int, ClassType> EntityDictionary = new Dictionary<int, ClassType>
        {
            { 1, new ClassType { classType=ClassEnum.Warrior, Sprite = "💂‍" } },
            { 2, new ClassType { classType=ClassEnum.Wizard, Sprite = "🧙‍" } },
            { 3, new ClassType { classType=ClassEnum.Theif, Sprite = "🕵️" } },
            { 4, new ClassType { classType=ClassEnum.Robot, Sprite = "🤖" } }
        };

        public ClassType? getRace(int? id)
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
        public ClassEnum GetRaceEnum(int? id)
        {
            switch (id)
            {
                case null:
                    return ClassEnum.Invalid;
                case 0:
                    return ClassEnum.Invalid;
                case > 4:
                    return ClassEnum.Invalid;
                default:
                    return EntityDictionary[id.Value].classType;
            }
        }

        public enum ClassEnum
        {
            Invalid = 0,
            Warrior = 1,
            Wizard = 2,
            Theif = 3,
            Robot = 4
        }

    }

}




