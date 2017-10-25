using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSSAProjectV01
{
    class Player
    {
        protected string email;
        protected byte[] password;
        protected string FirstName;
        protected string LastName;
        protected string phone;
        protected string position;
        protected Team team;
        protected Dictionary<string, int> stats;

        Player(string em, byte[] ba, string fn, string ln, string ph)
        {
            email = em;
            password = ba;
            FirstName = fn;
            LastName = ln;
            phone = ph;
            stats = new Dictionary<string, int>()
            {
                {"BA", -1}, {"HR", -1}, {"H", -1}, {"RBI", -1}, {"R", -1 }, {"SB", -1},
                {"W", -1}, {"ERA", -1}, {"WHIP", -1}
            };
        }

        Player(string em, byte[] ba, string fn, string ln, string ph, string pos)
        {
            email = em;
            password = ba;
            FirstName = fn;
            LastName = ln;
            phone = ph;
            position = pos;
            stats = new Dictionary<string, int>()
            {
                {"BA", -1}, {"HR", -1}, {"H", -1}, {"RBI", -1}, {"R", -1 }, {"SB", -1},
                {"W", -1}, {"ERA", -1}, {"WHIP", -1}
            };
        }

        Player(string em, byte[] ba, string fn, string ln, string ph, string pos, Team tm)
        {
            email = em;
            password = ba;
            FirstName = fn;
            LastName = ln;
            phone = ph;
            position = pos;
            team = tm;
            stats = new Dictionary<string, int>()
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
