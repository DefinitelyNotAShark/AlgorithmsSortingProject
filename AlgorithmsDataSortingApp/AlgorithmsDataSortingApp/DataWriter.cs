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
            return fileName + ".csv"; //Path to the folder: " /AlgorithmsDataSortingApp/bin/Debug/ "
        }

        public void CreateNewTextFile(List<Tuple<int, Guid, double>> listToWrite, string filePath)//takes in the list and the string of the path
        {
            StreamWriter sw = File.CreateText(path(filePath));
            foreach (Tuple<int, Guid, double> t in listToWrite)
            {                
                sw.WriteLine(t);
            }
        }

        public void CreateRandomDataSet(string filePath)
        {
            using (StreamWriter sw = File.CreateText(path(filePath)))
            {
                for (int i = 0; i < 1000000; i++)
                {
                    sw.WriteLine("" + i + ", " + createGUID() + ", " + createDouble(createGUID()));
                }
            }
        }

        private Guid createGUID()
        {
            Guid g;
            g = Guid.NewGuid();
            return g;
        }

        private Double createDouble(Guid g)
        {
            byte[] arr;
            arr = g.ToByteArray();
            double temp;
            temp = BitConverter.ToDouble(arr, 0);
            return temp;
        }

    }
}
