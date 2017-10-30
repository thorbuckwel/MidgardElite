using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MidgardElite.CreateLoad;

namespace MidgardElite.Opening
{
    public static class WelcomeScreen
    {
        public static void Welcome()
        {
            Console.WriteLine("           ####################                 ");
            Console.WriteLine("           ####################                 ");
            Console.WriteLine("                   ###                        ##");
            Console.WriteLine("                   ###              #######   ##");
            Console.WriteLine("                   ###              ##   ##   ##");
            Console.WriteLine("                   ###     ####     ##        ##         ####     ##        ");
            Console.WriteLine("                   ###   ##    ##   #######   ######   ##    ##   ######    ");
            Console.WriteLine("                   ###  ##      ##       ##   ######  ##      ##  ###  #    ");
            Console.WriteLine("            ##########   ##    ##   ##   ##   ##  ##   ##    ##   ##        ");
            Console.WriteLine("            ##########     ####     #######   ##  ##     ####     ##        ");
            Console.WriteLine("________________________________________________________________________________");
            NewPlayer.CreatePlayer();
        }
    }
}
