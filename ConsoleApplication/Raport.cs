using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Raport : IGenerateHTML
    {
        public void GenerateHTML()
        {
            Console.WriteLine("<p>This is a placeholder for the report</p>");
        }

        public string ToHTMLString()
        {
            return "";
        }
    }
}
