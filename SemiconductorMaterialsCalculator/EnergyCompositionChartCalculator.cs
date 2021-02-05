using System.Collections.Generic;

namespace SemiconductorMaterialsCalculator
{
    public class EnergyCompositionChartCalculator
    {
        #region SERIES
        public List<double> ArgumentsList;
        public List<double> ListEc;
        public List<double> ListElh;
        public List<double> ListEhh;
        public List<double> ListEsh;
        #endregion

        public EnergyCompositionChartCalculator(InputValues currentInputValues)
        {
            List<double> argumentChartList = new List<double>();
            List<double> listEc = new List<double>();
            List<double> listElh = new List<double>();
            List<double> listEhh = new List<double>();
            List<double> listEsh = new List<double>();

            var layerNumber = (int)currentInputValues.InputValuesList[13];
            var fixedParam = (int)currentInputValues.InputValuesList[14];
            var fixedValue = currentInputValues.InputValuesList[15];
            var resolution = currentInputValues.InputValuesList[16];
            var step = 1 / resolution;
            LayerInterpolation newInterpolation = new LayerInterpolation(layerNumber, fixedParam, fixedValue);
            LayerEnergiesCalculator newLayerEnergiesCalculator = new LayerEnergiesCalculator();
            
            for (double i = 0 + step; i < 1; i = i + step)
            {
                var interpolatedLayer = newInterpolation.InterpolateLayerWithFixedParameter(currentInputValues, i);
                var calculatedEnergies = newLayerEnergiesCalculator.CalculateEnergiesSet(interpolatedLayer);
                argumentChartList.Add(i);
                listEc.Add(calculatedEnergies.E_c);
                listElh.Add(calculatedEnergies.E_lh);
                listEhh.Add(calculatedEnergies.E_hh);
                listEsh.Add(calculatedEnergies.E_sh);
            }
            ArgumentsList = argumentChartList;
            ListEc = listEc;
            ListElh = listElh;
            ListEhh = listEhh;
            ListEsh = listEsh;
        }
    }
}
