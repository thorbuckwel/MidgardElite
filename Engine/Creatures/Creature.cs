using Engine.Creatures.Players;
using Engine.Creatures.Players.Classes;
using Engine.Items;
using System.Collections.ObjectModel;

namespace Engine.Creatures
{
    public class Creature
    {
        //public Creature(int id, int zone, string name, string description, int xp, int hp, int maxHp, int mp, int maxMp, int str, int dex, int agi,
        //                int con, int cint, int wis, int cha, int ac, bool isAlive, int gold, ObservableCollection<GameItem> inventory)
        //{
        //    ID = id;
        //    Zone = zone;
        //    Name = name;
        //    Description = description;
        //    ExperiencePoints = xp;
        //    HitPoints = hp;
        //    MaxHitPoints = maxHp;
        //    MagicPoints = mp;
        //    MaxMagicPoints = maxMp;

        //    #region Stats and Mods
        //    Strength = str;
        //    StrMod = Modifers.DetermineStatMod(Strength);
        //    Dexterity = dex;
        //    DexMod = Modifers.DetermineStatMod(Dexterity);
        //    Agility = agi;
        //    AgiMod = Modifers.DetermineStatMod(Agility);
        //    Constitution = con;
        //    ConMod = Modifers.DetermineStatMod(Constitution);
        //    Intelligence = cint;
        //    IntMod = Modifers.DetermineStatMod(Intelligence);
        //    Wisdom = wis;
        //    WisMod = Modifers.DetermineStatMod(Wisdom);
        //    Charisma = cha;
        //    ChaMod = Modifers.DetermineStatMod(Charisma);
        //    #endregion

        //    ArmorClass = ac;
        //    IsAlive = isAlive;
        //    Gold = gold;
        //    Inventory = inventory;
        //}

        //public Creature(int id, int zone, string name, string description, int xp, PlayerStats playerStats, int ac, bool isAlive, int gold, ObservableCollection<GameItem> inventory)
        //{
        //    ID = id;
        //    Zone = zone;
        //    Name = name;
        //    Description = description;
        //    ExperiencePoints = xp;
        //    HitPoints = playerStats.hp;
        //    MaxHitPoints = playerStats.maxHp;
        //    MagicPoints = playerStats.mp;
        //    MaxMagicPoints = playerStats.maxMp;

        //    #region Stats and Mods
        //    Strength = playerStats.str;
        //    StrMod = Modifers.DetermineStatMod(Strength);
        //    Dexterity = playerStats.dex;
        //    DexMod = Modifers.DetermineStatMod(Dexterity);
        //    Agility = playerStats.agi;
        //    AgiMod = Modifers.DetermineStatMod(Agility);
        //    Constitution = playerStats.con;
        //    ConMod = Modifers.DetermineStatMod(Constitution);
        //    Intelligence = playerStats.pInt;
        //    IntMod = Modifers.DetermineStatMod(Intelligence);
        //    Wisdom = playerStats.wis;
        //    WisMod = Modifers.DetermineStatMod(Wisdom);
        //    Charisma = playerStats.cha;
        //    ChaMod = Modifers.DetermineStatMod(Charisma);
        //    #endregion

        //    ArmorClass = ac;
        //    IsAlive = isAlive;
        //    Gold = gold;
        //    Inventory = inventory;
        //}

        internal Creature(int id, CreatureData creatureData)
        {
            ID = id;
            Zone = creatureData.Zone;
            Name = creatureData.Name;

            Description = creatureData.Description;
            ExperiencePoints = creatureData.ExperiencePoints;

            HitPoints = creatureData.HitPoints;
            MaxHitPoints = creatureData.MaxHitPoints;
            MagicPoints = creatureData.MagicPoints;
            MaxMagicPoints = creatureData.MaxMagicPoints;

            #region Stats and Mods
            Strength = creatureData.Strength;
            Dexterity = creatureData.Dexterity;
            Agility = creatureData.Agility;
            Constitution = creatureData.Constitution;
            Intelligence = creatureData.Intelligence;
            Wisdom = creatureData.Wisdom;
            Charisma = creatureData.Charisma;
            #endregion

            ArmorClass = creatureData.ArmorClass;
            IsAlive = creatureData.IsAlive;
            Gold = creatureData.Gold;
            Inventory = creatureData.Inventory;
        }

        #region Properties
        public int ID { get; set; }

        public int Zone { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }

        public int ExperiencePoints { get; set; }

        public int HitPoints { get; set; }
        public int MaxHitPoints { get; set; }
        public bool IsAlive { get; set; }

        public int MagicPoints { get; set; }
        public int MaxMagicPoints { get; set; }

        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Agility { get; set; }
        public int Constitution { get; set; }    
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }

        public int ArmorClass { get; set; }

        public int Fortitude { get; set; }
        public int Reflex { get; set; }
        public int Will { get; set; }
        public int BAB { get; set; }

        public int FortBS { get; set; }
        public int WillBS { get; set; }
        public int RefBS { get; set; }

        public int Gold { get; set; }

        public ObservableCollection<GameItem> Inventory { get; set; }

        #endregion

        protected int GetStatModifier(int statValue)
        {
            int mod = 0;

            if (statValue == 1)
                mod = -5;
            else if (statValue < 1 && statValue <= 3)
                mod = -4;
            else if (statValue < 3 && statValue <= 5)
                mod = -3;
            else if (statValue < 5 && statValue <= 7)
                mod = -2;
            else if (statValue < 7 && statValue <= 9)
                mod = -1;
            else if (statValue < 9 && statValue <= 11)
                mod = 0;
            else if (statValue < 11 && statValue <= 13)
                mod = 1;
            else if (statValue < 13 && statValue <= 15)
                mod = 2;
            else if (statValue < 15 && statValue <= 17)
                mod = 3;
            else if (statValue < 17 && statValue <= 19)
                mod = 4;
            else if (statValue < 19 && statValue <= 21)
                mod = 5;
            else if (statValue < 21 && statValue <= 23)
                mod = 6;
            else if (statValue < 23 && statValue <= 25)
                mod = 7;
            else if (statValue < 25 && statValue <= 27)
                mod = 8;
            else if (statValue < 27 && statValue <= 29)
                mod = 9;
            else if (statValue < 29 && statValue <= 31)
                mod = 10;
            else if (statValue < 31 && statValue <= 33)
                mod = 11;
            else if (statValue < 33 && statValue <= 35)
                mod = 12;
            else if (statValue < 35 && statValue <= 37)
                mod = 13;
            else if (statValue < 37 && statValue <= 39)
                mod = 14;
            else if (statValue < 39 && statValue <= 41)
                mod = 15;
            else if (statValue < 41 && statValue <= 43)
                mod = 16;
            else if (statValue < 43 && statValue <= 45)
                mod = 17;

            return mod;
        }
    }
}
