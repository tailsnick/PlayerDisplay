/*
 * Author Name: Rachel Hoffman
 * Date: 5/19/22
 * 
 * Summary: A basic abstract class for player information.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerDisplay
{
    internal interface IPlayerModel
    {
        Guid Id { get; }
        string Name { get; set; }
        string Email { get; set; }
    }
}
