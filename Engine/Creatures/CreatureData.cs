using System.Collections.ObjectModel;
using Engine.Items;

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
        public bool isAlive = true;
        public ObservableCollection<GameItem> inventory = new ObservableCollection<GameItem>();

        public string Name = "";
        public string Description = "";
    }
}
