using Engine.Creatures.Players.Classes;

namespace Engine.Creatures.Players
{
    public class Player : Creature
    {
        //[System.Obsolete]
        //public Player(int id, int zone, string name, string race, string pClass, string description, int xp, int hp, int maxHp, int mp, int maxMp, int str, int dex, int agi,
        //                int con, int cint, int wis, int cha, int ac, bool isAlive, int gold, ObservableCollection<GameItem> inventory, int xCoord, int yCoord) :
        //                                                                            base(id, zone, name, description, xp, hp, maxHp, mp, maxMp, str, dex,
        //                                                                                  agi, con, cint, wis, cha, ac, isAlive, gold, inventory)
        //{
        //    Race = race;
        //    Class = pClass;
        //    Level = Tables.DetermineLevel(xp);
        //    XCoord = xCoord;
        //    YCoord = yCoord;
        //}
        //
        //public Player(int id, int zone, string name, string race, string pClass, string description, int xp, PlayerStats playerStats, int ac, bool isAlive, int gold, ObservableCollection<GameItem> inventory, int xCoord, int yCoord) :
        //             base(id, zone, name, description, xp, playerStats, ac, isAlive, gold, inventory)
        //{
        //    Race = race;
        //    Class = pClass;
        //    Level = Tables.DetermineLevel(xp);
        //    XCoord = xCoord;
        //    YCoord = yCoord;
        //}

        internal Player(int id, PlayerData playerStats) : base (id, playerStats as CreatureData)
        {
            Race = playerStats.Race;
            Class = playerStats.Class;
            Level = Tables.DetermineLevel(playerStats.ExperiencePoints);
            XCoord = playerStats.xCoord;
            YCoord = playerStats.yCoord;

            PlayerClass = PlayerClassFactory.GetPlayerClass(Class);
        }

        public string Race { get; set; }
        public string Class { get; set; }
        internal IPlayerClass PlayerClass;

        public int Level { get; set; }

        public int XCoord { get; set; }
        public int YCoord { get; set; }

        #region Player's Battle Stats
        public void DeterminePlayerBattleStats()
        {
            Fortitude = GetStatModifier(Constitution);
            Reflex = GetStatModifier(Dexterity);
            Will = GetStatModifier(Wisdom);

            //Assign values based on Player's Level and Class
            BaseAttackBonus = PlayerClass.GetClassBaseAttackBonus(Level);
            FortBS = PlayerClass.GetClassFortitudeModifier(Level);
            RefBS = PlayerClass.GetClassReflexModifier(Level);
            WillBS = PlayerClass.GetClassWillModifier(Level);

        }
        #endregion

    }
}
