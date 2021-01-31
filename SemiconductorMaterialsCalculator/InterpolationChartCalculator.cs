using System.Collections.Generic;

namespace SemiconductorMaterialsCalculator
{
    public class InterpolationChartCalculator
    {
        #region SERIES
        public List<double> ArgumentsList;
        public List<double> ListA;
        public List<double> ListEg;
        public List<double> ListAlpha;
        public List<double> ListBetha;
        public List<double> ListDelta_so;
        public List<double> ListMass_e;
        public List<double> ListMass_hh;
        public List<double> ListMass_lh;
        public List<double> ListA_c;
        public List<double> ListA_v;
        public List<double> ListB;
        public List<double> ListVBO;
        public List<double> ListC_11;
        public List<double> ListC_12;
        #endregion

        public InterpolationChartCalculator(InputValues currentInputValues)
        {
            
            List<double> ArgumentInterChartList = new List<double>();
            List<double> listA = new List<double>();
            List<double> listEg = new List<double>();
            List<double> listAlpha = new List<double>();
            List<double> listBetha = new List<double>();
            List<double> listDelta_so = new List<double>();
            List<double> listMass_e = new List<double>();
            List<double> listMass_hh = new List<double>();
            List<double> listMass_lh = new List<double>();
            List<double> listA_c = new List<double>();
            List<double> listA_v = new List<double>();
            List<double> listB = new List<double>();
            List<double> listVBO = new List<double>();
            List<double> listC_11 = new List<double>();
            List<double> listC_12 = new List<double>();
            

            var layerNumber = (int)currentInputValues.InputValuesList[13];
            var fixedParam = (int)currentInputValues.InputValuesList[14];
            var fixedValue = currentInputValues.InputValuesList[15];
            var resolution = currentInputValues.InputValuesList[16];
            var step = 1 / resolution;
            LayerInterpolation newLayerInterpolation = new LayerInterpolation(layerNumber, fixedParam, fixedValue);
            
            for (double i = 0+step; i < 1; i = i+step)
            {
                var layerSet = newLayerInterpolation.InterpolateLayerWithFixedParameter(currentInputValues, i);
                ArgumentInterChartList.Add(i);
                listA.Add(layerSet.A);
                listEg.Add(layerSet.Eg);
                listAlpha.Add(layerSet.Alpha);
                listBetha.Add(layerSet.Betha);
                listDelta_so.Add(layerSet.Delta_so);
                listMass_e.Add(layerSet.Mass_e);
                listMass_hh.Add(layerSet.Mass_hh);
                listMass_lh.Add(layerSet.Mass_lh);
                listA_c.Add(layerSet.A_c);
                listA_v.Add(layerSet.A_v);
                listB.Add(layerSet.B);
                listVBO.Add(layerSet.VBO);
                listC_11.Add(layerSet.C_11);
                listC_12.Add(layerSet.C_12);
            }

            ArgumentsList = ArgumentInterChartList;
            ListA = listA;
            ListEg = listEg;
            ListAlpha =listAlpha;
            ListBetha =listBetha;
            ListDelta_so = listDelta_so;
            ListMass_e = listMass_e;
            ListMass_hh = listMass_hh;
            ListMass_lh = listMass_lh;
            ListA_c = listA_c;
            ListA_v = listA_v;
            ListB = listB;
            ListVBO = listVBO;
            ListC_11 = listC_11;
            ListC_12 = listC_12;
        }
    }
}
