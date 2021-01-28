using System;
using System.Windows.Forms;

namespace SemiconductorMaterialsCalculator
{
    public partial class Form1 : Form
    {
        private InputValues _currentInputValues;
        private FoundationGaSbParameters _newFoundationParameters;
        private LayersInterpolationSets _newLayersSets;
        private LayersEnergiesSets _newLayersEnergies;
        private LayerEnergiesSet _newFoundationEnergies;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void CreateButton_Click(object sender, EventArgs e)
        {
            InputValues inputParameters = new InputValues(SequanceChoiceNumber,aParamNumericUpDown, bParamNumericUpDown, xParamLay2, yParamLay2, xParamLay3, yParamLay3, TemperatureUpDown, LayerIThicknessUpDown, LayerIIThicknessUpDown, LayerIIIThicknessUpDown, LayerIVThicknessUpDown, LayerVThicknessUpDown);

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
            InputValues inputParameters = new InputValues(SequanceChoiceNumber,xParamLay1, yParamLay1, xParamLay2, yParamLay2, xParamLay3, yParamLay3, TemperatureUpDown,LayerIThicknessUpDown,LayerIIThicknessUpDown,LayerIIIThicknessUpDown,LayerIVThicknessUpDown,LayerVThicknessUpDown);
            _currentInputValues = inputParameters;

            if (!inputParameters.InputValuesList.Contains(0))
            {
                FoundationGaSbParameters newFoundationParameters = new FoundationGaSbParameters();
                LayerInterpolation newInterpolation = new LayerInterpolation();
                var layer1Set = newInterpolation.InterpolateLayer(inputParameters,1);
                var layer2Set = newInterpolation.InterpolateLayer(inputParameters, 2);
                var layer3Set = newInterpolation.InterpolateLayer(inputParameters, 3);
                LayersInterpolationSets newLayersSets = new LayersInterpolationSets(layer1Set, layer2Set, layer3Set);
                _newLayersSets = newLayersSets;
                _newFoundationParameters = newFoundationParameters;
            }
        }

        private void EnergyChartCreationButton_Click(object sender, EventArgs e)
        {
            if (_newLayersSets != null)
            {
                LayerEnergiesCalculator newLayerEnergiesCalc = new LayerEnergiesCalculator(_newFoundationParameters.A);
                var foundationEnergies = newLayerEnergiesCalc.CalculateFoundationEnergiesSet(_newFoundationParameters);
                var energiesLayerOne = newLayerEnergiesCalc.CalculateEnergiesSet(_newLayersSets.LayerOneSet);
                var energiesLayerTwo = newLayerEnergiesCalc.CalculateEnergiesSet(_newLayersSets.LayerTwoSet);
                var energiesLayerThree = newLayerEnergiesCalc.CalculateEnergiesSet(_newLayersSets.LayerThreeSet);
                LayersEnergiesSets newLayersEnergySets = new LayersEnergiesSets(energiesLayerOne, energiesLayerTwo, energiesLayerThree);
                _newLayersEnergies = newLayersEnergySets;
                _newFoundationEnergies = foundationEnergies;
                EnergyChartDataCalculator newEnergyChartDataCalculator = new EnergyChartDataCalculator(_currentInputValues,_newLayersEnergies,_newFoundationEnergies);
                var argumentsOfChart = newEnergyChartDataCalculator.ArgumentsOfChart;
                var seriesForEc = newEnergyChartDataCalculator.SeriesForEc;
                var seriesForEhh = newEnergyChartDataCalculator.SeriesForEhh;
                var seriesForElh = newEnergyChartDataCalculator.SeriesForElh;
                var seriesForEsh = newEnergyChartDataCalculator.SeriesForEsh;
                ChartSeriesCreator newChartCreator = new ChartSeriesCreator();
                newChartCreator.ClearAllChart(cartesianChart1);
                newChartCreator.FormateTheChart(cartesianChart1,argumentsOfChart);
                newChartCreator.AddSeriesToChart(cartesianChart1, "Ec","Ehh", "Elh", "Esh", argumentsOfChart, seriesForEc,seriesForEhh,seriesForElh,seriesForEsh);
            }
            else
            {
                MessageBox.Show("Please calculate interpolation before you create energy chart");
            }
        }

        private void SaveChart1Button_Click(object sender, EventArgs e)
        {

        }
    }
}
