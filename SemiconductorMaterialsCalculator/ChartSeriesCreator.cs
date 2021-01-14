using System.Collections.Generic;
using LiveCharts;
using LiveCharts.Wpf;
using CartesianChart = LiveCharts.WinForms.CartesianChart;

namespace SemiconductorMaterialsCalculator
{
    public class ChartSeriesCreator
    {
        private List<string> _arguments;
        private ChartValues<double> _values;
        public ChartSeriesCreator(List<double> arguments, List<double> values)
        {
            var collectionConverter = new CollectionTypeConverter();
            _arguments = collectionConverter.ConvertListToStringListCollection(arguments);
            _values = collectionConverter.ConvertListToChartValuesCollection(values);
        }
        public CartesianChart FillChartwithSeries(CartesianChart cartesianChart)
        {
            cartesianChart = ClearAllChart(cartesianChart);


            cartesianChart.Series = new SeriesCollection
            {
                new LineSeries(_values)
                {
                    Title = "y=a*x+b",
                    Values = _values
                }
            };
            
            cartesianChart.AxisX.Add(new Axis
            {
                Title = "OX",
                Labels = _arguments,
                ShowLabels = true
            });

            cartesianChart.AxisY.Add(new Axis
            {
                Title = "OY",
                LabelFormatter = value => value.ToString("C")
            });

            cartesianChart.LegendLocation = LegendLocation.Right;

            return cartesianChart;
        }

        public CartesianChart ClearAllChart(CartesianChart cartesianChart)
        {
            cartesianChart.Series.Clear();
            cartesianChart.AxisX.Clear();
            cartesianChart.AxisY.Clear();
            return cartesianChart;
        }
    }
}
