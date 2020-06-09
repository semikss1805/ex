using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex
{
    class Program
    {
        static Worker[] ReadData(string fileName)
        {
            string input = File.ReadAllText(fileName);
            string[] inputInf = input.Split('\n');
            Worker[] worker = new Worker[inputInf.Length];
            for(int i = 0; i< inputInf.Length; i++)
            {
                worker[i] = new Worker(inputInf[i]);
            }
            return worker;
        }
        static void RunMenu (Worker[] worker)
        {
            for(int i = 0; i < worker.Length; i++)
            {
                Console.WriteLine($"Salary of {worker[i].surName} {worker[i].init} is {worker[i].det * worker[i].sal}");
            }
            int minSal = worker[0].det * worker[0].sal;
            int maxW = 0;
            int minW = 0;
            int maxSal = worker[0].det * worker[0].sal;
            for(int i = 1;i < worker.Length; i++)
            {
                if (maxSal < worker[i].det * worker[i].sal)
                {
                    maxSal = worker[i].det * worker[i].sal;
                    maxW = i;
                }
            }
            Console.WriteLine($"{worker[maxW].surName} have max salaty {maxSal}");
            for (int i = 1; i < worker.Length; i++)
            {
                if (minSal > worker[i].det * worker[i].sal)
                {
                    minSal = worker[i].det * worker[i].sal;
                    minW = i;
                }
            }
            Console.WriteLine($"{worker[minW].surName} have min salaty {minSal}");
            int count = 0;
            int midSal = 0;
            for (int i = 0; i < worker.Length; i++)
            {
                midSal += worker[i].det * worker[i].sal;
                count++;
            }
            Console.WriteLine($"Midle salary is {midSal/count}");
        }
        static void Main(string[] args)
        {
            Worker[] worker = ReadData("input.txt");
            RunMenu(worker);
            Console.ReadKey();
        }
    }
}
