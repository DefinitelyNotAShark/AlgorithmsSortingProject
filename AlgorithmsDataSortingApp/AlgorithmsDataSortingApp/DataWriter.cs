using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AlgorithmsDataSortingApp
{
    class DataWriter
    {
        public string path(string fileName)
        {
            return @"C:\Users\Sophie\Documents\Visual Studio 2017\" + fileName + ".csv";
        }

        public void CreateNewTextFile(List<Tuple<int, Guid, double>> listToWrite, string filePath)//takes in the list and the string of the path
        {
            StreamWriter sw = File.CreateText(path(filePath));
            foreach (Tuple<int, Guid, double> t in listToWrite)
            {                
                sw.WriteLine(t);
            }
        }

    }
}
