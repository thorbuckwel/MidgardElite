using Engine.Class;
using Engine.Mod;
using System.Collections.ObjectModel;

namespace Engine.Model
{
    public class Creature
    {
        public Creature(int id, int zone, string name, string description, int xp, int hp, int maxHp, int mp, int maxMp, int str, int dex, int agi,
                        int con, int cint, int wis, int cha, int ac, bool isAlive, int gold, ObservableCollection<GameItem> inventory)
        {
            ID = id;
            Zone = zone;
            Name = name;
            Description = description;
            XP = xp;
            Hp = hp;
            MaxHp = maxHp;
            Mp = mp;
            MaxMp = maxMp;

            #region Stats and Mods
            Str = str;
            StrMod = Modifers.DetermineStatMod(Str);
            Dex = dex;
            DexMod = Modifers.DetermineStatMod(Dex);
            Agi = agi;
            AgiMod = Modifers.DetermineStatMod(Agi);
            Con = con;
            ConMod = Modifers.DetermineStatMod(Con);
            Int = cint;
            IntMod = Modifers.DetermineStatMod(Int);
            Wis = wis;
            WisMod = Modifers.DetermineStatMod(Wis);
            Cha = cha;
            ChaMod = Modifers.DetermineStatMod(Cha);
            #endregion

            Ac = ac;
            IsAlive = isAlive;
            Gold = gold;
            Inventory = inventory;
        }

        public Creature(int id, int zone, string name, string description, int xp, PlayerStats playerStats, int ac, bool isAlive, int gold, ObservableCollection<GameItem> inventory)
        {
            ID = id;
            Zone = zone;
            Name = name;
            Description = description;
            XP = xp;
            Hp = playerStats.hp;
            MaxHp = playerStats.maxHp;
            Mp = playerStats.mp;
            MaxMp = playerStats.maxMp;

            #region Stats and Mods
            Str = playerStats.str;
            StrMod = Modifers.DetermineStatMod(Str);
            Dex = playerStats.dex;
            DexMod = Modifers.DetermineStatMod(Dex);
            Agi = playerStats.agi;
            AgiMod = Modifers.DetermineStatMod(Agi);
            Con = playerStats.con;
            ConMod = Modifers.DetermineStatMod(Con);
            Int = playerStats.pInt;
            IntMod = Modifers.DetermineStatMod(Int);
            Wis = playerStats.wis;
            WisMod = Modifers.DetermineStatMod(Wis);
            Cha = playerStats.cha;
            ChaMod = Modifers.DetermineStatMod(Cha);
            #endregion

            Ac = ac;
            IsAlive = isAlive;
            Gold = gold;
            Inventory = inventory;
        }

        #region Player's Battle Stats
        public void DeterminePlayerBattleStats(ref Player _player)
        {
            Fortitude = ConMod;
            Reflex = DexMod;
            Will = WisMod;

            if (_player.PClass == "Barbarian")
            {
                BAB = Barbarian.DetermineBaB(ref _player);
                FortBS = Barbarian.DetermineFort(ref _player);
                RefBS = Barbarian.DetermineRefMod(ref _player);
                WillBS = Barbarian.DetermineWillMod(ref _player);
            }
            else if (_player.PClass == "Bard")
            {
                BAB = Bard.DetermineBaB(ref _player);
                FortBS = Bard.DetermineFort(ref _player);
                RefBS = Bard.DetermineRefMod(ref _player);
                WillBS = Bard.DetermineWillMod(ref _player);
            }
            else if (_player.PClass == "Cleric")
            {
                BAB = Cleric.DetermineBaB(ref _player);
                FortBS = Cleric.DetermineFort(ref _player);
                RefBS = Cleric.DetermineRefMod(ref _player);
                WillBS = Cleric.DetermineWillMod(ref _player);
            }
            else if (_player.PClass == "Druid")
            {
                BAB = Druid.DetermineBaB(ref _player);
                FortBS = Druid.DetermineFort(ref _player);
                RefBS = Druid.DetermineRefMod(ref _player);
                WillBS = Druid.DetermineWillMod(ref _player);
            }
            else if (_player.PClass == "Fighter")
            {
                BAB = Fighter.DetermineBaB(ref _player);
                FortBS = Fighter.DetermineFort(ref _player);
                RefBS = Fighter.DetermineRefMod(ref _player);
                WillBS = Fighter.DetermineWillMod(ref _player);
            }
            else if (_player.PClass == "Monk")
            {
                BAB = Monk.DetermineBaB(ref _player);
                FortBS = Monk.DetermineFort(ref _player);
                RefBS = Monk.DetermineRefMod(ref _player);
                WillBS = Monk.DetermineWillMod(ref _player);
            }
            else if (_player.PClass == "Paladin")
            {
                BAB = Paladin.DetermineBaB(ref _player);
                FortBS = Paladin.DetermineFort(ref _player);
                RefBS = Paladin.DetermineRefMod(ref _player);
                WillBS = Paladin.DetermineWillMod(ref _player);
            }
            else if (_player.PClass == "Ranger")
            {
                BAB = Ranger.DetermineBaB(ref _player);
                FortBS = Ranger.DetermineFort(ref _player);
                RefBS = Ranger.DetermineRefMod(ref _player);
                WillBS = Ranger.DetermineWillMod(ref _player);
            }
            else if (_player.PClass == "Rogue")
            {
                BAB = Rogue.DetermineBaB(ref _player);
                FortBS = Rogue.DetermineFort(ref _player);
                RefBS = Rogue.DetermineRefMod(ref _player);
                WillBS = Rogue.DetermineWillMod(ref _player);
            }
            else if (_player.PClass == "Sorcerer")
            {
                BAB = Sorcerer.DetermineBaB(ref _player);
                FortBS = Sorcerer.DetermineFort(ref _player);
                RefBS = Sorcerer.DetermineRefMod(ref _player);
                WillBS = Sorcerer.DetermineWillMod(ref _player);
            }
            else if (_player.PClass == "Wizard")
            {
                BAB = Wizard.DetermineBaB(ref _player);
                FortBS = Wizard.DetermineFort(ref _player);
                RefBS = Wizard.DetermineRefMod(ref _player);
                WillBS = Wizard.DetermineWillMod(ref _player);
            }

        }
        #endregion

        #region Properties
        public int ID { get; set; }
        public int Zone { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int XP { get; set; }
        public int Hp { get; set; }
        public int MaxHp { get; set; }
        public int Mp { get; set; }
        public int MaxMp { get; set; }
        public int Str { get; set; }
        public int StrMod { get; set; }
        public int Dex { get; set; }
        public int DexMod { get; set; }
        public int Agi { get; set; }
        public int AgiMod { get; set; }
        public int Con { get; set; }
        public int ConMod { get; set; }
        public int Int { get; set; }
        public int IntMod { get; set; }
        public int Wis { get; set; }
        public int WisMod { get; set; }
        public int Cha { get; set; }
        public int ChaMod { get; set; }
        public int Ac { get; set; }
        public int Fortitude { get; set; }
        public int Reflex { get; set; }
        public int Will { get; set; }
        public int BAB { get; set; }
        public bool IsAlive { get; set; }
        public int Gold { get; set; }
        public ObservableCollection<GameItem> Inventory { get; set; }
        public int FortBS { get; set; }
        public int WillBS { get; set; }
        public int RefBS { get; set; }
        #endregion
    }
}
