using System;
using System.Linq;

namespace ArrayMerge
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 24, 14, 25, 17, 58 };
            int[] b = { 21, 12, 23, 77, 38 };
            Console.WriteLine("=========================Two Array Merge Test");
            Console.WriteLine("Array a = [" + string.Join(",", a) + "]");
            Console.WriteLine("Array b = [" + string.Join(",", b) + "]");
            Console.WriteLine("Merge the two Array [" + string.Join(",", CompareCollections.Merge(a, b).ToArray<int>()) + "]");
            Console.ReadKey();


            Console.WriteLine("====================string distinct Test, [ABBBCCCCDEFDAB]");
            Console.WriteLine("string distinct test after distinct, [" + string.Join(",",CompareCollections.distinct("ABBBCCCCDEFDAB").ToArray<string>()) + "]");
            Console.ReadKey();



            Console.WriteLine("==================split Test [ABBBCCCCDEFDAB]");
            Console.WriteLine("string after split BY D  , [" + string.Join(",", CompareCollections.SplitBy("ABBBCCCCDEFDAB","D").ToArray<string>()) + "]");
            Console.WriteLine("string after split BY DE  , [" + string.Join(",", CompareCollections.SplitBy("ABBBCCCCDEFDAB", "DE").ToArray<string>()) + "]");
            Console.ReadKey();


            Console.WriteLine("===============Trans To a Number Test");
            Console.WriteLine("string before trans 1234");
            Console.WriteLine("After Trans , [" +  CompareCollections.TransToNumber("1234")+ "]");
            Console.ReadKey();
        }
    }
}
