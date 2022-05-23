/*
 * Author Name: Rachel Hoffman
 * Date: 5/23/22
 * 
 * Summary: Collects player information from user and adds bots to game.
*/

using Newtonsoft.Json;
using System.Text.RegularExpressions;
namespace PlayerDisplay
{
    public class Program
    {
        static Player player1 = new Player();
        static List<Bot> bots = new List<Bot>();
        static void Main(string[] args)
        {
            //Player Information
            Console.WriteLine("Would you like to...\n" +
                "1. Create new Player\n" +
                "2. Load Player from file");

            int pNum = 0;
            string userNum = "";
            userNum = Console.ReadLine();

            //error check for user input
            while (!int.TryParse(userNum, out pNum))
            {
                Console.WriteLine("Invald input, please enter a number.");
                userNum = Console.ReadLine();
            }

            Console.WriteLine("");

            switch(pNum)
            {
                case 1:
                    Console.Clear();
                    NewPlayer();
                    Console.Clear();
                    break;
                case 2:
                    Console.Clear();
                    LoadPlayer();
                    break;
            }


            //Adding Bots
            Console.WriteLine("How many bots would you like? (Min 1, Max 7)");
            pNum = 0;
            userNum = Console.ReadLine();

            //error check for user input
            while (!int.TryParse(userNum, out pNum) || ((7 < pNum) || (pNum < 1)) ) //NEED To Test this
            {
                Console.WriteLine("\nInvald input, please enter a number. (Min 1, Max 7)");
                userNum = Console.ReadLine();
            }

            AddBots(pNum);


            //Console.WriteLine("\nPress any key to continue!");
            //Console.ReadKey();


            //User picks options or leaves
            UserPicksOption();

            while(true)
            {
                Console.WriteLine("\nDo you want a to look at another option? y or n");
                string userAnswer = Console.ReadLine();

                while (userAnswer != "y" && userAnswer != "n")
                {
                    Console.WriteLine("Invald input, please enter y or n.");
                    userNum = Console.ReadLine();
                }

                if (userAnswer == "y")
                {
                    UserPicksOption();
                }
                else if (userAnswer == "n")
                {
                    Console.WriteLine("\nGoodbye");
                    break;
                }
            }
        }

        /// <summary>
        /// Create new Player
        /// </summary>
        public static void NewPlayer()
        {
            //Create new player models
            string userEmail = "";
            string userName = "";
            string pattern = @"^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$";

           
                Console.WriteLine($"Please enter player name:");
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


            player1 = new Player()
            {
                Name = userName,
                Email = userEmail,
                Level = 1
            };
        }

        /// <summary>
        /// Save player info to file
        /// </summary>
        /// <param name="p"></param>
        public static void SavePlayer()
        {

        }

        /// <summary>
        /// Load player info to file
        /// </summary>
        /// <param name="p"></param>
        public static void LoadPlayer()
        {

        }

        /// <summary>
        /// Allow user to pick from options and display them to user.
        /// </summary>
        /// <param name="pNum"></param>
        /// <param name="playerArray"></param>
        public static void UserPicksOption()
        {
            Console.Clear();
            Console.WriteLine("Please choose an option:\n" +
                "\n1. Print player name\n" +
                "2. Print player ID\n" +
                "3. Print player email\n" +
                "3. Print player level\n" +
                "5. Print player information\n" +
                "6. Cutie option?\n" +
                "7. Print Bots Information\n" +
                "\nWhich option do you wanna pick?");

            //reusing this string
            string userSel = Console.ReadLine();
            int selectNum;

            //error check for user input
            while (!int.TryParse(userSel, out selectNum))
            {
                Console.Clear();
                Console.WriteLine("Invald input, please enter a number.\n");
                Console.WriteLine("Please choose an option:\n" +
                "\n1. Print player name\n" +
                "2. Print player ID\n" +
                "3. Print player email\n" +
                "3. Print player level\n" +
                "5. Print player information\n" +
                "6. Cutie option?\n" +
                "7. Print Bots Information\n" +
                "\nWhich option do you wanna pick?");

                userSel = Console.ReadLine();
            }

            Console.WriteLine("");

            switch (selectNum)
            {
                case 1:
                    player1.PrintPlayerName();
                    break;

                case 2:
                    player1.PrintPlayerId();
                    break;

                case 3:
                    player1.PrintPlayerEmail();
                    break;

                case 4:
                    player1.PrintPlayerLevel();
                    break;
                case 5:
                    player1.PrintPlayerAll();
                    break;
                case 6:
                    Console.WriteLine("You are a cutie! I hope you have a good day! ^-^");
                    break;
                case 7:
                    break;
            }

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }


        /// <summary>
        /// Create and add bots to list.
        /// </summary>
        /// <param name="num"></param>
        public static void AddBots(int num)
        {
            for (int i = 0; i < num; i++)
            {
                bots.Add(new Bot());
            }
        }
    }
}