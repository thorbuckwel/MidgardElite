using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Engine.Model;

namespace MidgardElite.NewPlayer
{
    public static class CommonStats
    {
        public static int ac = 0, gold = 0, xp = 0, zone = 0, xCoord = 0, yCoord = 0;
        public static bool isAlive;
        public static ObservableCollection<GameItem> inventory;

        public static void Start()
        {
            zone = 1;
            xCoord = 0;
            yCoord = 0;
            ac = 10;
            gold = 100;
            xp = 0;
            isAlive = true;
            ObservableCollection<GameItem> inventory = new ObservableCollection<GameItem>();
        }
    }
}
