using System;
using System.Collections.Generic;
using System.Windows.Forms;
using LiveCharts;

namespace SemiconductorMaterialsCalculator
{
    public class CollectionTypeConverter
    {
        public ChartValues<double> ConvertListToChartValuesCollection(List<double> listToConvert)
        {
            ChartValues<double> chartToReturn = new ChartValues<double>();
            foreach (double a in listToConvert)
            {
                chartToReturn.Add(a);
            }
            return chartToReturn;
        }
        public double[] ConvertListToDoubleArrayCollection(List<double> listToConvert)
        {
            double[] arrayToReturn = new double[listToConvert.Count];
            int spot;
            foreach (double a in listToConvert)
            {
                spot = listToConvert.IndexOf(a);
                arrayToReturn[spot] = a;
            }
            return arrayToReturn;
        }
        public List<string> ConvertListToStringListCollection(List<double> listToConvert)
        {
            List<string> stringListToReturn = new List<string>();
            foreach (double a in listToConvert)
            {
                var i = a.ToString();
                stringListToReturn.Add(i);
            }
            return stringListToReturn;
        }
    }
}
