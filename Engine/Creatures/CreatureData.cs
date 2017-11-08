using System.Collections.ObjectModel;
using Engine.Items;
using Engine.Utility;

namespace Engine.Creatures
{
    public class CreatureData
    {
        public int ArmorClass = 10, 
            Gold = 100, 
            ExperiencePoints = 0, 
            Zone = 1, 
            xCoord = 0,
            yCoord = 0;

        public int HitPoints = 0;
        public int MaxHitPoints = 0;
        public int MagicPoints = 0;
        public int MaxMagicPoints = 0;

        public bool IsAlive = true;
        public ObservableCollection<GameItem> Inventory = new ObservableCollection<GameItem>();

        public string Name = "";
        public string Description = "";

        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Agility { get; set; }
        public int Constitution { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }

        /// <summary>
        /// Rolls 3d6 for each stat.
        /// </summary>
        public void RollValuesForStats()
        {
            Strength = Random.NumberBetween(3, 18);
            Dexterity = Random.NumberBetween(3, 18);
            Agility = Random.NumberBetween(3, 18);
            Constitution = Random.NumberBetween(3, 18);
            Intelligence = Random.NumberBetween(3, 18);
            Wisdom = Random.NumberBetween(3, 18);
            Charisma = Random.NumberBetween(3, 18);
        }
    }
}
