/*
 * Author Name: Rachel Hoffman
 * Date: 5/23/22
 * 
 * Summary: An Extension of PlayerModel that prints information.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerDisplay
{
    public static class PlayerExtend
    {
        public static void PrintPlayerName(this PlayerModel p1)
        {
            Console.WriteLine("Player Name: " + p1.Name + "\n");
        }
        public static void PrintPlayerId(this PlayerModel p1)
        {
            Console.WriteLine("Player ID: " + p1.Id + "\n");
        }
        public static void PrintPlayerEmail(this PlayerModel p1)
        {
            Console.WriteLine("Player Email: " + p1.Email + "\n");
        }
        public static void PrintPlayerLevel(this PlayerModel p1)
        {
            Console.WriteLine("Player Level: " + p1.Level + "\n");
        }
        public static void PrintPlayerAll(this PlayerModel p1)
        {
            Console.WriteLine("Player Name: " + p1.Name);
            Console.WriteLine("Player ID: " + p1.Id);
            Console.WriteLine("Player Email: " + p1.Email);
            Console.WriteLine("Player Level: " + p1.Level + "\n");
        }
    }
}
