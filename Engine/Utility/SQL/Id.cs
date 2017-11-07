using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace Engine.Utility.SQL
{
    internal static class Id
    {
        internal static int DeterminePlayerId()
        {
            List<String> ids = new List<String>();
            int newID;
            string connetionString = null;
            connetionString = SqlCommands.ConnectionString;

            using (var connection = new SqlConnection(connetionString))
            {
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = SqlCommands.SelectAllPlayer;
                    connection.Open();

                    var reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string dbId = reader["Id"].ToString();
                        ids.Add(dbId);
                    }
                    connection.Close();
                                                      
                    newID = Int32.Parse(ids.Last()) + 1; ;    // Take the last Id and then add 1.
                }

                return newID;
            }
        }
    }
}
