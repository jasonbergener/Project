using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSSAProjectV01
{
    class Player
    {
        protected string Email;
        protected byte[] Password;
        protected string FirstName;
        protected string LastName;
        protected string Phone;
        protected string Position;
        protected Team Team;
        protected Dictionary<string, int> Stats;

        Player(string email, byte[] password, string firstname, string lastname, string phone)
        {
            Email = email;
            Password = password;
            FirstName = firstname;
            LastName = lastname;
            Phone = phone;
            Stats = new Dictionary<string, int>()
            {
                {"BA", -1}, {"HR", -1}, {"H", -1}, {"RBI", -1}, {"R", -1 }, {"SB", -1},
                {"W", -1}, {"ERA", -1}, {"WHIP", -1}
            };
        }

        Player(string email, byte[] password, string firstname, string lastname, string phone, string position)
        {
            Email = email;
            Password = password;
            FirstName = firstname;
            LastName = lastname;
            Phone = phone;
            Position = position;
            Stats = new Dictionary<string, int>()
            {
                {"BA", -1}, {"HR", -1}, {"H", -1}, {"RBI", -1}, {"R", -1 }, {"SB", -1},
                {"W", -1}, {"ERA", -1}, {"WHIP", -1}
            };
        }

        Player(string email, byte[] password, string firstname, string lastname, string phone, string position, Team team)
        {
            Email = email;
            Password = password;
            FirstName = firstname;
            LastName = lastname;
            Phone = phone;
            Position = position;
            Team = team;
            Stats = new Dictionary<string, int>()
            {
                {"BA", -1}, {"HR", -1}, {"H", -1}, {"RBI", -1}, {"R", -1 }, {"SB", -1},
                {"W", -1}, {"ERA", -1}, {"WHIP", -1}
            };
        }

        protected void UpdateInfo()
        {
            //To do
        }

        protected void DeleteAccount()
        {
            //To do
        }
    }
}
