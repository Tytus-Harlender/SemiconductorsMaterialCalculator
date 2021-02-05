using System.Collections.Generic;
using System.Windows.Forms;

namespace SemiconductorMaterialsCalculator
{
    public class LayerInterpolation
    {
        #region PRIVATE FIELDS
        private int _layerNumber;
        private int _fixedParam;
        private double _fixedValue;
        #endregion

        public LayerInterpolation()
        {
            
        }
        public LayerInterpolation(int layerNumber, int fixedParam, double fixedValue)
        {
            _layerNumber = layerNumber;
            _fixedParam = fixedParam;
            _fixedValue = fixedValue;
        }
        public InterpolatedParametersSet InterpolateLayer(InputValues inputParameters, int layerNumber)
        {
            double x;
            double y;
            var materialSwitch = inputParameters.InputValuesList[0];
            var temperature = inputParameters.InputValuesList[7];
            List<double> outcomesList = new List<double>();
            BandStructureParametersNames paramNames = new BandStructureParametersNames();
            switch (layerNumber)
            {
                case 1:
                    x = inputParameters.InputValuesList[1];
                    y = inputParameters.InputValuesList[2];
                    break;
                case 2:
                    x = inputParameters.InputValuesList[3];
                    y = inputParameters.InputValuesList[4];
                    break;
                case 3:
                    x = inputParameters.InputValuesList[5];
                    y = inputParameters.InputValuesList[6];
                    break;
                default:
                    MessageBox.Show("Fatal:there is no such layer");
                    x = y = 2;
                    break;
            }
            foreach (var paramName in paramNames.ListOfBandStructureParameters)
            {
                Interpolator interpolator = new Interpolator(paramName, temperature);
                var outcome = interpolator.InterpolateFourElements(x, y, materialSwitch, layerNumber);
                outcomesList.Add(outcome);
            }
            InterpolatedParametersSet layer1Set = new InterpolatedParametersSet(outcomesList);
            return layer1Set;
        }
        public InterpolatedParametersSet InterpolateLayerWithFixedParameter(InputValues inputParameters, double freeParamValue)
        {
            List<double> outcomesList = new List<double>();
            var materialSwitch = inputParameters.InputValuesList[0];
            var temperature = inputParameters.InputValuesList[7];
            double x=0;
            double y=0;
            if (_fixedParam == 1)
            {
                x = _fixedValue;
                y = freeParamValue;
            }
            else if (_fixedParam == 2)
            {
                y = _fixedValue;
                x = freeParamValue;
            }
            
            BandStructureParametersNames paramNames = new BandStructureParametersNames();
            foreach (var paramName in paramNames.ListOfBandStructureParameters)
            {
                Interpolator interpolator = new Interpolator(paramName, temperature);
                var outcome = interpolator.InterpolateFourElements(x, y, materialSwitch, _layerNumber);
                outcomesList.Add(outcome);
            }
            InterpolatedParametersSet layerSet = new InterpolatedParametersSet(outcomesList);
            return layerSet;
        }
    }
}
