using Engine.Creatures.Players;
using System;

namespace MidgardElite.Commands
{
    public static class Score
    {
        public static void Stats(Player _player)
        {
            Console.WriteLine("Player Name: " + _player.Name);
            Console.WriteLine("Player Class: " + _player.Class);
            Console.WriteLine("Player Race: " + _player.Race);
            Console.WriteLine("Current hit points: {0}", _player.HitPoints);
            Console.WriteLine("Maximum hit points: {0}", _player.MaxHitPoints);
            Console.WriteLine("Experience Points: {0}", _player.ExperiencePoints);
            Console.WriteLine("Level: {0}", _player.Level);
            Console.WriteLine("Gold: {0}", _player.Gold);
            //Console.WriteLine("Faction: {0}", _player.Factions);
            //Console.WriteLine("Alignment: {0}", _player.Alignment);
        }
    }
}
