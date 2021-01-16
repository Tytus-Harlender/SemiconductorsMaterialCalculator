using System.Collections.Generic;
using LiveCharts.WinForms;

namespace SemiconductorMaterialsCalculator
{
    public class ChartDraughtsClass
    {
        public void FillChart(CartesianChart chartToFill, List<double> arguments, List<double> values)
        {
            ChartSeriesCreator seriesCreator = new ChartSeriesCreator(arguments, values);
            seriesCreator.FillChartwithSeries(chartToFill);
        }
    }
}
