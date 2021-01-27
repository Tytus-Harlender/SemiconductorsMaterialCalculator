namespace SemiconductorMaterialsCalculator
{
    public class LayersEnergiesSets
    {
        public LayerEnergiesSet LayerOneSet { get; set; }
        public LayerEnergiesSet LayerTwoSet { get; set; }
        public LayerEnergiesSet LayerThreeSet { get; set; }

        public LayersEnergiesSets(LayerEnergiesSet set1, LayerEnergiesSet set2, LayerEnergiesSet set3)
        {
            LayerOneSet = set1;
            LayerTwoSet = set2;
            LayerThreeSet = set3;
        }
    }
}
