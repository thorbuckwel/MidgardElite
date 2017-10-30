using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Model
{
    public class GameWorld
    {
        #region Lists
        //public static readonly List<Monster> Monsters = new List<Monster>();    // To hold objects of Mobs
        //public static readonly List<NPC> NPCs = new List<NPC>();
        //public static readonly List<Weapon> Weapons = new List<Weapon>();       // To hold objects of weapons
        // public static readonly List<Item> Items = new List<Item>();              // To hold objects of Items
        // public static readonly List<Room> Location = new List<Room>();          // To hold objects of rooms 
        #endregion
        public static readonly List<Location> _locations = new List<Location>();


        public Location LocationAt(int zone, int xCord, int yCord)
        {
            foreach (Location room in _locations)
            {
                if (room.Zone == zone && room.XCord == xCord && room.YCord == yCord)
                {
                    return room;
                }
            }

            return null;
        }

        #region ByID, ByName

        /**
         * Searching code
         */
        #region Item
        //public static Item ItemByID(int id)
        //{
        //    return Items.SingleOrDefault(x => x.ID == id);
        //}
        //public static Item ItemByName(string name)
        //{
        //    return Items.SingleOrDefault(x => x.Name == name);
        //}
        #endregion

        #region Monster
        //public static Monster MonsterByID(int id)
        //{
        //    return Monsters.SingleOrDefault(x => x.ID == id);
        //}
        //public static Monster MonsterByName(string name)
        //{
        //    return Monsters.SingleOrDefault(x => x.Name == name);
        //}
        #endregion

        #region Weapon
        //public static Weapon WeaponByID(int id)
        //{
        //    return Weapons.SingleOrDefault(x => x.ID == id);
        //}
        //public static Weapon WeaponByName(string name)
        //{
        //    return Weapons.SingleOrDefault(x => x.Name == name);
        //}
        #endregion

        #region NPC
        //public static NPC NPCByID(int id)
        //{
        //    return NPCs.SingleOrDefault(x => x.ID == id);
        //}
        //public static NPC NPCByName(string name)
        //{
        //    return NPCs.SingleOrDefault(x => x.NPCName == name);
        //}
        //#endregion

        //#region Room
        //public static Room LocationByID(int id)
        //{
        //    return Location.SingleOrDefault(x => x.ID == id);
        //}
        #endregion

        #endregion
    }
}
