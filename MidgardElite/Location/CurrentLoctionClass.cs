using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Model;
using Engine.ViewModels;

namespace MidgardElite.Location
{
    public static class CurrentLocationClass
    {
        #region DisplayCurrentLocation
        public static void DisplayCurrentLocation()
        {

            Console.WriteLine("You are at: {0}", GameSession.CurrentLocation.Name);

            if (GameSession.CurrentLocation.Description != "")
            {
                Console.WriteLine(GameSession.CurrentLocation.Description);
            }

            //Console.ForegroundColor = ConsoleColor.Green;
            //string exits = "\n[Exits: ";
            //Console.Write("[Exits: ");
            //List<string> validExits = new List<string>();
            //if (Player.CurrentLocation.LocationToNorth != -1)
            //    validExits.Add("north");
            //if (Player.CurrentLocation.LocationToEast != -1)
            //    validExits.Add("east");
            //if (Player.CurrentLocation.LocationToSouth != -1)
            //    validExits.Add("south");
            //if (Player.CurrentLocation.LocationToWest != -1)
            //    validExits.Add("west");
            //if (validExits.Count == 1)
            //    exits += validExits[0] + " ";
            //else
            //{
            //    for (int i = 0; i < validExits.Count; i++)
            //    {
            //        exits += validExits[i];
            //        if (i < validExits.Count - 1)
            //            exits += ", ";
            //    }
            //}


            //etc
            //if (Player.CurrentLocation.LocationToNorth != -1)
            //    exits += "north ";
            //if (Player.CurrentLocation.LocationToEast != -1)
            //    exits += "east ";
            //if (Player.CurrentLocation.LocationToSouth != -1)
            //    exits += "south ";
            //if (Player.CurrentLocation.LocationToWest != -1)
            //    exits += "west ";

        //    Console.WriteLine(exits + "]");


        //    if (Player.CurrentLocation.RoomLoot != null)
        //    {
        //        Console.ForegroundColor = ConsoleColor.Gray;
        //        foreach (Item item in Player.CurrentLocation.RoomLoot)
        //        {
        //            Console.WriteLine("      " + item.Name);
        //        }
        //        Console.ForegroundColor = ConsoleColor.White;
        //    }

        //    if (Player.CurrentLocation.RoomMob != null)
        //    {
        //        Console.ForegroundColor = ConsoleColor.Yellow;
        //        foreach (Monster mob in Player.CurrentLocation.RoomMob)
        //        {
        //            if (mob.ID != 5)
        //            {

        //                Player.CurrentMonster = mob;

        //                Console.ForegroundColor = ConsoleColor.Yellow;
        //                Console.WriteLine("A " + mob.Name + " is wondering around here.");
        //                Console.ForegroundColor = ConsoleColor.White;
        //            }
        //            else
        //            {
        //                Player.CurrentMonster = mob;
        //                Console.WriteLine("");
        //                Console.ForegroundColor = ConsoleColor.Yellow;
        //                Console.WriteLine(" A large " + mob.Name + " fills the room with its massive body.");
        //                Console.ForegroundColor = ConsoleColor.White;
        //            }
        //        }
        //        Console.ForegroundColor = ConsoleColor.White;
        //    }

        //    if (Player.CurrentLocation.RmNPC != null)
        //    {
        //        Console.ForegroundColor = ConsoleColor.Green;
        //        foreach (NPC npc in Player.CurrentLocation.RmNPC)
        //        {
        //            if (npc.ID == 601)
        //            {

        //                Player.CurrentNPC = npc;

        //                Console.WriteLine("");
        //                Console.WriteLine(" A " + npc.NPCName + " is slamming puts around.");
        //                Console.ForegroundColor = ConsoleColor.White;
        //            }
        //            else if (npc.ID == 602)
        //            {
        //                Player.CurrentNPC = npc;
        //                Console.WriteLine("");
        //                Console.WriteLine(" A " + npc.NPCName + " Cracks a whip here.");
        //                Console.ForegroundColor = ConsoleColor.White;
        //            }
        //        }
        //        Console.ForegroundColor = ConsoleColor.White;
        //    }
        }
        #endregion
    }
}
