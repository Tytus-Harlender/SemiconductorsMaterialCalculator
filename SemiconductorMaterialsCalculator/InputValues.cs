using System.Collections.Generic;
using System.Windows.Forms;

namespace SemiconductorMaterialsCalculator
{
    public class InputValues
    {
        public List<int> InputValuesList { get; set; }
        public InputValues(DomainUpDown domain1, DomainUpDown domain2)
        {
            List<int> inputList = new List<int>();
            int domainValue;
            domainValue = GetParameter(domain1);
            inputList.Add(domainValue);
            domainValue = GetParameter(domain2);
            inputList.Add(domainValue);
            InputValuesList = inputList;
        }
        public int GetParameter(DomainUpDown sourceDomain)
        {
            if (int.TryParse(sourceDomain.Text, out int result))
            { }
            else
            {   
                MessageBox.Show($"Please check {sourceDomain.Name} value! It seems to be incorrect");
            }
            return result;
        }
    }
}
