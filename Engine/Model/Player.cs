using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Table;

namespace Engine.Model
{
    public class Player : Creature
    {
        public Player (int id, int zone, string name, string race, string pClass, string description, int xp, int hp, int mp, int str, int dex, int agi,
                        int con, int cint, int wis, int cha, int ac, char isAlive, int gold, ObservableCollection<GameItem> inventory):
                                                                                    base (id, zone, name, description, xp, hp, mp, str, dex, 
                                                                                          agi, con, cint, wis, cha, ac, isAlive, gold, inventory)
        {
            Race = race;
            PClass = pClass;
            Level = Table.Tables.DetermineLevel(xp);
        }

        public string Race { get; set; }
        public string PClass { get; set; }
        public int Level { get; set; }
    }
}
