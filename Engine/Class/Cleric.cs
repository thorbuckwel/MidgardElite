using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Model;

namespace Engine.Class
{
    public static class Cleric
    {
        public static int DetermineBaB(ref Player _player)
        {
            if (_player.Level == 1)
                return 0;
            else if (_player.Level == 2)
                return 1;
            else if (_player.Level == 3)
                return 2;
            else if (_player.Level > 3 && _player.Level <= 5)
                return 3;
            else if (_player.Level == 6)
                return 4;
            else if (_player.Level == 7)
                return 5;
            else if (_player.Level > 7 && _player.Level <= 9)
                return 6;
            else if (_player.Level == 10)
                return 7;
            else if (_player.Level == 11)
                return 8;
            else if (_player.Level > 11 && _player.Level <= 13)
                return 9;
            else if (_player.Level == 14)
                return 10;
            else if (_player.Level == 15)
                return 11;
            else if (_player.Level > 15 && _player.Level <= 17)
                return 12;
            else if (_player.Level == 18)
                return 13;
            else if (_player.Level == 19)
                return 14;
            else if (_player.Level == 20)
                return 15;

            return 0;
        }

        public static int DetermineFort(ref Player _player)
        {
            if (_player.Level == 1)
                return 2;
            else if (_player.Level < 1 && _player.Level <= 3)
                return 3;
            else if (_player.Level > 3 && _player.Level <= 5)
                return 4;
            else if (_player.Level > 5 && _player.Level <= 7)
                return 5;
            else if (_player.Level > 7 && _player.Level <= 9)
                return 6;
            else if (_player.Level > 9 && _player.Level <= 11)
                return 7;
            else if (_player.Level > 11 && _player.Level <= 13)
                return 8;
            else if (_player.Level > 13 && _player.Level <= 15)
                return 9;
            else if (_player.Level > 15 && _player.Level <= 17)
                return 10;
            else if (_player.Level > 17 && _player.Level <= 19)
                return 11;
            else if (_player.Level == 20)
                return 12;

            return 0;
        }

        public static int DetermineRefMod(ref Player _player)
        {
            if (_player.Level >= 1 && _player.Level <= 2)
                return 0;
            else if (_player.Level > 2 && _player.Level <= 5)
                return 1;
            else if (_player.Level > 5 && _player.Level <= 8)
                return 2;
            else if (_player.Level > 8 && _player.Level <= 11)
                return 3;
            else if (_player.Level > 11 && _player.Level <= 14)
                return 4;
            else if (_player.Level > 14 && _player.Level <= 17)
                return 5;
            else if (_player.Level > 17 && _player.Level <= 20)
                return 6;

            return 0;
        }

        public static int DetermineWillMod(ref Player _player)
        {
            if (_player.Level == 1)
                return 2;
            else if (_player.Level < 1 && _player.Level <= 3)
                return 3;
            else if (_player.Level > 3 && _player.Level <= 5)
                return 4;
            else if (_player.Level > 5 && _player.Level <= 7)
                return 5;
            else if (_player.Level > 7 && _player.Level <= 9)
                return 6;
            else if (_player.Level > 9 && _player.Level <= 11)
                return 7;
            else if (_player.Level > 11 && _player.Level <= 13)
                return 8;
            else if (_player.Level > 13 && _player.Level <= 15)
                return 9;
            else if (_player.Level > 15 && _player.Level <= 17)
                return 10;
            else if (_player.Level > 17 && _player.Level <= 19)
                return 11;
            else if (_player.Level == 20)
                return 12;

            return 0;
        }
    }
}
