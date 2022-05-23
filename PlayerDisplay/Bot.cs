/*
 * Author Name: Rachel Hoffman
 * Date: 5/23/22
 * 
 * Summary: Create Bots info for the game.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerDisplay
{
    public class Bot : PlayerModel
    {
		private readonly string _name;

		/// <summary>
		/// Assign Bot name.
		/// </summary>
		/// <param name="level"></param>
		public Bot()
		{
			_name = $"Bot-{base.Id.ToString().Substring(0, 5)}";
			Level = 1;
		}

		/// <summary>
		/// Bots names are can not be changed.
		/// </summary>
		public override string Name { get => _name; }

		/// <summary>
		/// Bots level changes based on player's choice.
		/// </summary>
		/// <param name="timeOffest"></param>
		public override void LevelChange(int botLevel)
		{
			Level = botLevel;
		}
	}
}
