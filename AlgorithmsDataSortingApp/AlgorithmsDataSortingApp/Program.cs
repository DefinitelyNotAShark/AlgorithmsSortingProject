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

            DataWriter writer = new DataWriter();
            string dataFileName = "RandomDataSet";

            Console.WriteLine("Random Data Set Sorting: Sophia Kneznekoff and Evan Sucher\n");
            Console.WriteLine("Files Created in Path: /AlgorithmsDataSortingApp/bin/Debug/\n");
            Console.WriteLine("Creating Random Data Set...");

            writer.CreateRandomDataSet(dataFileName); //This creates the data set of 1,000,000 elements

            Console.WriteLine("Complete: Random Data Set Created\n");

            Console.WriteLine("Reading: Random Data Set...");

            //file reading code from
            //microsoft how to read from a text file (c# programming guide)
            string path = dataFileName + ".csv"; //Path to the folder: " /AlgorithmsDataSortingApp/bin/Debug/ "
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
            Console.WriteLine("Complete: Random Data Set Read\n");

            SortByDouble dSort = new SortByDouble();//create our sort class objects
            SortByGuid gSort = new SortByGuid();
            SortByID iSort = new SortByID();


            Console.WriteLine("Quick Sorting by Double...");

            //QuickSorting all 3 elements
            List<Tuple<int, Guid, double>> doubleQuickSortedList = dataLine;
            dSort.doubleQuicktSorted(doubleQuickSortedList, 0, dataLine.Count - 1);//this is our quick sort function we call and now double sorted list is sorted!
            writer.CreateNewTextFile(doubleQuickSortedList, "QuickSortByDouble");  //This creates the file for the doublesorted List

            Console.WriteLine("Complete: Quick Sorting by Double\n");
            Console.WriteLine("Quick Sorting by ID...");

            List<Tuple<int, Guid, double>> IDQuickSortedList = dataLine;
            iSort.IDQuickSorted(IDQuickSortedList, 0, dataLine.Count - 1);//this is our quick sort function for int/ID
            writer.CreateNewTextFile(IDQuickSortedList, "QuickSortByID"); //This creates the file for the ID sorted List

            Console.WriteLine("Complete: Quick Sorting by ID\n");
            Console.WriteLine("Quick Sorting by Guid...");

            List<Tuple<int, Guid, double>> guidQuickSortedList = dataLine;
            gSort.GuidQuickSorted(guidQuickSortedList, 0, dataLine.Count - 1);//this is our quick sort function for GUID
            writer.CreateNewTextFile(guidQuickSortedList, "QuickSortByGuid"); //This creates the file for the GUID sorted List

            Console.WriteLine("Complete: Quick Sorting by Guid\n");
            Console.WriteLine("Bubble Sorting by Double...");

            //BubbleSorting all 3 elements
            //List<Tuple<int, Guid, double>> doubleBubbleSortedList = dataLine;
            //doubleBubbleSortedList = dSort.doubleBubbleSorted(dataLine);
            writer.CreateNewTextFile(doubleQuickSortedList, "BubbleSortByDouble"); //This creates the file for the Double sorted List

            Console.WriteLine("Complete: Bubble Sorting by Double\n");
            Console.WriteLine("Bubble Sorting by ID...");

            //List<Tuple<int, Guid, double>> IDBubbleSortedList = iSort.IDBubbleSorted(dataLine);
            writer.CreateNewTextFile(IDQuickSortedList, "BubbleSortByID"); //This creates the file for the Id sorted List

            Console.WriteLine("Complete: Bubble Sorting by ID\n");
            Console.WriteLine("Bubble Sorting by Guid...");

            //List<Tuple<int, Guid, double>> guidBubbleSortedList = gSort.GuidBubbleSorted(dataLine);
            writer.CreateNewTextFile(guidQuickSortedList, "BubbleSortByGuid"); //This creates the file for the Guid sorted List
            Console.WriteLine("Complete: Bubble Sorting by Guid");

            Console.Read();
        }
    }
}
