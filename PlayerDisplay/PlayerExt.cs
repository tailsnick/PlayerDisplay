using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerDisplay
{
	/// <summary>
	/// Extends the PlayerModel Class with some print methods
	/// </summary>
	public static class PlayerExt
	{
        public static void PrintName(PlayerModel p1)
        {
            Console.WriteLine("Player Name: " + p1.Name + "\n");
        }
        public static void PrintId(PlayerModel p1)
        {
            Console.WriteLine("Player ID: " + p1.Id + "\n");
        }
        public static void PrintEmail(PlayerModel p1)
        {
            Console.WriteLine("Player Email: " + p1.Email + "\n");
        }
        public static void PrintAll(PlayerModel p1)
        {
            Console.WriteLine("Player Name: " + p1.Name);
            Console.WriteLine("Player ID: " + p1.Id);
            Console.WriteLine("Player Email: " + p1.Email + "\n");
        }
    }
}
