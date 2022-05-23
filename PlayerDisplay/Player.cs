/*
 * Author Name: Rachel Hoffman
 * Date: 5/23/22
 * 
 * Summary: Player information is stored in here when making new player or loading player from file.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerDisplay
{
    public class Player : PlayerModel
    {
        /// <summary>
        /// New player
        /// </summary>
        public Player()
        { }

        /// <summary>
        /// Loading PLayer file
        /// </summary>
        /// <param name="level"></param>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="email"></param>
        public Player(int level, Guid id, string name, string email)
        {
            Level = level;
            Id = id;
            Name = name;
            Email = email;

        }

        public string Email { get; set; }

        public override void LevelChange(int up)
        {
            base.Level += up;
        }
    }
}
