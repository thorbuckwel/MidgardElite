using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Model;
using Engine.ViewModels;
using MidgardElite.Location;
using Engine.Searches;

namespace MidgardElite.Commands
{
    public class Command
    {
        public static void CommandCase(string input, Player _player, GameSession _gamesession)
        {
            string[] commands = input.Split(null);
            string verb = commands[0].ToLower();
            string noun;
            if (commands.Length != 1)
            {
                noun = commands[1];
            }
            else
            {
                noun = "";
            }

            NormalCommands(verb, noun, _gamesession);
        }

        public static void NormalCommands(string verb, string noun, GameSession _gameSession)
        {          
            switch (verb)
            {
                case "look":
                    //if (noun != "")
                    //{
                    //    Look.Looking(noun);
                    //}
                    //else
                    //{
                     Look.Looking();
                    //}
                    break;
                case "help":
                    //HelpFile.HelpInfo();
                    break;
                case "score":
                    //Score.Stats(Player._player);
                    break;
                case "get":
                    //Get.GetCommand(noun, Player._player);
                    break;
                case "north":
                    _gameSession.MoveNorth();
                    CurrentLocationClass.DisplayCurrentLocation();                    
                    break;
                case "east":
                    _gameSession.MoveEast();
                    CurrentLocationClass.DisplayCurrentLocation();
                    break;
                case "south":
                    _gameSession.MoveSouth();
                    CurrentLocationClass.DisplayCurrentLocation();
                    break;
                case "west":
                    _gameSession.MoveWest();
                    CurrentLocationClass.DisplayCurrentLocation();
                    break;
                case "inventory":
                    //Inventory.Inv(Player._player);
                    break;
                case "attack":
                    //Attack.Attacking(noun, Player._player);
                    break;
                case "drop":
                    //ItemDrop.Drop(noun, Player._player);
                    break;
                case "equip":
                    //Equipt.Equip(noun, Player._player);
                    break;
                case "save":
                    //SaveData.SaveGameData(Player._player);
                    break;
                case "enter":
                    if (verb != null)
                        WorldSearch.GetTeleportLocation(noun);
                    CurrentLocationClass.DisplayCurrentLocation();
                    break;
            }
        }

        public static void AdminCommands(string verb, string noun, GameSession _gameSession)
        {
            switch (verb)
            {
                case "create":
                    //Create.WhatToCreate();
                    break;
                case "spawn":
                    //Spawn.WhatToSpawn();
                    break;
                default:
                    NormalCommands(verb, noun, _gameSession);
                    break;

            }
        }
    }
}
