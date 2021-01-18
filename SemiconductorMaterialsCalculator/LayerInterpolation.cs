using System.Collections.Generic;
using System.Windows.Forms;

namespace SemiconductorMaterialsCalculator
{
    public class LayerInterpolation
    {
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
            MessageBox.Show($"Layer {layerNumber} interpolation calculated");
            return layer1Set;
        }
    }
}
