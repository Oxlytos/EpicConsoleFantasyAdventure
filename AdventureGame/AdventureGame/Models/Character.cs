namespace AdventureGame.Models
{
    public class Character
    {
        public int Name { get; set; }
        public int RaceId { get; set; }

        public EntityRace Race { get; set; }
    }





}
