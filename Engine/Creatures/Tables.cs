using Engine.Creatures.Players;

namespace Engine.Creatures
{
    public static class Tables
    {
        /*
         * This Method will be used through out the game after the player
         * object has been built.
         */
          
        public static void DetermineLevel(ref Player _player)
        {
            if (_player.XP < 3000)
                _player.Level = 1;
            else if (_player.XP < 7500)
                _player.Level = 2;
            else if (_player.XP < 14000)
                _player.Level = 3;
            else if (_player.XP < 23000)
                _player.Level = 4;
            else if (_player.XP < 35000)
                _player.Level = 5;
            else if (_player.XP < 53000)
                _player.Level = 6;
            else if (_player.XP < 77000)
                _player.Level = 7;
            else if (_player.XP < 115000)
                _player.Level = 8;
            else if (_player.XP < 160000)
                _player.Level = 9;
            else if (_player.XP < 235000)
                _player.Level = 10;
            else if (_player.XP < 330000)
                _player.Level = 11;
            else if (_player.XP < 475000)
                _player.Level = 12;
            else if (_player.XP < 665000)
                _player.Level = 13;
            else if (_player.XP < 955000)
                _player.Level = 14;
            else if (_player.XP < 1350000)
                _player.Level = 15;
            else if (_player.XP < 1900000)
                _player.Level = 16;
            else if (_player.XP < 2700000)
                _player.Level = 17;
            else if (_player.XP < 3850000)
                _player.Level = 18;
            else if (_player.XP < 5350000)
                _player.Level = 19;
            else if (_player.XP < 8000000)
                _player.Level = 20;
        }

        /*
         * This is needed when building the player for the first time.
         */

        public static int DetermineLevel(int xp)
        {
            if (xp < 3000)
                return 1;
            else if (xp < 7500)
                return 2;
            else if (xp < 14000)
                return 3;
            else if (xp < 23000)
                return 4;
            else if (xp < 35000)
                return 5;
            else if (xp < 53000)
                return 6;
            else if (xp < 77000)
                return 7;
            else if (xp < 115000)
                return 8;
            else if (xp < 160000)
                return 9;
            else if (xp < 235000)
                return 10;
            else if (xp < 330000)
                return 11;
            else if (xp < 475000)
                return 12;
            else if (xp < 665000)
                return 13;
            else if (xp < 955000)
                return 14;
            else if (xp < 1350000)
                return 15;
            else if (xp < 1900000)
                return 16;
            else if (xp < 2700000)
                return 17;
            else if (xp < 3850000)
                return 18;
            else if (xp < 5350000)
                return 19;
            else if (xp < 8000000)
                return 20;

            return 0;
        }


    }
}
