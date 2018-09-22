using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;

namespace AlgorithmsDataWritingApp
{
    class Program
    {

        static void Main(string[] args)
        {
            string path = @"C:\Users\Evan Sucher\Desktop\School\SENIOR YEAR\Algorithms\sk-es.csv";//this is where our text file is going to be created and what it's going to be called

            using (StreamWriter sw = File.CreateText(path))
            {
                for (int i = 0; i < 1000000; i++)
                {
                    sw.WriteLine("" + i + ", " + createGUID() + ", " + createDouble(createGUID()));
                }
            }

            Console.Read();

            Guid createGUID()
            {
                Guid g;
                g = Guid.NewGuid();
                return g;
            }

            Double createDouble(Guid g)
            {
                byte[] arr;
                arr = g.ToByteArray();
                double temp;
                temp = BitConverter.ToDouble(arr, 0);
                return temp;
            }
        }

    }
    

}
