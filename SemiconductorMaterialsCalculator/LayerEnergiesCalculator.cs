namespace SemiconductorMaterialsCalculator
{
    public class LayerEnergiesCalculator
    {
        private double _aE = 0.1;
        private InterpolatedParametersSet _layerParametersSet;
        public LayerEnergiesSet LayerEnergies;
        
        public LayerEnergiesSet CalculateEnergiesSet(InterpolatedParametersSet layerParametersSet)
        {
            _layerParametersSet = layerParametersSet;
            StrainTensorCalculator newStrainTensorCalculator = new StrainTensorCalculator(_aE, _layerParametersSet);
            var epsilonParallel = newStrainTensorCalculator.EpsilonParallel;
            var epsilonPerpendicular = newStrainTensorCalculator.EpsilonPerpendicular;
            StrainEnergyModulesCalculator newStrainEnergyModulesCalculator= new StrainEnergyModulesCalculator(_layerParametersSet,epsilonParallel,epsilonPerpendicular);
            var ECH = newStrainEnergyModulesCalculator.EnergyDeltaCH;
            var EVH = newStrainEnergyModulesCalculator.EnergyDeltaVH;
            var EVB = newStrainEnergyModulesCalculator.EnergyDeltaVB;
            var EVBPlus = newStrainEnergyModulesCalculator.EnergyDeltaPlusVB;
            var EVBMinus = newStrainEnergyModulesCalculator.EnergyDeltaMinusVB;
            LayerEnergiesSet newEnergiesSet = new LayerEnergiesSet();
            newEnergiesSet.CalculateLayerEnergies(_layerParametersSet,ECH,EVH,EVB,EVBPlus,EVBMinus);
            LayerEnergies = newEnergiesSet;
            return LayerEnergies;
        }
    }
}
