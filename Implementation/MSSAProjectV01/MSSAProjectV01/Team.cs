using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSSAProjectV01
{
    class Team
    {
        string Name;
        int[] record;

        List<Player> pitcher = new List<Player>();
        List<Player> catcher = new List<Player>();
        List<Player> firstBase = new List<Player>();
        List<Player> secondBase = new List<Player>();
        List<Player> thirdBase = new List<Player>();
        List<Player> shortstop = new List<Player>();
        List<Player> leftField = new List<Player>();
        List<Player> centerField = new List<Player>();
        List<Player> rightField = new List<Player>();

        Dictionary<string, List<Player>> players;

        Team (string n)
        {
            Name = n;
            record = new int[3] { 0, 0, 0 };
            players = new Dictionary<string, List<Player>>()
            {
                {"Pitcher", pitcher}, {"Catcher", catcher}, {"First Base", firstBase},
                {"Second Base", secondBase}, {"Third Base", thirdBase}, {"Shortstop", shortstop},
                {"Left Field", leftField}, {"Center Field", centerField}, {"Right Field", rightField}
            };
        }

    }
}
