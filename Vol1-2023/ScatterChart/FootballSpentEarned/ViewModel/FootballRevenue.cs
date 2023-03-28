﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FootballSpentEarned
{
    public class FootballRevenue : INotifyPropertyChanged
    {
        private List<FootballMarket> premierLeague;
        public List<FootballMarket> PremierLeague
        {
            get { return premierLeague; }
            set
            {
                premierLeague = value;
                NotifyPropertyChanged(nameof(PremierLeague));
            }
        }
        private List<FootballMarket> liga;
        public List<FootballMarket> Liga
        {
            get { return liga; }
            set
            {
                liga = value;
                NotifyPropertyChanged(nameof(Liga));
            }
        }
        private List<FootballMarket> ligue1;
        public List<FootballMarket> Ligue1
        {
            get { return ligue1; }
            set
            {
                ligue1 = value;
                NotifyPropertyChanged(nameof(Ligue1));
            }
        }
        private List<FootballMarket> bundesliga;
        public List<FootballMarket> Bundesliga
        {
            get { return bundesliga; }
            set
            {
                bundesliga = value;
                NotifyPropertyChanged(nameof(Bundesliga));
            }
        }
        private List<FootballMarket> serieA;
        public List<FootballMarket> SerieA
        {
            get { return serieA; }
            set
            {
                serieA = value;
                NotifyPropertyChanged(nameof(SerieA));
            }
        }
        public FootballRevenue()
        {
            var data1 = @"[{""club_tm"":281, ""club"": ""Manchester City"", ""leagueCode"": ""ENG"", ""spent"":1006, ""earned"": 375, ""net"": -631, ""net_neg"":631, ""net_pos"":0},
{""club_tm"":985, ""club"": ""Manchester United"", ""leagueCode"": ""ENG"", ""spent"":832, ""earned"": 246, ""net"": -586, ""net_neg"":586, ""net_pos"":0},
{""club_tm"":29, ""club"": ""Everton FC"", ""leagueCode"": ""ENG"", ""spent"":701, ""earned"": 355, ""net"": -346, ""net_neg"":346, ""net_pos"":0},
{""club_tm"":405, ""club"": ""Aston Villa"", ""leagueCode"": ""ENG"", ""spent"":407, ""earned"": 68, ""net"": -339, ""net_neg"":339, ""net_pos"":0},
{""club_tm"":631, ""club"": ""Chelsea FC"", ""leagueCode"": ""ENG"", ""spent"":968, ""earned"": 660, ""net"": -308, ""net_neg"":308, ""net_pos"":0},
{""club_tm"":11, ""club"": ""Arsenal FC"", ""leagueCode"": ""ENG"", ""spent"":588, ""earned"": 289, ""net"": -299, ""net_neg"":299, ""net_pos"":0},
{""club_tm"":1237, ""club"": ""Brighton & Hove"", ""leagueCode"": ""ENG"", ""spent"":302, ""earned"": 43, ""net"": -259, ""net_neg"":259, ""net_pos"":0},
{""club_tm"":148, ""club"": ""Tottenham Hotspur"", ""leagueCode"": ""ENG"", ""spent"":516, ""earned"": 266, ""net"": -250, ""net_neg"":250, ""net_pos"":0},
{""club_tm"":543, ""club"": ""Wolverhampton FC"", ""leagueCode"": ""ENG"", ""spent"":399, ""earned"": 150, ""net"": -249, ""net_neg"":249, ""net_pos"":0},
{""club_tm"":931, ""club"": ""Fulham FC"", ""leagueCode"": ""ENG"", ""spent"":274, ""earned"": 84, ""net"": -190, ""net_neg"":190, ""net_pos"":0},
{""club_tm"":379, ""club"": ""West Ham United"", ""leagueCode"": ""ENG"", ""spent"":427, ""earned"": 256, ""net"": -171, ""net_neg"":171, ""net_pos"":0},
{""club_tm"":350, ""club"": ""Sheffield United"", ""leagueCode"": ""ENG"", ""spent"":159, ""earned"": 25, ""net"": -134, ""net_neg"":134, ""net_pos"":0},
{""club_tm"":1003, ""club"": ""Leicester City"", ""leagueCode"": ""ENG"", ""spent"":503, ""earned"": 369, ""net"": -134, ""net_neg"":134, ""net_pos"":0},
{""club_tm"":31, ""club"": ""Liverpool FC"", ""leagueCode"": ""ENG"", ""spent"":603, ""earned"": 474, ""net"": -129, ""net_neg"":129, ""net_pos"":0},
{""club_tm"":399, ""club"": ""Leeds United"", ""leagueCode"": ""ENG"", ""spent"":187, ""earned"": 72, ""net"": -115, ""net_neg"":115, ""net_pos"":0},
{""club_tm"":873, ""club"": ""Crystal Palace"", ""leagueCode"": ""ENG"", ""spent"":227, ""earned"": 127, ""net"": -100, ""net_neg"":100, ""net_pos"":0},
{""club_tm"":1132, ""club"": ""Burnley FC"", ""leagueCode"": ""ENG"", ""spent"":156, ""earned"": 74, ""net"": -82, ""net_neg"":82, ""net_pos"":0},
{""club_tm"":762, ""club"": ""Newcastle United"", ""leagueCode"": ""ENG"", ""spent"":307, ""earned"": 230, ""net"": -77, ""net_neg"":77, ""net_pos"":0},
{""club_tm"":984, ""club"": ""West Bromwich Albion"", ""leagueCode"": ""ENG"", ""spent"":177, ""earned"": 104, ""net"": -73, ""net_neg"":73, ""net_pos"":0},
{""club_tm"":180, ""club"": ""Southampton FC"", ""leagueCode"": ""ENG"", ""spent"":323, ""earned"": 273, ""net"": -50, ""net_neg"":50, ""net_pos"":0}
]";
            PremierLeague = JsonConvert.DeserializeObject<List<FootballMarket>>(data1); var data2 = @"[{""club_tm"":131, ""club"": ""FC Barcelona"", ""leagueCode"": ""ESP"", ""spent"":1171, ""earned"": 700, ""net"": -471, ""net_neg"":471, ""net_pos"":0},
{""club_tm"":13, ""club"": ""Atlético Madrid"", ""leagueCode"": ""ESP"", ""spent"":715, ""earned"": 611, ""net"": -104, ""net_neg"":104, ""net_pos"":0},
{""club_tm"":368, ""club"": ""Sevilla FC"", ""leagueCode"": ""ESP"", ""spent"":529, ""earned"": 437, ""net"": -92, ""net_neg"":92, ""net_pos"":0},
{""club_tm"":418, ""club"": ""Real Madrid"", ""leagueCode"": ""ESP"", ""spent"":661, ""earned"": 570, ""net"": -91, ""net_neg"":91, ""net_pos"":0},
{""club_tm"":3709, ""club"": ""Getafe CF"", ""leagueCode"": ""ESP"", ""spent"":81, ""earned"": 31, ""net"": -50, ""net_neg"":50, ""net_pos"":0},
{""club_tm"":1050, ""club"": ""Villarreal CF"", ""leagueCode"": ""ESP"", ""spent"":305, ""earned"": 295, ""net"": -10, ""net_neg"":10, ""net_pos"":0},
{""club_tm"":940, ""club"": ""Celta Vigo"", ""leagueCode"": ""ESP"", ""spent"":93, ""earned"": 122, ""net"": 29, ""net_neg"":0, ""net_pos"":29},
{""club_tm"":3368, ""club"": ""Levante UD"", ""leagueCode"": ""ESP"", ""spent"":62, ""earned"": 79, ""net"": 17, ""net_neg"":0, ""net_pos"":17},
{""club_tm"":150, ""club"": ""Real Betis"", ""leagueCode"": ""ESP"", ""spent"":221, ""earned"": 212, ""net"": -9, ""net_neg"":9, ""net_pos"":0},
{""club_tm"":331, ""club"": ""CA Osasuna"", ""leagueCode"": ""ESP"", ""spent"":34, ""earned"": 29, ""net"": -5, ""net_neg"":5, ""net_pos"":0},
{""club_tm"":1108, ""club"": ""CD Alavés"", ""leagueCode"": ""ESP"", ""spent"":45, ""earned"": 47, ""net"": 2, ""net_neg"":0, ""net_pos"":2},
{""club_tm"":366, ""club"": ""Real Valladolid"", ""leagueCode"": ""ESP"", ""spent"":30, ""earned"": 27, ""net"": -3, ""net_neg"":3, ""net_pos"":0},
{""club_tm"":16795, ""club"": ""Granada CF"", ""leagueCode"": ""ESP"", ""spent"":44, ""earned"": 42, ""net"": -2, ""net_neg"":2, ""net_pos"":0},
{""club_tm"":1533, ""club"": ""SD Eibar"", ""leagueCode"": ""ESP"", ""spent"":46, ""earned"": 45, ""net"": -1, ""net_neg"":1, ""net_pos"":0},
{""club_tm"":681, ""club"": ""Real Sociedad"", ""leagueCode"": ""ESP"", ""spent"":98, ""earned"": 144, ""net"": 46, ""net_neg"":0, ""net_pos"":46},
{""club_tm"":2687, ""club"": ""Cádiz CF"", ""leagueCode"": ""ESP"", ""spent"":12, ""earned"": 16, ""net"": 4, ""net_neg"":0, ""net_pos"":4},
{""club_tm"":5358, ""club"": ""Huesca SD"", ""leagueCode"": ""ESP"", ""spent"":13, ""earned"": 18, ""net"": 5, ""net_neg"":0, ""net_pos"":5},
{""club_tm"":621, ""club"": ""Athletic Club"", ""leagueCode"": ""ESP"", ""spent"":79, ""earned"": 145, ""net"": 66, ""net_neg"":0, ""net_pos"":66},
{""club_tm"":1049, ""club"": ""Valencia CF"", ""leagueCode"": ""ESP"", ""spent"":292, ""earned"": 359, ""net"": 67, ""net_neg"":0, ""net_pos"":67},
{""club_tm"":1531, ""club"": ""Elche CF"", ""leagueCode"": ""ESP"", ""spent"":6, ""earned"": 12, ""net"": 6, ""net_neg"":0, ""net_pos"":6},
]";
            Liga = JsonConvert.DeserializeObject<List<FootballMarket>>(data2); var data3 = @"[{""club_tm"":583, ""club"": ""Paris St-Germain"", ""leagueCode"": ""FRA"", ""spent"":854, ""earned"": 399, ""net"": -455, ""net_neg"":455, ""net_pos"":0},
{""club_tm"":244, ""club"": ""Olympique Marseille"", ""leagueCode"": ""FRA"", ""spent"":248, ""earned"": 177, ""net"": -71, ""net_neg"":71, ""net_pos"":0},
{""club_tm"":995, ""club"": ""FC Nantes"", ""leagueCode"": ""FRA"", ""spent"":63, ""earned"": 58, ""net"": -5, ""net_neg"":5, ""net_pos"":0},
{""club_tm"":1160, ""club"": ""Nîmes Olympique"", ""leagueCode"": ""FRA"", ""spent"":26, ""earned"": 25, ""net"": -1, ""net_neg"":1, ""net_pos"":0},
{""club_tm"":273, ""club"": ""Stade Rennais"", ""leagueCode"": ""FRA"", ""spent"":221, ""earned"": 224, ""net"": 3, ""net_neg"":0, ""net_pos"":3},
{""club_tm"":3911, ""club"": ""Stade Brestois"", ""leagueCode"": ""FRA"", ""spent"":28, ""earned"": 30, ""net"": 2, ""net_neg"":0, ""net_pos"":2},
{""club_tm"":667, ""club"": ""RC Strasbourg"", ""leagueCode"": ""FRA"", ""spent"":38, ""earned"": 42, ""net"": 4, ""net_neg"":0, ""net_pos"":4},
{""club_tm"":347, ""club"": ""FC Metz"", ""leagueCode"": ""FRA"", ""spent"":46, ""earned"": 52, ""net"": 6, ""net_neg"":0, ""net_pos"":6},
{""club_tm"":826, ""club"": ""RC Lens"", ""leagueCode"": ""FRA"", ""spent"":38, ""earned"": 52, ""net"": 14, ""net_neg"":0, ""net_pos"":14},
{""club_tm"":417, ""club"": ""OGC Nice"", ""leagueCode"": ""FRA"", ""spent"":157, ""earned"": 173, ""net"": 16, ""net_neg"":0, ""net_pos"":16},
{""club_tm"":1158, ""club"": ""FC Lorient"", ""leagueCode"": ""FRA"", ""spent"":54, ""earned"": 91, ""net"": 37, ""net_neg"":0, ""net_pos"":37},
{""club_tm"":1421, ""club"": ""Stade de Reims"", ""leagueCode"": ""FRA"", ""spent"":58, ""earned"": 77, ""net"": 19, ""net_neg"":0, ""net_pos"":19},
{""club_tm"":2969, ""club"": ""Dijon FCO"", ""leagueCode"": ""FRA"", ""spent"":46, ""earned"": 72, ""net"": 26, ""net_neg"":0, ""net_pos"":26},
{""club_tm"":1420, ""club"": ""Angers SCO"", ""leagueCode"": ""FRA"", ""spent"":52, ""earned"": 80, ""net"": 28, ""net_neg"":0, ""net_pos"":28},
{""club_tm"":969, ""club"": ""Montpellier HSC"", ""leagueCode"": ""FRA"", ""spent"":63, ""earned"": 123, ""net"": 60, ""net_neg"":0, ""net_pos"":60},
{""club_tm"":1041, ""club"": ""Olympique Lyonnais"", ""leagueCode"": ""FRA"", ""spent"":348, ""earned"": 499, ""net"": 151, ""net_neg"":0, ""net_pos"":151},
{""club_tm"":1082, ""club"": ""LOSC Lille"", ""leagueCode"": ""FRA"", ""spent"":252, ""earned"": 443, ""net"": 191, ""net_neg"":0, ""net_pos"":191},
{""club_tm"":40, ""club"": ""Girondins Bordeaux"", ""leagueCode"": ""FRA"", ""spent"":90, ""earned"": 156, ""net"": 66, ""net_neg"":0, ""net_pos"":66},
{""club_tm"":618, ""club"": ""AS St-Etienne"", ""leagueCode"": ""FRA"", ""spent"":68, ""earned"": 146, ""net"": 78, ""net_neg"":0, ""net_pos"":78},
{""club_tm"":162, ""club"": ""AS Monaco"", ""leagueCode"": ""FRA"", ""spent"":626, ""earned"": 758, ""net"": 132, ""net_neg"":0, ""net_pos"":132},
]";


            Ligue1 = JsonConvert.DeserializeObject<List<FootballMarket>>(data3); var data4 = @"[{""club_tm"":23826, ""club"": ""RB Leipzig"", ""leagueCode"": ""GER"", ""spent"":390, ""earned"": 214, ""net"": -176, ""net_neg"":176, ""net_pos"":0},
{""club_tm"":27, ""club"": ""Bayern München"", ""leagueCode"": ""GER"", ""spent"":472, ""earned"": 301, ""net"": -171, ""net_neg"":171, ""net_pos"":0},
{""club_tm"":44, ""club"": ""Hertha BSC"", ""leagueCode"": ""GER"", ""spent"":185, ""earned"": 76, ""net"": -109, ""net_neg"":109, ""net_pos"":0},
{""club_tm"":82, ""club"": ""VfL Wolfsburg"", ""leagueCode"": ""GER"", ""spent"":283, ""earned"": 175, ""net"": -108, ""net_neg"":108, ""net_pos"":0},
{""club_tm"":33, ""club"": ""FC Schalke 04"", ""leagueCode"": ""GER"", ""spent"":188, ""earned"": 141, ""net"": -47, ""net_neg"":47, ""net_pos"":0},
{""club_tm"":18, ""club"": ""Borussia M'gladbach"", ""leagueCode"": ""GER"", ""spent"":181, ""earned"": 160, ""net"": -21, ""net_neg"":21, ""net_pos"":0},
{""club_tm"":86, ""club"": ""Werder Bremen"", ""leagueCode"": ""GER"", ""spent"":109, ""earned"": 88, ""net"": -21, ""net_neg"":21, ""net_pos"":0},
{""club_tm"":15, ""club"": ""Bayer Leverkusen"", ""leagueCode"": ""GER"", ""spent"":321, ""earned"": 303, ""net"": -18, ""net_neg"":18, ""net_pos"":0},
{""club_tm"":167, ""club"": ""FC Augsburg"", ""leagueCode"": ""GER"", ""spent"":81, ""earned"": 64, ""net"": -17, ""net_neg"":17, ""net_pos"":0},
{""club_tm"":3, ""club"": ""FC Köln"", ""leagueCode"": ""GER"", ""spent"":106, ""earned"": 94, ""net"": -12, ""net_neg"":12, ""net_pos"":0},
{""club_tm"":79, ""club"": ""VfB Stuttgart"", ""leagueCode"": ""GER"", ""spent"":140, ""earned"": 131, ""net"": -9, ""net_neg"":9, ""net_pos"":0},
{""club_tm"":89, ""club"": ""Union Berlin"", ""leagueCode"": ""GER"", ""spent"":19, ""earned"": 19, ""net"": 0, ""net_neg"":0, ""net_pos"":0},
{""club_tm"":10, ""club"": ""Arminia Bielefeld"", ""leagueCode"": ""GER"", ""spent"":2, ""earned"": 5, ""net"": 3, ""net_neg"":0, ""net_pos"":3},
{""club_tm"":533, ""club"": ""TSG Hoffenheim"", ""leagueCode"": ""GER"", ""spent"":150, ""earned"": 237, ""net"": 87, ""net_neg"":0, ""net_pos"":87},
{""club_tm"":16, ""club"": ""Borussia Dortmund"", ""leagueCode"": ""GER"", ""spent"":582, ""earned"": 659, ""net"": 77, ""net_neg"":0, ""net_pos"":77},
{""club_tm"":60, ""club"": ""SC Freiburg"", ""leagueCode"": ""GER"", ""spent"":88, ""earned"": 103, ""net"": 15, ""net_neg"":0, ""net_pos"":15},
{""club_tm"":24, ""club"": ""Eintracht Frankfurt"", ""leagueCode"": ""GER"", ""spent"":133, ""earned"": 149, ""net"": 16, ""net_neg"":0, ""net_pos"":16},
{""club_tm"":39, ""club"": ""FSV Mainz 05"", ""leagueCode"": ""GER"", ""spent"":123, ""earned"": 155, ""net"": 32, ""net_neg"":0, ""net_pos"":32}, ]";
            Bundesliga = JsonConvert.DeserializeObject<List<FootballMarket>>(data4); var data5 = @"[{""club_tm"":46, ""club"": ""Internazionale"", ""leagueCode"": ""ITA"", ""spent"":664, ""earned"": 278, ""net"": -386, ""net_neg"":386, ""net_pos"":0},
{""club_tm"":5, ""club"": ""Milan AC"", ""leagueCode"": ""ITA"", ""spent"":577, ""earned"": 266, ""net"": -311, ""net_neg"":311, ""net_pos"":0},
{""club_tm"":506, ""club"": ""Juventus FC"", ""leagueCode"": ""ITA"", ""spent"":999, ""earned"": 750, ""net"": -249, ""net_neg"":249, ""net_pos"":0},
{""club_tm"":6195, ""club"": ""SSC Napoli"", ""leagueCode"": ""ITA"", ""spent"":565, ""earned"": 400, ""net"": -165, ""net_neg"":165, ""net_pos"":0},
{""club_tm"":130, ""club"": ""Parma Calcio"", ""leagueCode"": ""ITA"", ""spent"":170, ""earned"": 12, ""net"": -158, ""net_neg"":158, ""net_pos"":0},
{""club_tm"":1390, ""club"": ""Cagliari Calcio"", ""leagueCode"": ""ITA"", ""spent"":158, ""earned"": 89, ""net"": -69, ""net_neg"":69, ""net_pos"":0},
{""club_tm"":1025, ""club"": ""Bologna FC"", ""leagueCode"": ""ITA"", ""spent"":144, ""earned"": 82, ""net"": -62, ""net_neg"":62, ""net_pos"":0},
{""club_tm"":4171, ""club"": ""Benevento Calcio"", ""leagueCode"": ""ITA"", ""spent"":55, ""earned"": 15, ""net"": -40, ""net_neg"":40, ""net_pos"":0},
{""club_tm"":430, ""club"": ""ACF Fiorentina"", ""leagueCode"": ""ITA"", ""spent"":285, ""earned"": 249, ""net"": -36, ""net_neg"":36, ""net_pos"":0},
{""club_tm"":398, ""club"": ""SS Lazio"", ""leagueCode"": ""ITA"", ""spent"":213, ""earned"": 189, ""net"": -24, ""net_neg"":24, ""net_pos"":0},
{""club_tm"":416, ""club"": ""Torino FC"", ""leagueCode"": ""ITA"", ""spent"":207, ""earned"": 199, ""net"": -8, ""net_neg"":8, ""net_pos"":0},
{""club_tm"":4083, ""club"": ""FC Crotone"", ""leagueCode"": ""ITA"", ""spent"":25, ""earned"": 19, ""net"": -6, ""net_neg"":6, ""net_pos"":0},
{""club_tm"":3522, ""club"": ""Spezia Calcio"", ""leagueCode"": ""ITA"", ""spent"":12, ""earned"": 20, ""net"": 8, ""net_neg"":0, ""net_pos"":8},
{""club_tm"":12, ""club"": ""AS Roma"", ""leagueCode"": ""ITA"", ""spent"":537, ""earned"": 571, ""net"": 34, ""net_neg"":0, ""net_pos"":34},
{""club_tm"":6574, ""club"": ""US Sassuolo"", ""leagueCode"": ""ITA"", ""spent"":187, ""earned"": 216, ""net"": 29, ""net_neg"":0, ""net_pos"":29},
{""club_tm"":252, ""club"": ""Genoa CFC"", ""leagueCode"": ""ITA"", ""spent"":181, ""earned"": 256, ""net"": 75, ""net_neg"":0, ""net_pos"":75},
{""club_tm"":1038, ""club"": ""Sampdoria UC"", ""leagueCode"": ""ITA"", ""spent"":248, ""earned"": 324, ""net"": 76, ""net_neg"":0, ""net_pos"":76},
{""club_tm"":800, ""club"": ""Atalanta BC"", ""leagueCode"": ""ITA"", ""spent"":241, ""earned"": 374, ""net"": 133, ""net_neg"":0, ""net_pos"":133},
{""club_tm"":276, ""club"": ""Hellas Verona"", ""leagueCode"": ""ITA"", ""spent"":52, ""earned"": 103, ""net"": 51, ""net_neg"":0, ""net_pos"":51},
{""club_tm"":410, ""club"": ""Udinese Calcio"", ""leagueCode"": ""ITA"", ""spent"":118, ""earned"": 177, ""net"": 59, ""net_neg"":0, ""net_pos"":59},
]";
            SerieA = JsonConvert.DeserializeObject<List<FootballMarket>>(data5);
        }
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
