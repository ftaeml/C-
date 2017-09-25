using System;

namespace MergeSort
{
    class Program
    {
        /*static int[] Merge_Sort(int[] massive)
            {
              if (massive.Length == 1)
                return massive;
              int mid_point = massive.Length / 2;
              return Merge(Merge_Sort(massive.Take(mid_point).ToArray()),
                           Merge_Sort(massive.Skip(mid_point).ToArray()));
            }

            static int[] Merge(int [] mass1, int[] mass2)
            {
              int a = 0, b = 0;
              int[] merged = new int[mass1.Length + mass2.Length];
              for (int i = 0; i < mass1.Length + mass2.Length; i++)
              {
                if (b < mass2.Length && a < mass1.Length)
                  if (mass1[a] > mass2[b])
                    merged[i] = mass2[b++];
                  else //if int go for
                    merged[i] = mass1[a++];
                else
                  if (b < mass2.Length)
                    merged[i] = mass2[b++];
                  else
                    merged[i] = mass1[a++];
              }
             return merged;
            }*/

         
        static void Main(string[] args)
        {
            var a = new [] 
            {
              11,86,232,28,8,145,588,1,307,179,77,792,693,678,481,888,574,695,624,866,467,434,907,259,130,37,25,373,214,268,108,672,371,866,863,279,22,233,336,830,374,439,144,234,360,617,244,5,566,847,476,493,56,618,202,576,179,972,898,970,119,214,786,38,71,404,420,827,814,201,865,341,358,794,492,27,290,672,899,512,792,20,807,367,792,615,616,753,663,287,99,49,334,366,711,160,652,105,162,955
            };

            //ar arr = new [a.Length];
            //arr = Merge_Sort(a);

            System.Console.WriteLine(a.Length);
            foreach (int x in a)
               System.Console.Write($"{x} ");

        }
    }
}
