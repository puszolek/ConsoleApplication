using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class AirPollutionMeasurement : Measurement, IGenerateHTML
    {
        public double PM2_5 { get; set; }
        public double PM10 { get; set; }

        public AirPollutionMeasurement(string InputName) : base(InputName){}

        public override void Print()
        {
            base.Print();
            Console.WriteLine("PM 2.5: {0}, PM10: {1}", PM2_5, PM10);
        }

        public new string ToHTMLString()
        {
            string returnString = base.ToHTMLString();
            returnString += ", PM2_5: " + PM2_5 + ", PM10: " + PM10;
            return returnString;
        }

        public new void GenerateHTML()
        {
            Console.WriteLine(ToHTMLString());
        }
    }
}
