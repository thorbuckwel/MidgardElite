﻿namespace Engine.Utility.SQL
{
    internal static class SqlCommands
    {
        public static string connectionString = "Server = (local); Database = MidgardEliteWorld; Trusted_Connection = True;";

        public static string addNewPlayer = "INSERT into Players ([ID], [Name], [Zone], [Description], [Xp], [Hp], [MaxHp], [Mp], [MaxMp], " +
                      "[Str], [Dex], [Agi], [Con], [Int], [Wis], [Cha], [Ac], [Gold], [Race], [Class], " +
                      "[Inventory], [YCoord], [XCoord]) VALUES(@id, @name, @zone, @description, @xp, @hp, @maxHp, @mp, @maxMp, " +
                      "@str, @dex, @agi, @con, @int, @wis, @cha, @ac, @gold, @race, @class, @inventory, @yCoord, @xCoord)";

        public static string selectAllLocation = "SELECT* FROM Locations";

        public static string updatePlayer = "UPDATE Players SET ID=@id, Name=@name, Zone=@zone, Description=@description, Xp=@xp, Hp=@hp, MaxHp=@maxHp, Mp=@mp, MaxMp=@maxMp, " +
                      "Str=@str, Dex=@dex, Agi=@agi, Con=@con, Int=@int, Wis=@wis, Cha=@cha, Ac=@Ac, Gold=@gold, Race=@race, Class=@class, " +
                      "Inventory=@inventory, YCoord=@yCoord, XCoord=@xCoord" + " WHERE ID = @id";

        public static string selectAllPlayer = "SELECT * FROM Players";

        public static string selectSinglePlayer = "SELECT * FROM Players WHERE Name = @name";

        public static string ConnectionString { get { return connectionString; }  }
        public static string AddNewPlayer { get { return addNewPlayer; } }
        public static string UpdatePlayer { get { return updatePlayer; } }
        public static string SelectAllLocation { get { return selectAllLocation; } }
        public static string SelectAllPlayer { get { return selectAllPlayer; } }
    }
}
