﻿using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

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

        private List<FootballMarket> data;
        public List<FootballMarket> Data
        {
            get { return data; }
            set
            {
                data = value;
                NotifyPropertyChanged(nameof(Data));
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
            Assembly executingAssembly = typeof(App).GetTypeInfo().Assembly;
            Stream inputStream1 = executingAssembly.GetManifestResourceStream("FootballSpentEarned.Resources.Raw.premierleague.json");
            using StreamReader reader1 = new StreamReader(inputStream1);
            var data1 = reader1.ReadToEnd();
            PremierLeague = JsonConvert.DeserializeObject<List<FootballMarket>>(data1);

            Stream inputStream2 = executingAssembly.GetManifestResourceStream("FootballSpentEarned.Resources.Raw.liga.json");
            using StreamReader reader2 = new StreamReader(inputStream2);
            var data2 = reader2.ReadToEnd();
            Liga = JsonConvert.DeserializeObject<List<FootballMarket>>(data2);

            Stream inputStream3 = executingAssembly.GetManifestResourceStream("FootballSpentEarned.Resources.Raw.ligue1.json");
            using StreamReader reader3 = new StreamReader(inputStream3);
            var data3 = reader3.ReadToEnd();
            Ligue1 = JsonConvert.DeserializeObject<List<FootballMarket>>(data3);

            Stream inputStream4 = executingAssembly.GetManifestResourceStream("FootballSpentEarned.Resources.Raw.bundesliga.json");
            using StreamReader reader4 = new StreamReader(inputStream4);
            var data4 = reader4.ReadToEnd();
            Bundesliga = JsonConvert.DeserializeObject<List<FootballMarket>>(data4);

            Stream inputStream5 = executingAssembly.GetManifestResourceStream("FootballSpentEarned.Resources.Raw.seriea.json");
            using StreamReader reader5 = new StreamReader(inputStream5);
            var data5 = reader5.ReadToEnd();
            serieA = JsonConvert.DeserializeObject<List<FootballMarket>>(data5);
        }
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }


}

