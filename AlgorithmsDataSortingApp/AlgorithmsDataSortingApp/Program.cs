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
            string path = @"C:\Users\Evan Sucher\Desktop\School\SENIOR YEAR\Algorithms\sk-es.csv"; //YOU WILL HAVE TO CHANGE THIS LINE
            string[] lines = System.IO.File.ReadAllLines(path);

            //reading file code from stack overflow Reading a Delimited text file line by line and by delimiter in c#
            foreach (string line in lines)
            {
                string[] col = line.Split(new char[] { ',' });

                int i = Convert.ToInt32(col[0]);
                Guid g = Guid.Parse(col[1]);
                double d = Convert.ToDouble(col[2]);

                Tuple<int, Guid, double> t = Tuple.Create(i, g, d);
                dataLine.Add(t);
            }
            SortByDouble dSort = new SortByDouble();//create our sort class objects
            SortByGuid gSort = new SortByGuid();
            SortByID iSort = new SortByID();

            DataWriter writer = new DataWriter();

            List<Tuple<int, Guid, double>> doubleSortedList = dataLine;
            dSort.doubleQuicktSorted(doubleSortedList, 0, dataLine.Count - 1);//this is our quick sort function we call and now double sorted list is sorted!
            writer.CreateNewTextFile(doubleSortedList, "debugSortByDouble");

            List<Tuple<int, Guid, double>> IDSortedList = dataLine;
            iSort.IDQuickSorted(IDSortedList, 0, dataLine.Count - 1);//this is our quick sort function for int/ID
            writer.CreateNewTextFile(IDSortedList, "debugSortByID");

            Console.Read();
        }
    }
}
