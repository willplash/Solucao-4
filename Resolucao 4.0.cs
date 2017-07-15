using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resolucao_4._0
{
    class Program
    {
        public static double Average(int a, int b)
        {
            double aNovo, bNovo;
            aNovo = System.Convert.ToDouble(a);
            bNovo = System.Convert.ToDouble(b);
            return (aNovo + bNovo) / 2;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Average(2, 1));
        }
    }
}
