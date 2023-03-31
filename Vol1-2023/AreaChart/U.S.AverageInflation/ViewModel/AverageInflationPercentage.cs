using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace U.S.AverageInflation
{
    public class AverageInflationPercentage : INotifyPropertyChanged
    {
        public List<Brush> CustomBrushes { get; set; }

        public List<Brush> CustomBrushes1 { get; set; }
        private List<InflationModel> positiveAveragePercentage;
        public List<InflationModel> PositiveAveragePercentage 
        {
            get
            {
                return positiveAveragePercentage;
            }
            set
            {
                positiveAveragePercentage = value;
                NotifyPropertyChanged(nameof(PositiveAveragePercentage));
            }
        }

        private List<InflationModel> negativeAveragePercentage;
        public List<InflationModel> NegativeAveragePercentage
        {
            get
            {
                return negativeAveragePercentage;
            }
            set
            {
                negativeAveragePercentage = value;
                NotifyPropertyChanged(nameof(NegativeAveragePercentage));
            }
        }

        private List<InflationModel> data;
        public List<InflationModel> Data
        {
            get
            {
                return data;
            }
            set
            {
                data = value;
                NotifyPropertyChanged(nameof(Data));
            }
        }

        public AverageInflationPercentage()
        {
            GenerateData();

           // Data = new List<InflationModel>(ReadCSV());

            CustomBrushes = new List<Brush>();

            LinearGradientBrush linearGradientBrush = new LinearGradientBrush();
            linearGradientBrush.StartPoint = new Point(0.5, 0);
            linearGradientBrush.EndPoint = new Point(0.5, 1);

            GradientStop stop1 = new GradientStop() { Offset = 0, Color = Colors.DarkGreen };

            GradientStop stop2 = new GradientStop() { Offset = 1, Color = Colors.White };
            linearGradientBrush.GradientStops.Add(stop1);
            linearGradientBrush.GradientStops.Add((stop2));

            CustomBrushes1 = new List<Brush>();

            LinearGradientBrush linearGradientBrush1 = new LinearGradientBrush();
            linearGradientBrush1.StartPoint = new Point(0.5, 1);
            linearGradientBrush1.EndPoint = new Point(0.5, 0);

            GradientStop stop3 = new GradientStop() { Offset = 1, Color = Colors.White };

            GradientStop stop4 = new GradientStop() { Offset = 0, Color = Colors.Yellow };
            linearGradientBrush1.GradientStops.Add(stop3);
            linearGradientBrush1.GradientStops.Add((stop4));

            CustomBrushes.Add(linearGradientBrush);
            CustomBrushes1.Add(linearGradientBrush1);
        }


        public IEnumerable<InflationModel> ReadCSV()
        {
            Assembly executingAssembly = typeof(App).GetTypeInfo().Assembly;
            Stream inputStream = executingAssembly.GetManifestResourceStream("U.S.AverageInflation.Resources.Raw.usinflationindexedlongtermaverage.csv"); string? line;
            List<string> lines = new List<string>(); using StreamReader reader = new StreamReader(inputStream);
            while ((line = reader.ReadLine()) != null)
            {
                lines.Add(line);
            }

            return lines.Select(line =>
            {
                string[] data = line.Split(',');
                DateTime date = DateTime.ParseExact(data[0], "yyyy-mm", CultureInfo.InvariantCulture);
                return new InflationModel((date), Convert.ToDouble(data[1]));
            });
        }

        public void GenerateData()
        {
            Assembly executingAssembly = typeof(App).GetTypeInfo().Assembly;
            Stream inputStream = executingAssembly.GetManifestResourceStream("U.S.AverageInflation.Resources.Raw.usinflationindexedlongtermaverage.csv"); string? line;
            List<string> lines = new List<string>(); using StreamReader reader = new StreamReader(inputStream);
            while ((line = reader.ReadLine()) != null)
            {
                lines.Add(line);
            }

            PositiveAveragePercentage = new List<InflationModel>();
            NegativeAveragePercentage = new List<InflationModel>();

            var collection = lines.Select(line => line.Split(','));
            foreach (var dataPoints in collection)
            {
                var data1 = dataPoints[0];
                var data2 = dataPoints[1];

                DateTime date = DateTime.ParseExact(data1, "yyyy-mm", CultureInfo.InvariantCulture);
                if (Convert.ToDouble(data2) >= 0)
                {
                    PositiveAveragePercentage.Add(new InflationModel(date, Convert.ToDouble(data2)));
                }
                else
                {
                    NegativeAveragePercentage.Add(new InflationModel(date, Convert.ToDouble(data2)));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
