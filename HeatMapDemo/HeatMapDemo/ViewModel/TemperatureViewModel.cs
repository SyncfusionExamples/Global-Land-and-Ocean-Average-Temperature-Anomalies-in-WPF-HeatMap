using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Reflection;

namespace HeatMapDemo
{
    public class TemperatureViewModel
    {
        public ObservableCollection<TemperatureModel> TemperatureData { get; set; }
        public TemperatureViewModel()
        {
            TemperatureData = new ObservableCollection<TemperatureModel >();
            ReadCSV();
        }

        private void ReadCSV()
        {
            Assembly executingAssembly = typeof(App).GetTypeInfo().Assembly;
            Stream inputStream = executingAssembly.GetManifestResourceStream("HeatMapDemo.Data.TemperatureData.csv");

            if (inputStream != null)
            {
                string line;
                List<String> lines = new List<String>();
                StreamReader reader = new StreamReader(inputStream);
                while ((line = reader.ReadLine()) != null)
                {
                    lines.Add(line);
                }

                lines.RemoveAt(0);

                foreach (var dataPoint in lines)
                {
                    var data = dataPoint.Split(',');
                    string year = data[0];
                    var monthlyTemperatures = data.Skip(1).Select(double.Parse).ToArray();

                    TemperatureData.Add(new TemperatureModel(year, monthlyTemperatures[0], monthlyTemperatures[1],
                        monthlyTemperatures[2], monthlyTemperatures[3], monthlyTemperatures[4], monthlyTemperatures[5],
                        monthlyTemperatures[6], monthlyTemperatures[7], monthlyTemperatures[8], monthlyTemperatures[9],
                        monthlyTemperatures[10], monthlyTemperatures[11]));
                }
            }
        }
    }
}
