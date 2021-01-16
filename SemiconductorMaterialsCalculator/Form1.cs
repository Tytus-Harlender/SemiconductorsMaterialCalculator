using System;
using System.Windows.Forms;

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
            InputValues inputParameters = new InputValues(domainUpDown1, domainUpDown2);
            
            if (inputParameters.InputValuesList.Count==2)
            {
                ChartCalculator newChartCalculator = new ChartCalculator(inputParameters.InputValuesList);
                var arguments = newChartCalculator.ArgumentsOfChart;
                var values = newChartCalculator.ValuesOfChart;
                ChartDraughtsClass chartPainter = new ChartDraughtsClass();
                chartPainter.FillChart(cartesianChart1, arguments, values);
            }
        }
        private void InterpolateButton_Click(object sender, EventArgs e)
        {
            InputValues inputParameters = new InputValues(xGaInAsSbDomain, yGaInAsSbDomain);

            if (!inputParameters.InputValuesList.Contains(0))
            {
                var x = inputParameters.InputValuesList[0];
                var y = inputParameters.InputValuesList[1];
                BandStructureParametersNames paramNames = new BandStructureParametersNames();
                foreach (var paramName in paramNames.ListOfBandStructureParameters)
                {
                    Interpolator interpolator = new Interpolator(paramName);
                    var outcome = interpolator.InterpolateFourElements(x, y);
                    MessageBox.Show($"{paramName}:{outcome.ToString()}");
                }
            }
        }
    }
}
