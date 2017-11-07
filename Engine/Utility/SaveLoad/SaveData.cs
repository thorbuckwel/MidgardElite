using System.Data.SqlClient;
using Engine.Creatures.Players;
using Engine.Utility.SQL;
using Engine.Session;

namespace Engine.Utility.SaveLoad
{
    public static class SaveData
    {
        public static void SavePlayer(Player _player)
        {
            string connetionString = null;
            connetionString = SqlCommands.ConnectionString;

            using (SqlConnection cnn = new SqlConnection(connetionString))
            {
                string sql = SqlCommands.AddNewPlayer;
                cnn.Open();

                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    #region AddWithValue
                    cmd.Parameters.AddWithValue("@id", _player.ID.ToString());
                    cmd.Parameters.AddWithValue("@name", _player.Name);
                    cmd.Parameters.AddWithValue("@zone", _player.Zone);
                    cmd.Parameters.AddWithValue("@description", _player.Description);
                    cmd.Parameters.AddWithValue("@xp", _player.ExperiencePoints);
                    cmd.Parameters.AddWithValue("@hp", _player.HitPoints);
                    cmd.Parameters.AddWithValue("@maxHp", _player.MaxHitPoints);
                    cmd.Parameters.AddWithValue("@mp", _player.MagicPoints);
                    cmd.Parameters.AddWithValue("@maxMp", _player.MaxMagicPoints);
                    cmd.Parameters.AddWithValue("@str", _player.Strength);
                    cmd.Parameters.AddWithValue("@dex", _player.Dexterity);
                    cmd.Parameters.AddWithValue("@agi", _player.Agility);
                    cmd.Parameters.AddWithValue("@con", _player.Constitution);
                    cmd.Parameters.AddWithValue("@int", _player.Intelligence);
                    cmd.Parameters.AddWithValue("@wis", _player.Wisdom);
                    cmd.Parameters.AddWithValue("@cha", _player.Charisma);
                    cmd.Parameters.AddWithValue("@ac", _player.ArmorClass);
                    cmd.Parameters.AddWithValue("@gold", _player.Gold);
                    cmd.Parameters.AddWithValue("@race", _player.Race);
                    cmd.Parameters.AddWithValue("@class", _player.Class);
                    cmd.Parameters.AddWithValue("@inventory", _player.Inventory.ToString());
                    cmd.Parameters.AddWithValue("@yCoord", _player.YCoord);
                    cmd.Parameters.AddWithValue("@xCoord", _player.XCoord);
                    #endregion

                    cmd.ExecuteNonQuery();
                }
                cnn.Close();
            }
        }

        public static void UpdatePlayer(Player _player)
        {
            string connetionString = null;
            connetionString = SqlCommands.ConnectionString;

            using (SqlConnection connection = new SqlConnection(connetionString))
            {
                using (var command = connection.CreateCommand())
                {
                    connection.Open();
                    command.CommandText = SqlCommands.selectSinglePlayer;
                    command.Parameters.AddWithValue("@name", GameSession.CurrentPlayer.Name);
                    
                    var reader = command.ExecuteReader();

                    #region AddWithValue
                    command.Parameters.AddWithValue("@id", _player.ID.ToString());
                    command.Parameters.AddWithValue("@name", _player.Name);
                    command.Parameters.AddWithValue("@zone", _player.Zone);
                    command.Parameters.AddWithValue("@description", _player.Description);
                    command.Parameters.AddWithValue("@xp", _player.ExperiencePoints);
                    command.Parameters.AddWithValue("@hp", _player.HitPoints);
                    command.Parameters.AddWithValue("@maxHp", _player.MaxHitPoints);
                    command.Parameters.AddWithValue("@mp", _player.MagicPoints);
                    command.Parameters.AddWithValue("@maxMp", _player.MaxMagicPoints);
                    command.Parameters.AddWithValue("@str", _player.Strength);
                    command.Parameters.AddWithValue("@dex", _player.Dexterity);
                    command.Parameters.AddWithValue("@agi", _player.Agility);
                    command.Parameters.AddWithValue("@con", _player.Constitution);
                    command.Parameters.AddWithValue("@int", _player.Intelligence);
                    command.Parameters.AddWithValue("@wis", _player.Wisdom);
                    command.Parameters.AddWithValue("@cha", _player.Charisma);
                    command.Parameters.AddWithValue("@ac", _player.ArmorClass);
                    command.Parameters.AddWithValue("@gold", _player.Gold);
                    command.Parameters.AddWithValue("@race", _player.Race);
                    command.Parameters.AddWithValue("@class", _player.Class);
                    command.Parameters.AddWithValue("@inventory", _player.Inventory);
                    command.Parameters.AddWithValue("@yCoord", _player.YCoord);
                    command.Parameters.AddWithValue("@xCoord", _player.XCoord);
                    #endregion
                }
                connection.Close();
            }
        }
    }
}
