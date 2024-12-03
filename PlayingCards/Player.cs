using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayingCards
{
    internal class Player
    {
        public string name {  get; set; }
        public string team { get; set; }
        public int gamesPlayed { get; set; }
        public int points { get; set; }
        public int goals { get; set; }
        public int assists { get; set; }
        public static Player[] players = { new Player { name = "Sam Reinhart", team = "FLA", gamesPlayed = 25, goals = 18, assists = 16, points = 32 },
            new Player { name = "Leon Draisaitl", }
        };
    }
}
