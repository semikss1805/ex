using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex
{
    struct Worker
    {
        public string surName;
        public string init;
        public string prof;
        public int det;
        public int sal;
        public Worker(string lineWithAllData)
        {
            StringBuilder worker = new StringBuilder(lineWithAllData);
            for(int i = 0;i < worker.Length - 1;)
            {
                if (worker[i] == ' ' && worker[i + 1] == ' ')
                {
                    worker.Remove(i, 1);
                }
                else i++;
            }
            string[] partialWork = worker.ToString().Trim().Split();
            surName = partialWork[0];
            init = partialWork[1];
            prof = partialWork[2];
            det = int.Parse(partialWork[3]);
            sal = int.Parse(partialWork[4]);
        }
    }
}
