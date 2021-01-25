using System;
using System.Windows.Forms;

namespace SemiconductorMaterialsCalculator
{
    public partial class Form1 : Form
    {
        private LayersInterpolationSets _newLayersSets;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void CreateButton_Click(object sender, EventArgs e)
        {
            InputValues inputParameters = new InputValues(SequanceChoiceNumber,aParamNumericUpDown, bParamNumericUpDown, xParamLay2, yParamLay2, xParamLay3, yParamLay3, TemperatureUpDown);

            if (!inputParameters.InputValuesList.Contains(0))
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
            InputValues inputParameters = new InputValues(SequanceChoiceNumber,xParamLay1, yParamLay1, xParamLay2, yParamLay2, xParamLay3, yParamLay3, TemperatureUpDown);

            if (!inputParameters.InputValuesList.Contains(0))
            {
                LayerInterpolation newInterpolation = new LayerInterpolation();
                var layer1Set = newInterpolation.InterpolateLayer(inputParameters,1);
                var layer2Set = newInterpolation.InterpolateLayer(inputParameters, 2);
                var layer3Set = newInterpolation.InterpolateLayer(inputParameters, 3);
                LayersInterpolationSets newLayersSets = new LayersInterpolationSets(layer1Set, layer2Set, layer3Set);
                _newLayersSets = newLayersSets;
            }
        }

        private void EnergyChartCreationButton_Click(object sender, EventArgs e)
        {
            if (_newLayersSets != null)
            {
                LayerEnergiesCalculator newLayerEnergiesCalc = new LayerEnergiesCalculator();
                var energiesLayerOne = newLayerEnergiesCalc.CalculateEnergiesSet(_newLayersSets.LayerOneSet);
                var energiesLayerTwo = newLayerEnergiesCalc.CalculateEnergiesSet(_newLayersSets.LayerTwoSet);
                var energiesLayerThree = newLayerEnergiesCalc.CalculateEnergiesSet(_newLayersSets.LayerThreeSet);
            }
            else
            {
                MessageBox.Show("Please calculate interpolation before you create energy chart");
            }
        }
    }
}
