using System.Collections.Generic;

namespace SemiconductorMaterialsCalculator
{
    public class ChartCalculator
    {
        public List<double> ArgumentsOfChart { get; set; }
        public List<double> ValuesOfChart { get; set; }
        public ChartCalculator(List<int> inputParameters)
        {
            var usedDomaine = DefineXDomaine(0, 20, 21);
            var usedValues = CalculateListOfValues(usedDomaine, inputParameters[0], inputParameters[1]);
            ArgumentsOfChart = usedDomaine;
            ValuesOfChart = usedValues;

        }
        public List<double> CalculateListOfValues(List<double> givenDomain, int param1, int param2)
        {
            List<double> valuesOfY = new List<double>();
            foreach (double i in givenDomain)
            {
                valuesOfY.Add(param1*i+param2);
            }
            return valuesOfY;
        }
        public List<double> DefineXDomaine(int startPoint, int endPoint, int numberOfPoints)
        {
            var numberOfSteps = numberOfPoints - 1;
            List<double> xDomaine = new List<double>();
            var step = (endPoint - startPoint) / numberOfSteps;
            xDomaine.Add(startPoint);
            for (int i = 0; xDomaine.Count<= numberOfSteps; i++)
            {
                xDomaine.Add(startPoint+i*step);
            }
            return xDomaine;
        }
    }
}
