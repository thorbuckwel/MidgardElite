﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Engine.Sql
{
    public static class Id
    {
        public static int DeterminePlayerId()
        {
            List<String> ids = new List<String>();
            int newID;
            int IDs = 0;
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

                    int index = ids.Count - 1;
                    newID = Int32.Parse(ids[index]) + 1;

                }

                return newID;
            }
        }
    }
}