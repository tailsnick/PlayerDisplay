/*
 * Author Name: Rachel Hoffman
 * Date: 5/19/22
 * 
 * Summary: A player model class that allows different methods for Printing information.
*/

namespace PlayerDisplay
{
    public class PlayerModel: IPlayerModel
    {
        private readonly Guid _id = Guid.NewGuid();
        public Guid Id { get { return _id; } }
        public string Name { get; set; }
        public string Email { get; set; }

        public delegate void PrintPlayerInfo(PlayerModel p);


        /// <summary>
        /// Accepts print method and a PlayerModel to print
        /// </summary>
        /// <param name="PrintPlayer"></param>
        /// <param name="player"></param>
        public void Print(PrintPlayerInfo printPlayer, PlayerModel player)
        {
            printPlayer(player);
        }
    }
}
