using Engine.Model;
using Engine.ViewModels;
using System.Data.SqlClient;
using Engine.Sql;

namespace Engine.WorldSave
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
                    cmd.Parameters.AddWithValue("@xp", _player.XP);
                    cmd.Parameters.AddWithValue("@hp", _player.Hp);
                    cmd.Parameters.AddWithValue("@maxHp", _player.MaxHp);
                    cmd.Parameters.AddWithValue("@mp", _player.Mp);
                    cmd.Parameters.AddWithValue("@maxMp", _player.MaxMp);
                    cmd.Parameters.AddWithValue("@str", _player.Str);
                    cmd.Parameters.AddWithValue("@dex", _player.Dex);
                    cmd.Parameters.AddWithValue("@agi", _player.Agi);
                    cmd.Parameters.AddWithValue("@con", _player.Con);
                    cmd.Parameters.AddWithValue("@int", _player.Int);
                    cmd.Parameters.AddWithValue("@wis", _player.Wis);
                    cmd.Parameters.AddWithValue("@cha", _player.Cha);
                    cmd.Parameters.AddWithValue("@ac", _player.Ac);
                    cmd.Parameters.AddWithValue("@gold", _player.Gold);
                    cmd.Parameters.AddWithValue("@race", _player.Race);
                    cmd.Parameters.AddWithValue("@class", _player.PClass);
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
                    command.Parameters.AddWithValue("@xp", _player.XP);
                    command.Parameters.AddWithValue("@hp", _player.Hp);
                    command.Parameters.AddWithValue("@maxHp", _player.MaxHp);
                    command.Parameters.AddWithValue("@mp", _player.Mp);
                    command.Parameters.AddWithValue("@maxMp", _player.MaxMp);
                    command.Parameters.AddWithValue("@str", _player.Str);
                    command.Parameters.AddWithValue("@dex", _player.Dex);
                    command.Parameters.AddWithValue("@agi", _player.Agi);
                    command.Parameters.AddWithValue("@con", _player.Con);
                    command.Parameters.AddWithValue("@int", _player.Int);
                    command.Parameters.AddWithValue("@wis", _player.Wis);
                    command.Parameters.AddWithValue("@cha", _player.Cha);
                    command.Parameters.AddWithValue("@ac", _player.Ac);
                    command.Parameters.AddWithValue("@gold", _player.Gold);
                    command.Parameters.AddWithValue("@race", _player.Race);
                    command.Parameters.AddWithValue("@class", _player.PClass);
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
