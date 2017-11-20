using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class GammaRadiationMeasurement : Measurement, IGenerateHTML
    {
        public double radiationLevel{ get; set; }

        public GammaRadiationMeasurement(string InputName) : base (InputName){}

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Radiation level: {0}", radiationLevel);
        }

        public new string ToHTMLString()
        {
            string returnString = base.ToHTMLString();
            returnString += ", radiation: " + radiationLevel;
            return returnString;
        }

        public new void GenerateHTML()
        {
            Console.WriteLine(ToHTMLString());
        }
    }
}
