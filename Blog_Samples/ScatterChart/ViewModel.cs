using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ScatterChart
{
    public class ViewModel
    {
        private List<Model>? populationDataSet;
        public List<Model>? PopulationDataSet
        {
            get { return populationDataSet; }
            set
            {
                populationDataSet = value;
                NotifyPropertyChanged(nameof(PopulationDataSet));
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public ViewModel()
        {
            PopulationDataSet = new List<Model>(ReadCSV());
        }

        public IEnumerable<Model> ReadCSV()
        {
            Assembly executingAssembly = typeof(App).GetTypeInfo().Assembly;
            Stream? inputStream = executingAssembly.GetManifestResourceStream("ScatterChart.Resources.Raw.population_data_2022.csv");

            string? line;
            List<string> lines = new List<string>();

            using StreamReader reader = new StreamReader(inputStream);
            while ((line = reader.ReadLine()) != null)
            {
                lines.Add(line);
            }
            lines.RemoveAt(0);
            return lines.Select(line =>
            {
                string[] data = line.Split(',');
                // DateTime date = DateTime.ParseExact(data[0], "yyyy", CultureInfo.InvariantCulture);
                //  return new Model(data[0], Convert.ToDouble(data[1]), Convert.ToDouble(data[2]), Convert.ToDouble(data[3]));
                return new Model(data[0], Convert.ToDouble(data[1]), data[2]);
            });
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
