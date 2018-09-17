using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsDataSortingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Tuple<int, Guid, double>> dataLine = new List<Tuple<int, Guid, double>>();

            //file reading code from
            //microsoft how to read from a text file (c# programming guide)
            string path = @"c:\workspace\sk-es.csv";
            string[] lines = System.IO.File.ReadAllLines(path);

            //reading file code from stack overflow Reading a Delimited text file line by line and by delimiter in c#
            foreach(string line in lines)
            {
                string[] col = line.Split(new char[] { ',' });

                int i = Convert.ToInt32(col[0]);
                Guid g = Guid.Parse(col[1]);
                double d = Convert.ToDouble(col[2]);

                Tuple<int, Guid, double> t = Tuple.Create(i, g, d);
                dataLine.Add(t);
            }

            Console.WriteLine(dataLine[1]);
            Console.Read();
        }
    }
}
