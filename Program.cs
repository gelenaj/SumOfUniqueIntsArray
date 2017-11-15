using System;
using System.Collections.Generic;
using System.Linq;

namespace uniqueIntArraySum
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myArr = new List<int>() { 1, 2, 2, 3,3 };
            
            Console.WriteLine("Given int array {1, 2, 2, 3, 3 }, the sum of unique integers is:"+ addUnique(myArr));
            Console.ReadLine();
        }

        public static int addUnique(List<int> myArr)
        {
            int sum = 0;
            for(int i = 0; i < myArr.Count();i++)
            {
                if(myArr.Count(x=>x == myArr[i]) == 1)
                {
                    sum += myArr[i];
                }
            }
                
            return sum;
        }
    }
}
