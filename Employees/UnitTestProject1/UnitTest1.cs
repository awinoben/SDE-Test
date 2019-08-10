using Microsoft.VisualStudio.TestTools.UnitTesting;
using Employees;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
           void Main(string[] args)
            {
                // Get the data from path.
                string sampleCSV = @"D:/Employee.csv";

                string[,] values = LoadCSV(sampleCSV);
                int num_rows = values.GetUpperBound(0) + 1;
                int num_cols = values.GetUpperBound(1) + 1;

                // Display the data CSV data.

                for (int c = 0; c < num_cols; c++)
                    Console.Write(values[0, c] + "\t");

                //Read the data.
                for (int r = 1; r < num_rows; r++)
                {
                    //  dgvValues.Rows.Add();
                    Console.WriteLine();
                    for (int c = 0; c < num_cols; c++)
                    {
                        Console.Write(values[r, c] + "\t");
                    }
                }

                Console.ReadLine();

            }
        }

        private string[,] LoadCSV(string sampleCSV)
        {
            throw new NotImplementedException();
        }
    }
}
