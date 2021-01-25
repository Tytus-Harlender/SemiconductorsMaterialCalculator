namespace SemiconductorMaterialsCalculator
{
    public class LayersInterpolationSets
    {
        public InterpolatedParametersSet LayerOneSet { get; set; }
        public InterpolatedParametersSet LayerTwoSet { get; set; }
        public InterpolatedParametersSet LayerThreeSet { get; set; }

        public LayersInterpolationSets(InterpolatedParametersSet set1, InterpolatedParametersSet set2, InterpolatedParametersSet set3)
        {
            LayerOneSet = set1;
            LayerTwoSet = set2;
            LayerThreeSet = set3;
        }
    }
}
