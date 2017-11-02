using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MidgardElite.CreateLoad;
using MidgardElite.NewPlayer;

namespace MidgardElite.Opening
{
    public static class WelcomeScreen
    {
        public static void Welcome(ref string userInput)
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
            DetermineNew.DetermineIfNew(ref userInput);
        }
    }
}
