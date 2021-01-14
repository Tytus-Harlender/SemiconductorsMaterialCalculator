using System;
using System.Collections.Generic;
using System.Windows.Forms;
using LiveCharts.WinForms;

namespace SemiconductorMaterialsCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void CreateButton_Click(object sender, EventArgs e)
        {
            List<int> inputParametersList = GetParameters();
            if (inputParametersList.Count==2)
            {
                ChartCalculator newChartCalculator = new ChartCalculator(inputParametersList);
                var arguments = newChartCalculator.ArgumentsOfChart;
                var values = newChartCalculator.ValuesOfChart;
                FillChart(cartesianChart1, arguments, values);
            }
        }
        private void FillChart(CartesianChart chartToFill, List<double> arguments, List<double> values)
        {
            ChartSeriesCreator seriesCreator = new ChartSeriesCreator(arguments, values);
            seriesCreator.FillChartwithSeries(chartToFill);
        }
        private List<int> GetParameters()
        {
            List<int> parametersList = new List<int>();
            if (int.TryParse(domainUpDown1.Text, out int result1))
            {
                parametersList.Add(result1);
            }
            else
            {
                MessageBox.Show("Please check parameter a value!");
            }
            if (int.TryParse(domainUpDown2.Text, out int result2))
            {
                parametersList.Add(result2);
            }
            else
            {
                MessageBox.Show("Please check parameter b value!");
            }
            return parametersList;
        }
    }
}
