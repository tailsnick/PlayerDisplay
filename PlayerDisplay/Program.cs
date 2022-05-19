using System.Text.RegularExpressions;
namespace PlayerDisplay
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Player Count
            Console.WriteLine("How many players are playing?");

            int pNum = 0;
            string userInput = Console.ReadLine();

            while (!int.TryParse(userInput, out pNum))
            {
                Console.WriteLine("Invald input, please enter a number.");
                userInput = Console.ReadLine();
            }

            //Create new player models
            string pattern = @"^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$";
            List<PlayerModel> list = new List<PlayerModel>();

            for(int i = 0; i < pNum; i++)
            {
                userInput = Console.ReadLine();

                //check email validation
                //while ()
                //{
                //    Console.WriteLine("Invald input, please enter a number.");
                //    userInput = Console.ReadLine();
                //}
            }
            Console.WriteLine("");
            Console.ReadLine();


            
        }

        private static void PrintId(PlayerModel p1)
        {
            Console.WriteLine($"Player ID: {p1.Id}");
        }

        private static void PrintName(PlayerModel p1)
        {
            Console.WriteLine($"Player Name: {p1.Name}");
        }

        private static void PrintEmail(PlayerModel p1)
        {
            Console.WriteLine($"Player Email: {p1.Email}");
        }

        private static void PrintAll(PlayerModel p1)
        {
            Console.WriteLine($"Player Name: {p1.Name}");
            Console.WriteLine($"Player ID: {p1.Id}");
            Console.WriteLine($"Player Email: {p1.Email}");
        }
    }
}