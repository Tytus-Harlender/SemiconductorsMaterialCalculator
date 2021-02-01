using System;
using System.IO;
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
        private EnergyChartDataCalculator _createdEnergySeries;
        private InterpolationChartCalculator _createdInterpolationSeries;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void CreateButton_Click(object sender, EventArgs e)
        {
            InputValues inputParameters = new InputValues(SequanceChoiceNumber,aParamNumericUpDown, bParamNumericUpDown, xParamLay2, yParamLay2, xParamLay3, yParamLay3, TemperatureUpDown, LayerIThicknessUpDown, LayerIIThicknessUpDown, LayerIIIThicknessUpDown, LayerIVThicknessUpDown, LayerVThicknessUpDown, InterChartUpDown1, InterChartUpDown2,InterChartUpDown3, interChartResolution, EnergyChartResolution);

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
            InputValues inputParameters = new InputValues(SequanceChoiceNumber,xParamLay1, yParamLay1, xParamLay2, yParamLay2, xParamLay3, yParamLay3, TemperatureUpDown,LayerIThicknessUpDown,LayerIIThicknessUpDown,LayerIIIThicknessUpDown,LayerIVThicknessUpDown,LayerVThicknessUpDown, InterChartUpDown1, InterChartUpDown2, InterChartUpDown3, interChartResolution,EnergyChartResolution);
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
                _createdEnergySeries = newEnergyChartDataCalculator;
                var argumentsOfChart = newEnergyChartDataCalculator.ArgumentsOfChart;
                var seriesForEc = newEnergyChartDataCalculator.SeriesForEc;
                var seriesForEhh = newEnergyChartDataCalculator.SeriesForEhh;
                var seriesForElh = newEnergyChartDataCalculator.SeriesForElh;
                var seriesForEsh = newEnergyChartDataCalculator.SeriesForEsh;
                ChartSeriesCreator newChartCreator = new ChartSeriesCreator();
                newChartCreator.ClearAllChart(cartesianChart1);
                newChartCreator.FormateTheChart(cartesianChart1,argumentsOfChart, "thickness", "Energies");
                newChartCreator.AddSeriesToChart(cartesianChart1, "Ec","Ehh", "Elh", "Esh", argumentsOfChart, seriesForEc,seriesForEhh,seriesForElh,seriesForEsh);
                
            }
            else
            {
                MessageBox.Show("Please calculate interpolation before you create energy chart");
            }
        }
        private void CreateInterChartButton_Click(object sender, EventArgs e)
        {
            if (_newLayersSets != null)
            {
                InterpolationChartCalculator newInterpolationChartCalculator = new InterpolationChartCalculator(_currentInputValues);
                _createdInterpolationSeries = newInterpolationChartCalculator;
                var argumentsOfChart = newInterpolationChartCalculator.ArgumentsList;
                var seriesA = newInterpolationChartCalculator.ListA;
                var seriesEg = newInterpolationChartCalculator.ListEg;
                var seriesAlpha = newInterpolationChartCalculator.ListAlpha;
                var seriesBetha = newInterpolationChartCalculator.ListBetha;
                var seriesDelta_so = newInterpolationChartCalculator.ListDelta_so;
                var seriesMass_e = newInterpolationChartCalculator.ListMass_e;
                var seriesMass_hh = newInterpolationChartCalculator.ListMass_hh;
                var seriesMass_lh = newInterpolationChartCalculator.ListMass_lh;
                var seriesA_c = newInterpolationChartCalculator.ListA_c;
                var seriesA_v = newInterpolationChartCalculator.ListA_v;
                var seriesB = newInterpolationChartCalculator.ListB;
                var seriesVBO = newInterpolationChartCalculator.ListVBO;
                var seriesC_11 = newInterpolationChartCalculator.ListC_11;
                var seriesC_12 = newInterpolationChartCalculator.ListC_12;

                ChartSeriesCreator newChartCreator = new ChartSeriesCreator();
                newChartCreator.ClearAllChart(cartesianChart2);
                newChartCreator.FormateTheChart(cartesianChart2, argumentsOfChart, "not fixed parameter Values", "band parameters values");
                newChartCreator.AddSeriesToChart(cartesianChart2, "A","Eg","Alpha","Betha","Delta_so","Mass_e","Mass_hh","Mass_lh","A_c","A_v","B","VBO","C_11","C_12",seriesA,seriesEg,seriesAlpha,seriesBetha,seriesDelta_so,seriesMass_e,seriesMass_hh,seriesMass_lh,seriesA_c,seriesA_v,seriesB,seriesVBO,seriesC_11,seriesC_12);
            }
            else
            {
                MessageBox.Show("Please calculate interpolation before you create interpolation chart");
            }
        }
        private void SaveChart1Button_Click(object sender, EventArgs e)
        {
            if (_createdEnergySeries != null)
            {
                using (TextWriter tw = new StreamWriter(@"C:\Users\Tytus\Desktop\SavedEnergiesChart.txt"))
                {
                    for(int i= 1; i<= _createdEnergySeries.ArgumentsOfChart.Count-2;i++)
                    {
                        tw.Write(_createdEnergySeries.ArgumentsOfChart[i]);
                        tw.Write("\t");
                        tw.Write(_createdEnergySeries.SeriesForEc[i]);
                        tw.Write("\t");
                        tw.Write(_createdEnergySeries.SeriesForEhh[i]);
                        tw.Write("\t");
                        tw.Write(_createdEnergySeries.SeriesForElh[i]);
                        tw.Write("\t");
                        tw.Write(_createdEnergySeries.SeriesForEsh[i]);
                        tw.WriteLine();
                    }
                }
                MessageBox.Show(@"Energy chart data saved to path: C:\Users\Tytus\Desktop\SavedEnergiesChart.txt");
            }
            else
            {
                MessageBox.Show("Please, create the energy chart before saving to file");
            }
        }
        private void SaveChart2Button_Click(object sender, EventArgs e)
        {
            if (_createdInterpolationSeries != null)
            {
                using (TextWriter tw = new StreamWriter(@"C:\Users\Tytus\Desktop\SavedInterpolationChart.txt"))
                {
                    for (int i = 1; i <= _createdInterpolationSeries.ArgumentsList.Count - 1; i++)
                    {
                        tw.Write(_createdInterpolationSeries.ArgumentsList[i]);
                        tw.Write("\t\t");
                        tw.Write(_createdInterpolationSeries.ListA[i]);
                        tw.Write("\t\t");
                        tw.Write(_createdInterpolationSeries.ListEg[i]);
                        tw.Write("\t\t");
                        tw.Write(_createdInterpolationSeries.ListAlpha[i]);
                        tw.Write("\t\t");
                        tw.Write(_createdInterpolationSeries.ListBetha[i]);
                        tw.Write("\t\t");
                        tw.Write(_createdInterpolationSeries.ListDelta_so[i]);
                        tw.Write("\t\t");
                        tw.Write(_createdInterpolationSeries.ListMass_e[i]);
                        tw.Write("\t\t");
                        tw.Write(_createdInterpolationSeries.ListMass_hh[i]);
                        tw.Write("\t\t");
                        tw.Write(_createdInterpolationSeries.ListMass_lh[i]);
                        tw.Write("\t\t");
                        tw.Write(_createdInterpolationSeries.ListA_c[i]);
                        tw.Write("\t\t");
                        tw.Write(_createdInterpolationSeries.ListA_v[i]);
                        tw.Write("\t\t");
                        tw.Write(_createdInterpolationSeries.ListB[i]);
                        tw.Write("\t\t");
                        tw.Write(_createdInterpolationSeries.ListVBO[i]);
                        tw.Write("\t\t");
                        tw.Write(_createdInterpolationSeries.ListC_11[i]);
                        tw.Write("\t\t");
                        tw.Write(_createdInterpolationSeries.ListC_12[i]);
                        tw.Write("\t\t");
                        tw.WriteLine();
                    }
                }
                MessageBox.Show(@"Interpolation chart data saved to path: C:\Users\Tytus\Desktop\SavedInterpolationChart.txt");
            }
            else
            {
                MessageBox.Show("Please, create the interpolation chart before saving to file");
            }
        }
    }
}
