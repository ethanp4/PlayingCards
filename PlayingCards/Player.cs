using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayingCards
{
    internal class Player
    {
        public string imageUrl { get; set; }
        public string name {  get; set; }
        public string team { get; set; }
        public int gamesPlayed { get; set; }
        public int points { get; set; }
        public int goals { get; set; }
        public int assists { get; set; }
        public static Player[] players = { 
            new Player { name = "Sam Reinhart", team = "FLA", gamesPlayed = 25, goals = 18, assists = 16, points = 32 , imageUrl = "https://assets.nhle.com/mugs/nhl/20242025/FLA/8477933.png"},
            new Player { name = "Leon Draisaitl", team = "EDM", gamesPlayed = 24, points = 32, goals = 17, assists = 15, imageUrl = "https://assets.nhle.com/mugs/nhl/20242025/EDM/8477934.png" },
            new Player { name = "Cole Caufield", team = "MTL", gamesPlayed = 24, points = 22, goals = 16, assists = 6, imageUrl = "https://assets.nhle.com/mugs/nhl/20242025/MTL/8481540.png" },
            new Player { name = "Brayden Point", team = "TBL", gamesPlayed = 19, points = 21, goals = 16, assists = 5, imageUrl = "https://assets.nhle.com/mugs/nhl/20242025/TBL/8478010.png" },
            new Player { name = "Kirill Kaprizov", team = "MIN", gamesPlayed = 23, points = 38, goals = 15, assists = 23, imageUrl = "https://assets.nhle.com/mugs/nhl/20242025/MIN/8478864.png" },
            new Player { name = "Mikko Rantanen", team = "COL", gamesPlayed = 25, points = 34, goals = 15, assists = 19, imageUrl = "https://assets.nhle.com/mugs/nhl/20242025/COL/8478420.png" },
            new Player { name = "Nico Hischier", team = "NJD", gamesPlayed = 27, goals = 15, assists = 12, points = 27, imageUrl = "https://assets.nhle.com/mugs/nhl/20242025/NJD/8480002.png"},
            new Player { name = "Alex Ovechkin", team = "WSH", gamesPlayed = 18, goals = 15, assists = 10, points = 25, imageUrl = "https://assets.nhle.com/mugs/nhl/20242025/WSH/8471214.png"},
            new Player { name = "Willian Nylander", team = "TOR", gamesPlayed = 23, goals = 15, assists = 10, points = 25, imageUrl = "https://assets.nhle.com/mugs/nhl/20242025/TOR/8477939.png"},
            new Player { name = "Connor McMichael", team = "WSH", gamesPlayed = 24, goals = 14, assists = 10, points = 24, imageUrl = "https://assets.nhle.com/mugs/nhl/20242025/WSH/8481580.png"}
        };

        public override string ToString()
        {
            return $"{name}";
        }
    }
}
