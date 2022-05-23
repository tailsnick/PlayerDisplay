/*
 * Author Name: Rachel Hoffman
 * Date: 5/19/22
 * 
 * Summary: A player model class that allows different methods for Printing information.
*/

namespace PlayerDisplay
{
    public abstract class PlayerModel: IPlayerModel
    {
        private Guid _id;
        private int _level;

        //constroctor
        public PlayerModel()
        {
            _id = Guid.NewGuid();
            _level = 1;
        }

        public Guid Id { get { return _id; } set { _id = value; } }
        public virtual string Name { get; set; }
        public virtual string Email { get; set; }
        public int Level { get { return _level; } set { _level = value; } }

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

        public abstract void LevelChange(int lc);
    }
}
