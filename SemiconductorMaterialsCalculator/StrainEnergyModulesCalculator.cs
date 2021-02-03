using System;

namespace SemiconductorMaterialsCalculator
{
    public class StrainEnergyModulesCalculator
    {
        private double _epsilonParallel;
        private double _epsilonPerpendicular;
        private double _aC;
        private double _aV;
        private double _b;
        private double _deltaSO;
        public double EnergyDeltaCH { get; set; }
        public double EnergyDeltaVH { get; set; }
        public double EnergyDeltaVB { get; set; }
        public double EnergyDeltaPlusVB { get; set; }
        public double EnergyDeltaMinusVB { get; set; }
        public StrainEnergyModulesCalculator(InterpolatedParametersSet givenParametersSet, double epsilonParallel,double epsilonPerpendicular)
        {
            _epsilonParallel = epsilonParallel;
            _epsilonPerpendicular = epsilonPerpendicular;
            _aC = givenParametersSet.A_c;
            _aV = givenParametersSet.A_v;
            _b = givenParametersSet.B;
            _deltaSO = givenParametersSet.Delta_so;
            EnergyDeltaCH = CalculateEnergyDeltaCH();
            EnergyDeltaVH = CalculateEnergyDeltaVH();
            EnergyDeltaVB = CalculateEnergyDeltaVB();
            EnergyDeltaPlusVB = CalculateEnergyDeltaPlusVB();
            EnergyDeltaMinusVB = CalculateEnergyDeltaMinusVB();
        }

        private double CalculateEnergyDeltaCH()
        {
            return _aC * (_epsilonPerpendicular + 2 * _epsilonParallel);
        }

        private double CalculateEnergyDeltaVH()
        {
            return _aV * (_epsilonPerpendicular + 2 * _epsilonParallel);
        }

        private double CalculateEnergyDeltaVB()
        {
            return _b * (_epsilonPerpendicular - _epsilonParallel);
        }

        private double CalculateEnergyDeltaPlusVB()
        {
            return (EnergyDeltaVB -_deltaSO + Math.Pow(9*Math.Pow(EnergyDeltaVB,2)+2*EnergyDeltaVB*_deltaSO + Math.Pow(_deltaSO,2),0.5))/2;
        }
        private double CalculateEnergyDeltaMinusVB()
        {
            var a = 9 * Math.Pow(EnergyDeltaVB, 2) + 2 * EnergyDeltaVB * _deltaSO + Math.Pow(_deltaSO, 2);
            var b = Math.Pow(a, 0.5);
            var c = (EnergyDeltaVB - _deltaSO - b)/2;
            return c;
        }
    }
}
