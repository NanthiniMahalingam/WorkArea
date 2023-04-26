using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace FootballSpentEarned
{
    public class FootballRevenue
    {
        private List<FootballMarket> premierLeague;
        public List<FootballMarket> PremierLeague
        {
            get { return premierLeague; }
            set
            {
                premierLeague = value;
            }
        }

        public List<FootballMarket> FlagCollection { get; set; }

        private List<FootballMarket> liga;
        public List<FootballMarket> Liga
        {
            get { return liga; }
            set
            {
                liga = value;
            }
        }
        private List<FootballMarket> ligue1;
        public List<FootballMarket> Ligue1
        {
            get { return ligue1; }
            set
            {
                ligue1 = value;
            }
        }
        private List<FootballMarket> bundesliga;
        public List<FootballMarket> Bundesliga
        {
            get { return bundesliga; }
            set
            {
                bundesliga = value;
            }
        }
        private List<FootballMarket> serieA;
        public List<FootballMarket> SerieA
        {
            get { return serieA; }
            set
            {
                serieA = value;
            }

        }

        public FootballRevenue()
        {
            Assembly executingAssembly = typeof(App).GetTypeInfo().Assembly;
          
            using (var stream = executingAssembly.GetManifestResourceStream("FootballSpentEarned.Resources.PremierLeague.json"))
            using (TextReader textStream = new StreamReader(stream))
            {
                var data1 = textStream.ReadToEnd();
                PremierLeague = JsonConvert.DeserializeObject<List<FootballMarket>>(data1);
            }

            using (var stream = executingAssembly.GetManifestResourceStream("FootballSpentEarned.Resources.Liga.json"))
            using (TextReader textStream = new StreamReader(stream))
            {
                var data2 = textStream.ReadToEnd();
                Liga = JsonConvert.DeserializeObject<List<FootballMarket>>(data2);
            }

            using (var stream = executingAssembly.GetManifestResourceStream("FootballSpentEarned.Resources.Ligue1.json"))
            using (TextReader textStream = new StreamReader(stream))
            {
                var data3 = textStream.ReadToEnd();
                Ligue1 = JsonConvert.DeserializeObject<List<FootballMarket>>(data3);
            }

            using (var stream = executingAssembly.GetManifestResourceStream("FootballSpentEarned.Resources.BundesLiga.json"))
            using (TextReader textStream = new StreamReader(stream))
            {
                var data4 = textStream.ReadToEnd();
                Bundesliga = JsonConvert.DeserializeObject<List<FootballMarket>>(data4);
            }

            using (var stream = executingAssembly.GetManifestResourceStream("FootballSpentEarned.Resources.SerieA.json"))
            using (TextReader textStream = new StreamReader(stream))
            {
                var data5 = textStream.ReadToEnd();
                SerieA = JsonConvert.DeserializeObject<List<FootballMarket>>(data5);
            }
        }
    }
}
