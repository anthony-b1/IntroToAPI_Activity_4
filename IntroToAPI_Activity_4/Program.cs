/**
A very simple console app that generates IDs for an employee
**/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
namespace IntroToAPI_Activity_4
{
    interface IIDInterface
    {
        void title(); // Interface method 
        string Name { get; set; } // Property
        int this[int index] { get; set; } // Indexer declaration  
    }
    class IDClass : IIDInterface
    {
        // A very simple method that prints a string 
        public void title()
        {
            Console.WriteLine("Generate a number of IDs of length 6 randomly");
        }

        private string employeeName;
        // Read-Write instance property
        public string Name
        {
            get { return employeeName; }
            set { employeeName = value; }
        }


        private int[] arr = new int[100];
        // Indexer Declaration
        public int this[int index]
        {
            get { return arr[index]; }
            set { arr[index] = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IDClass test = new IDClass();   // Create object

            test.title();

            System.Console.WriteLine("Enter employee name: ");
            test.Name = System.Console.ReadLine();

            System.Console.WriteLine("Number of IDs to generate:");
            int num = Convert.ToInt32(Console.ReadLine());
            System.Random rand = new System.Random();

            // Generate the specify number of ID's
            for (int i = 0; i < num; i++)
            {
                test[i] = rand.Next(99999, 1000000); // Generate randomly of length 6
                System.Console.WriteLine($"ID #{i} = {test[i]}");
            }

            System.Console.WriteLine("Employee name: {0} \nPlease select one of the following IDs", test.Name);
        }
    }
}
