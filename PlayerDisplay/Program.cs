/*
 * Author Name: Rachel Hoffman
 * Date: 5/19/22
 * 
 * Summary: Collects player information from user.
*/
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

            //error check for user input
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

            


            Console.WriteLine("\nPress any key to continue!");
            Console.ReadKey();

            UserPicksOption(pNum, playerArray);

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
                    UserPicksOption(pNum, playerArray);
                }
                else if (userAnswer == "n")
                {
                    Console.WriteLine("\nGoodbye");
                    break;
                }
            }
        }


        /// <summary>
        /// Allow user to pick from options and display them to user.
        /// </summary>
        /// <param name="pNum"></param>
        /// <param name="playerArray"></param>
        private static void UserPicksOption(int pNum, PlayerModel[] playerArray)
        {
            Console.Clear();
            Console.WriteLine("Please choose an option:\n" +
                "\n1. Print players names\n" +
                "2. Print all players IDs\n" +
                "3. Print all players emails\n" +
                "4. Print all players information\n" +
                "5. Cutie option?\n" +
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
                "\n1. Print players names\n" +
                "2. Print all players IDs\n" +
                "3. Print all players emails\n" +
                "4. Print all players information\n" +
                "5. Cutie option?\n" +
                "\nWhich option do you wanna pick?");

                userSel = Console.ReadLine();
            }

            Console.WriteLine("");

            switch (selectNum)
            {
                case 1:
                    for (int i = 0; i < pNum; i++)
                    {
                        Console.WriteLine((i + 1) + ":");
                        playerArray[i].Print(PrintPlayerName, playerArray[i]);
                    }
                    break;

                case 2:
                    for (int i = 0; i < pNum; i++)
                    {
                        Console.WriteLine((i + 1) + ":");
                        playerArray[i].Print(PrintPlayerId, playerArray[i]);
                    }
                    break;

                case 3:
                    for (int i = 0; i < pNum; i++)
                    {
                        Console.WriteLine((i + 1) + ":");
                        playerArray[i].Print(PrintPlayerEmail, playerArray[i]);
                    }
                    break;

                case 4:
                    for (int i = 0; i < pNum; i++)
                    {
                        Console.WriteLine((i + 1) + ":");
                        playerArray[i].Print(PrintPlayerAll, playerArray[i]);
                    }
                    break;

                case 5:
                    Console.WriteLine("You are a cutie! I hope you have a good day! ^-^");
                    break;
            }
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