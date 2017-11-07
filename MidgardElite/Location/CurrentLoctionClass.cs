using Engine.Session;
using System;
using System.Linq;

namespace MidgardElite.Location
{
    public static class CurrentLocationClass
    {
        public static string _currentExits;

        #region DisplayCurrentLocation
        public static void DisplayCurrentLocation()
        {

            Console.WriteLine("You are at: {0}", GameSession.CurrentLocation.Name);

            if (GameSession.CurrentLocation.Description != "")
            {
                Console.WriteLine(GameSession.CurrentLocation.Description);
            }

            #region Display Exits
            Console.ForegroundColor = ConsoleColor.Green;
            int count = 1;
            _currentExits = "";

            foreach (string e in GameSession.CurrentLocation.Exits)
            {
                #region Assign Full Exit Name
                if (e == "N")
                {
                    _currentExits = _currentExits + "North";
                }
                else if (e == "E")
                {
                    _currentExits = _currentExits + "East";
                }
                else if (e == "S")
                {
                    _currentExits = _currentExits + "South";
                }
                else if (e == "W")
                {
                    _currentExits = _currentExits + "West";
                }
                #endregion

                if (count < GameSession.CurrentLocation.Exits.Count())
                    _currentExits = _currentExits + ", ";
                count++;
            }
            Console.WriteLine("[" + _currentExits + "]");
            Console.ForegroundColor = ConsoleColor.White;
            #endregion
        }

        public static void DisplayBadExit()
        {
            Console.WriteLine("You can't go that way!");
        }         


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

