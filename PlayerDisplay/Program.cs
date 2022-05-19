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
            string userNum = "";
            userNum = Console.ReadLine();

            while (!int.TryParse(userNum, out pNum))
            {
                Console.WriteLine("Invald input, please enter a number.");
                userNum = Console.ReadLine();
            }
            Console.WriteLine("");

            //Create new player models
            string userEmail = "";
            string userName = "";
            string pattern = @"^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$";
            PlayerModel[] playerArray = new PlayerModel[pNum];
            PlayerModel pm;

            for (int i = 0; i < pNum; i++)
            {
                Console.WriteLine($"Please enter player {i+1} name:");
                userName = Console.ReadLine();
                Console.WriteLine("");

                Console.WriteLine("Please enter player email:");
                userEmail = Console.ReadLine();
                Console.WriteLine("");

                //check email validation
                while (!Regex.IsMatch(userEmail, pattern))
                {
                    Console.WriteLine("Invald input, please enter valid email address.");
                    userEmail = Console.ReadLine();
                }
                playerArray[i] = new PlayerModel();
                playerArray[i].Name = userName;
                playerArray[i].Email = userEmail;
            }

            for (int i = 0; i < pNum; i++)
            {
                Console.WriteLine((i+1)+":");
                playerArray[i].Print(PrintPlayerAll, playerArray[i]);
            }

            Console.ReadKey();
        }


        private static void PrintPlayerName(PlayerModel p1)
        {
            Console.WriteLine("Player Name: "+ p1.Name +"\n");
        }
        private static void PrintPlayerId(PlayerModel p1)
        {
            Console.WriteLine("Player ID: "+ p1.Id +"\n");
        }
        private static void PrintPlayerEmail(PlayerModel p1)
        {
            Console.WriteLine("Player Email: " + p1.Email + "\n");
        }
        private static void PrintPlayerAll(PlayerModel p1)
        {
            Console.WriteLine("Player Name: " + p1.Name);
            Console.WriteLine("Player ID: " + p1.Id);
            Console.WriteLine("Player Email: " + p1.Email + "\n");
        }
    }
}