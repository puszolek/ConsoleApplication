using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Measurement : IGenerateHTML
    {
        string stationName;
        DateTime date;
        double[] conditions;
        static int noOfMeasurements;

        public enum MeasurementConditions { Temperature = 0, Pressure = 1, Humidity = 2};

        public static int NoOfMeasurements
        {
            get { return Measurement.noOfMeasurements; }
        }

        // indexer
        public double this[int pos]
        {
            get { return conditions[pos]; }
            set { conditions[pos] = value; }
        }
        public Measurement(string inputString="No Name!")
        {
            stationName = inputString;
            date = DateTime.Now;
            conditions = new double[3];
            conditions[(int)MeasurementConditions.Temperature] = 0; //temperature
            conditions[(int)MeasurementConditions.Pressure] = 0; //pressure
            conditions[(int)MeasurementConditions.Humidity] = 0; //humidity

            noOfMeasurements += 1;
        }

        public virtual void Print()
        {
            Console.WriteLine("Station name: {3}, temperature: {0}, pressure: {1}, humidity: {2}", 
                conditions[(int)MeasurementConditions.Temperature], 
                conditions[(int)MeasurementConditions.Pressure], 
                conditions[(int)MeasurementConditions.Humidity],
                stationName);
        }

        public string ToHTMLString()
        {
            string returnString = "Station name: " + stationName + ", " + date + ", conditions: " + conditions[0] + ", " + conditions[1] + ", " + conditions[2];
            return returnString;
        }

        public void GenerateHTML()
        {
            Console.WriteLine(ToHTMLString());
        }
    }
}
