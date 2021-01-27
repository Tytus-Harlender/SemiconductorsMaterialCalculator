using System;
using System.Collections.Generic;

namespace SemiconductorMaterialsCalculator
{
    public class EnergyChartDataCalculator:ChartCalculator
    {
        private InputValues _inputValuesFromUser;
        private LayersEnergiesSets _setsOfLayersEnergies;
        private LayerEnergiesSet _setOfFoundationLayerEnergies;
        public List<double> SeriesForEc { get; set; }
        public List<double> SeriesForEhh { get; set; }
        public List<double> SeriesForElh { get; set; }
        public List<double> SeriesForEsh { get; set; }
        public EnergyChartDataCalculator(InputValues inputValuesFromUser,LayersEnergiesSets setsOfLayersEnergies, LayerEnergiesSet setOfFoundationEnergies)
        {
            _inputValuesFromUser = inputValuesFromUser;
            _setsOfLayersEnergies = setsOfLayersEnergies;
            _setOfFoundationLayerEnergies = setOfFoundationEnergies;
            ArgumentsOfChart = DefineXDomaine();
            SeriesForEc = CalculateEcSeries();
            SeriesForEhh = CalculateEhhSeries();
            SeriesForElh = CalculateElhSeries();
            SeriesForEsh = CalculateEshSeries();
        }

        private List<double> CalculateEcSeries()
        {
            List<double> newEnergySeries = new List<double>();
            var y1 = _setOfFoundationLayerEnergies.E_c;
            var y2 = _setsOfLayersEnergies.LayerOneSet.E_c;
            var y3 = _setsOfLayersEnergies.LayerTwoSet.E_c;
            var y4 = _setsOfLayersEnergies.LayerThreeSet.E_c;
            var y5 = _setOfFoundationLayerEnergies.E_c;
            newEnergySeries = CreateSeriesWithProperThicknessDivision(newEnergySeries, y1, y2, y3, y4, y5);
            return newEnergySeries;
        }
        private List<double> CalculateEhhSeries()
        {
            List<double> newEnergySeries = new List<double>();
            var y1 = _setOfFoundationLayerEnergies.E_hh;
            var y2 = _setsOfLayersEnergies.LayerOneSet.E_hh;
            var y3 = _setsOfLayersEnergies.LayerTwoSet.E_hh;
            var y4 = _setsOfLayersEnergies.LayerThreeSet.E_hh;
            var y5 = _setOfFoundationLayerEnergies.E_hh;
            newEnergySeries = CreateSeriesWithProperThicknessDivision(newEnergySeries, y1, y2, y3, y4, y5);
            return newEnergySeries;
        }
        private List<double> CalculateElhSeries()
        {
            List<double> newEnergySeries = new List<double>();
            var y1 = _setOfFoundationLayerEnergies.E_lh;
            var y2 = _setsOfLayersEnergies.LayerOneSet.E_lh;
            var y3 = _setsOfLayersEnergies.LayerTwoSet.E_lh;
            var y4 = _setsOfLayersEnergies.LayerThreeSet.E_lh;
            var y5 = _setOfFoundationLayerEnergies.E_lh;
            newEnergySeries = CreateSeriesWithProperThicknessDivision(newEnergySeries, y1, y2, y3, y4, y5);
            return newEnergySeries;
        }
        private List<double> CalculateEshSeries()
        {
            List<double> newEnergySeries = new List<double>();
            var y1 = _setOfFoundationLayerEnergies.E_sh;
            var y2 = _setsOfLayersEnergies.LayerOneSet.E_sh;
            var y3 = _setsOfLayersEnergies.LayerTwoSet.E_sh;
            var y4 = _setsOfLayersEnergies.LayerThreeSet.E_sh;
            var y5 = _setOfFoundationLayerEnergies.E_sh;
            newEnergySeries = CreateSeriesWithProperThicknessDivision(newEnergySeries, y1, y2, y3, y4, y5);
            return newEnergySeries;
        }
        private List<double> DefineXDomaine()
        {
            List<double> xDomaine = new List<double>();
            var totalThickness = AddAllThickness();
            for (int i = 0; i <= totalThickness; i++)
            {
                xDomaine.Add(i);
            }
            return xDomaine;
        }
        private double AddAllThickness()
        {
            return _inputValuesFromUser.InputValuesList[8] + _inputValuesFromUser.InputValuesList[9]+ _inputValuesFromUser.InputValuesList[10]+ _inputValuesFromUser.InputValuesList[11]+ _inputValuesFromUser.InputValuesList[12];
        }
        private List<double> CreateSeriesWithProperThicknessDivision(List<double> newEnergySeries, double y1, double y2, double y3, double y4, double y5)
        {
            var layer1Thickness = _inputValuesFromUser.InputValuesList[8];
            var layer2Thickness = _inputValuesFromUser.InputValuesList[9];
            var layer3Thickness = _inputValuesFromUser.InputValuesList[10];
            var layer4Thickness = _inputValuesFromUser.InputValuesList[11];
            var layer5Thickness = _inputValuesFromUser.InputValuesList[12];
            for (int i = 0; i <= layer1Thickness;i++)
            {
                newEnergySeries.Add(y1);
            }
            for (int i = Convert.ToInt32(layer1Thickness)+1; i <= layer1Thickness+layer2Thickness; i++)
            {
                newEnergySeries.Add(y2);
            }
            for (int i = Convert.ToInt32(layer1Thickness + layer2Thickness) + 1; i <= layer1Thickness + layer2Thickness+layer3Thickness; i++)
            {
                newEnergySeries.Add(y3);
            }
            for (int i = Convert.ToInt32(layer1Thickness + layer2Thickness + layer3Thickness) + 1; i <= layer1Thickness + layer2Thickness + layer3Thickness+layer4Thickness; i++)
            {
                newEnergySeries.Add(y4);
            }
            for (int i = Convert.ToInt32(layer1Thickness + layer2Thickness + layer3Thickness + layer4Thickness) + 1; i <= layer1Thickness + layer2Thickness + layer3Thickness + layer4Thickness+layer5Thickness; i++)
            {
                newEnergySeries.Add(y5);
            }

            return newEnergySeries;
        }
    }
}
