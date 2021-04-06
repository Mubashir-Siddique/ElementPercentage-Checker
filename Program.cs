using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementPercentage
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckForPercentage(new int[] { -5,-6, 1, 8, 0} );

            //CheckSingleNumber(new List<int>() { 4, 3, 2, 4, 1, 3, 2 });
            Console.ReadLine();

        }      
        static void CheckForPercentage(int[] array)
        {
            double  PositivePercentage = 0,
                    NegativePercentage = 0,
                    NeutralPercentage = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)   // if number is Positive
                {
                    PositivePercentage += (double) 1 / array.Length ;
                }
                else if (array[i] < 0)  // if number is Negative
                {
                    NegativePercentage += (double) 1 / array.Length;
                }
                else   // if number is Neutral
                {
                    NeutralPercentage += (double) 1 / array.Length;
                }
            }

            Console.WriteLine("Positive Percentage : " +PositivePercentage);
            Console.WriteLine("Negative Percentage : " + NegativePercentage);
            Console.WriteLine("Neutral Percentage : " + NeutralPercentage);
            Console.ReadLine();
        }

        static void CheckSingleNumber(List<int> Numbers)
        {
            //var x = Numbers.Select(s=> { });
            var query = Numbers.GroupBy(x => x).Where(g => g.Count() == 1).Select(y => y.Key);
            Console.WriteLine(query.First());
        }


    }
}


