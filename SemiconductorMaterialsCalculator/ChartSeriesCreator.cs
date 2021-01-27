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
        public ChartSeriesCreator()
        { }
        public ChartSeriesCreator(List<double> arguments, List<double> values)
        {
            var collectionConverter = new CollectionTypeConverter();
            _arguments = collectionConverter.ConvertListToStringListCollection(arguments);
            _values = collectionConverter.ConvertListToChartValuesCollection(values);
        }
        public CartesianChart FillChartwithSeries(CartesianChart cartesianChart)
        {
            cartesianChart.Series = new SeriesCollection
            {
                new LineSeries(_values)
                {
                    Title = "E_c",
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
        public CartesianChart FormateTheChart(CartesianChart cartesianChart, List<double> seriesArguments)
        {
            var collectionConverter = new CollectionTypeConverter();
            var arguments = collectionConverter.ConvertListToStringListCollection(seriesArguments);

            cartesianChart.AxisX.Add(new Axis
            {
                Title = "thickness",
                LabelFormatter = value => value.ToString("N"),
                Labels = arguments,
                ShowLabels = true
            });

            cartesianChart.AxisY.Add(new Axis
            {
                Title = "energy values",
                LabelFormatter = value => value.ToString("N")
            });

            cartesianChart.LegendLocation = LegendLocation.Right;

            return cartesianChart;
        }
        public CartesianChart AddSeriesToChart(CartesianChart cartesianChart, string seriesName1, string seriesName2, string seriesName3, string seriesName4, List<double> seriesArguments, List<double> seriesValues1, List<double> seriesValues2, List<double> seriesValues3, List<double> seriesValues4)
        {
            var collectionConverter = new CollectionTypeConverter();
            var values1 = collectionConverter.ConvertListToChartValuesCollection(seriesValues1);
            var values2 = collectionConverter.ConvertListToChartValuesCollection(seriesValues2);
            var values3 = collectionConverter.ConvertListToChartValuesCollection(seriesValues3);
            var values4 = collectionConverter.ConvertListToChartValuesCollection(seriesValues4);
            cartesianChart.Series = new SeriesCollection
            {
                new LineSeries(values1)
                {
                    Title = seriesName1,
                    Values = values1
                },
                new LineSeries(values2)
                {
                    Title = seriesName2,
                    Values = values2
                },
                new LineSeries(values3)
                {
                    Title = seriesName3,
                    Values = values3
                },
                new LineSeries(values4)
                {
                    Title = seriesName4,
                    Values = values4
                }
            };

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
