using Engine.Creatures.Players.Classes;
using Engine.Items;
using System.Collections.ObjectModel;

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
        }

        public string Race { get; set; }
        public string Class { get; set; }

        public int Level { get; set; }

        public int XCoord { get; set; }
        public int YCoord { get; set; }

        #region Player's Battle Stats
        public void DeterminePlayerBattleStats()
        {
            Fortitude = GetStatModifier(Constitution);
            Reflex = GetStatModifier(Dexterity);
            Will = GetStatModifier(Wisdom);
            
            if (Class == "Barbarian")
            {
                BAB = Barbarian.DetermineBaB(this);
                FortBS = Barbarian.DetermineFort(this);
                RefBS = Barbarian.DetermineRefMod(this);
                WillBS = Barbarian.DetermineWillMod(this);
            }
            else if (Class == "Bard")
            {
                BAB = Bard.DetermineBaB(this);
                FortBS = Bard.DetermineFort(this);
                RefBS = Bard.DetermineRefMod(this);
                WillBS = Bard.DetermineWillMod(this);
            }
            else if (Class == "Cleric")
            {
                BAB = Cleric.DetermineBaB(this);
                FortBS = Cleric.DetermineFort(this);
                RefBS = Cleric.DetermineRefMod(this);
                WillBS = Cleric.DetermineWillMod(this);
            }
            else if (Class == "Druid")
            {
                BAB = Druid.DetermineBaB(this);
                FortBS = Druid.DetermineFort(this);
                RefBS = Druid.DetermineRefMod(this);
                WillBS = Druid.DetermineWillMod(this);
            }
            else if (Class == "Fighter")
            {
                BAB = Fighter.DetermineBaB(this);
                FortBS = Fighter.DetermineFort(this);
                RefBS = Fighter.DetermineRefMod(this);
                WillBS = Fighter.DetermineWillMod(this);
            }
            else if (Class == "Monk")
            {
                BAB = Monk.DetermineBaB(this);
                FortBS = Monk.DetermineFort(this);
                RefBS = Monk.DetermineRefMod(this);
                WillBS = Monk.DetermineWillMod(this);
            }
            else if (Class == "Paladin")
            {
                BAB = Paladin.DetermineBaB(this);
                FortBS = Paladin.DetermineFort(this);
                RefBS = Paladin.DetermineRefMod(this);
                WillBS = Paladin.DetermineWillMod(this);
            }
            else if (Class == "Ranger")
            {
                BAB = Ranger.DetermineBaB(this);
                FortBS = Ranger.DetermineFort(this);
                RefBS = Ranger.DetermineRefMod(this);
                WillBS = Ranger.DetermineWillMod(this);
            }
            else if (Class == "Rogue")
            {
                BAB = Rogue.DetermineBaB(this);
                FortBS = Rogue.DetermineFort(this);
                RefBS = Rogue.DetermineRefMod(this);
                WillBS = Rogue.DetermineWillMod(this);
            }
            else if (Class == "Sorcerer")
            {
                BAB = Sorcerer.DetermineBaB(this);
                FortBS = Sorcerer.DetermineFort(this);
                RefBS = Sorcerer.DetermineRefMod(this);
                WillBS = Sorcerer.DetermineWillMod(this);
            }
            else if (Class == "Wizard")
            {
                BAB = Wizard.DetermineBaB(this);
                FortBS = Wizard.DetermineFort(this);
                RefBS = Wizard.DetermineRefMod(this);
                WillBS = Wizard.DetermineWillMod(this);
            }

        }
        #endregion

    }
}
