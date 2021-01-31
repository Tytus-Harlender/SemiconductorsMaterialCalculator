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
        public CartesianChart FormateTheChart(CartesianChart cartesianChart, List<double> seriesArguments, string AxisXTitle, string AxisYTitle)
        {
            var collectionConverter = new CollectionTypeConverter();
            var arguments = collectionConverter.ConvertListToStringListCollection(seriesArguments);

            cartesianChart.AxisX.Add(new Axis
            {
                Title = AxisXTitle,
                LabelFormatter = value => value.ToString("N"),
                Labels = arguments,
                ShowLabels = true
            });

            cartesianChart.AxisY.Add(new Axis
            {
                Title = AxisYTitle,
                LabelFormatter = value => value.ToString("N")
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

        public CartesianChart AddSeriesToChart(CartesianChart cartesianChart, string seriesName1, string seriesName2, string seriesName3, string seriesName4, string seriesName5, string seriesName6, string seriesName7, string seriesName8, string seriesName9, string seriesName10, string seriesName11, string seriesName12, string seriesName13, string seriesName14, List<double> seriesValues1, List<double> seriesValues2, List<double> seriesValues3, List<double> seriesValues4, List<double> seriesValues5, List<double> seriesValues6, List<double> seriesValues7, List<double> seriesValues8, List<double> seriesValues9, List<double> seriesValues10, List<double> seriesValues11, List<double> seriesValues12, List<double> seriesValues13, List<double> seriesValues14)
        {
            var collectionConverter = new CollectionTypeConverter();
            var values1 = collectionConverter.ConvertListToChartValuesCollection(seriesValues1);
            var values2 = collectionConverter.ConvertListToChartValuesCollection(seriesValues2);
            var values3 = collectionConverter.ConvertListToChartValuesCollection(seriesValues3);
            var values4 = collectionConverter.ConvertListToChartValuesCollection(seriesValues4);
            var values5 = collectionConverter.ConvertListToChartValuesCollection(seriesValues5);
            var values6 = collectionConverter.ConvertListToChartValuesCollection(seriesValues6);
            var values7 = collectionConverter.ConvertListToChartValuesCollection(seriesValues7);
            var values8 = collectionConverter.ConvertListToChartValuesCollection(seriesValues8);
            var values9 = collectionConverter.ConvertListToChartValuesCollection(seriesValues9);
            var values10 = collectionConverter.ConvertListToChartValuesCollection(seriesValues10);
            var values11 = collectionConverter.ConvertListToChartValuesCollection(seriesValues11);
            var values12 = collectionConverter.ConvertListToChartValuesCollection(seriesValues12);
            var values13 = collectionConverter.ConvertListToChartValuesCollection(seriesValues13);
            var values14 = collectionConverter.ConvertListToChartValuesCollection(seriesValues14);

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
                },
                new LineSeries(values5)
                {
                    Title = seriesName5,
                    Values = values5
                },
                new LineSeries(values6)
                {
                    Title = seriesName6,
                    Values = values6
                },
                new LineSeries(values7)
                {
                    Title = seriesName7,
                    Values = values7
                },
                new LineSeries(values8)
                {
                    Title = seriesName8,
                    Values = values8
                },
                new LineSeries(values9)
                {
                    Title = seriesName9,
                    Values = values9
                },
                new LineSeries(values10)
                {
                    Title = seriesName10,
                    Values = values10
                },
                new LineSeries(values11)
                {
                    Title = seriesName11,
                    Values = values11
                },
                new LineSeries(values12)
                {
                    Title = seriesName12,
                    Values = values12
                },
                new LineSeries(values13)
                {
                    Title = seriesName13,
                    Values = values13
                },
                new LineSeries(values14)
                {
                    Title = seriesName14,
                    Values = values14
                }
            };

            return cartesianChart;
        }
    }
}
