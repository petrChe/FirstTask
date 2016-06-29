using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FirstTask
{
    class Program
    {
        static double xCoordinate;
        static double yCoordinate;
        /// <summary>
        /// Main method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.Clear();
            for (int i = 0; i < 3;)
            {
                Console.WriteLine("Please write the first coordinate: ");
                double xCoordinate = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please write the second coordinate: ");
                double yCoordinate = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("X: " + xCoordinate + " Y: " + yCoordinate);
                Console.ReadLine();
                Console.Clear();
                i++;
            }

            StreamReader streamReader = File.OpenText(@"K:\Epam C Sharp dot net\textFile.txt");
            string line;
            while ((line = streamReader.ReadLine()) != null)
            {
                string[] doubles = line.Split(' ');
                    for (int j = 0; j < doubles.Length;j++)
                    {
                       if(j % 2 != 0)
                        {
                            yCoordinate = double.Parse(doubles[j]);
                            xCoordinate = double.Parse(doubles[j-1]);
                            Console.WriteLine("X: " + xCoordinate + " Y: " + yCoordinate);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
