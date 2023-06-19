﻿using System;
namespace FootballSpentEarned
{
    public class FootballMarket
    {
        public double Club_tm { get; set; }
        public double Spent { get; set; }
        public string LeagueCode { get; set; }
        public string Club { get; set; }
        public double Earned { get; set; }
        public double Net { get; set; }
        public string Flag { get; set; }

        public FootballMarket(string flag)
        {
            Flag = flag;
        }
    }
}

