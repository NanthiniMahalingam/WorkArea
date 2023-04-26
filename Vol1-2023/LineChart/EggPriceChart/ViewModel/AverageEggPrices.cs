using EggPriceChart;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EggPriceChart
{
    public class AverageEggPrices : INotifyPropertyChanged
    {
        private List<EggPriceModel> averagePrices;
        public List<EggPriceModel> AveragePrices
        { 
            get{ return averagePrices; }
            set
            {
                averagePrices = value;
                NotifyPropertyChanged(nameof(AveragePrices));
            }
        }

        public AverageEggPrices()
        {
            AveragePrices = new List<EggPriceModel>(ReadCSV());
        }

        public IEnumerable<EggPriceModel> ReadCSV()
        {
            Assembly executingAssembly = typeof(App).GetTypeInfo().Assembly;
            Stream inputStream = executingAssembly.GetManifestResourceStream("EggPriceChart.Resources.Raw.eggpricechart.csv");

            string? line;
            List<string> lines = new List<string>();

            using StreamReader reader = new StreamReader(inputStream);
            while ((line = reader.ReadLine()) != null)
            {
                lines.Add(line);
            }

            return lines.Select(line =>
            {
                string[] data = line.Split(',');
                DateTime date = DateTime.ParseExact(data[0], "MMMM", CultureInfo.InvariantCulture);
                return new EggPriceModel((date), Convert.ToDouble(data[1]));
            });
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
