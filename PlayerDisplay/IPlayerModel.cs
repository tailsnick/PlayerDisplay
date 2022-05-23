/*
 * Author Name: Rachel Hoffman
 * Date: 5/19/22
 * 
 * Summary: A basic abstract class for player information.
*/

namespace PlayerDisplay
{
    internal interface IPlayerModel
    {
        Guid Id { get; }
        string Name { get; set; }
        string Email { get; set; }
        int Level { get; set; }
    }
}
