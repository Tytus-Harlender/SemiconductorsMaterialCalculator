using System.Collections.Generic;
using System.Windows.Forms;

namespace SemiconductorMaterialsCalculator
{
    public class InputValues
    {
        public List<double> InputValuesList { get; set; }
        public InputValues(NumericUpDown sequanceChoiceNumber, NumericUpDown numeric1, NumericUpDown numeric2, NumericUpDown numeric3, NumericUpDown numeric4, NumericUpDown numeric5, NumericUpDown numeric6, NumericUpDown temperature)
        {
            List<double> inputList = new List<double>();
            double value;
            value = GetSequanceParameter(sequanceChoiceNumber);
            inputList.Add(value);
            value = GetXyParameter(numeric1);
            inputList.Add(value);
            value = GetXyParameter(numeric2);
            inputList.Add(value);
            value = GetXyParameter(numeric3);
            inputList.Add(value);
            value = GetXyParameter(numeric4);
            inputList.Add(value);
            value = GetXyParameter(numeric5);
            inputList.Add(value);
            value = GetXyParameter(numeric6);
            inputList.Add(value);
            value = GetTemperatureParameter(temperature);
            inputList.Add(value);

            InputValuesList = inputList;
        }
        public double GetTemperatureParameter(NumericUpDown sourceNumeric)
        {
            if (sourceNumeric.Value <= 0)
            {
                MessageBox.Show($@"Please check {sourceNumeric.Name} value! It seems to be less or equal to '0'");
            } 
            return decimal.ToDouble(sourceNumeric.Value);
        }
        public double GetSequanceParameter(NumericUpDown sourceNumeric)
        {
            if (!(sourceNumeric.Value==1||sourceNumeric.Value==2))
            {
                MessageBox.Show($@"Please check {sourceNumeric.Name} value, it may be set to '1' or '2' only");
                return 0;
            }
            else { return decimal.ToDouble(sourceNumeric.Value); }
        }
        public double GetXyParameter(NumericUpDown sourceNumeric)
        {
            if (!(sourceNumeric.Value == 0 || sourceNumeric.Value == 1))
            {
                return decimal.ToDouble(sourceNumeric.Value);
            }
            MessageBox.Show($@"Please check {sourceNumeric.Name} value, it may not be set to '0' nor '1'");
            return 0;
        }
    }
}
