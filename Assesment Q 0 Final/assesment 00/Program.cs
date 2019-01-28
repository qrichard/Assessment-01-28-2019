using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assesment_00
{
    class Program
    {
        static void Main(string[] args)
        {
            int arraySize = 100;

            int []sortArray = new int[arraySize ];
            sortArray = InitializeArray(sortArray);
           
            Console.WriteLine("Original Array");
            for (int i =0; i< arraySize; i++)
            {
            Console.Write(sortArray[i]);
            }
            BubbleSort(sortArray);


           Console.WriteLine("\n\nNew Sorted Array");
           for (int j =0; j< arraySize; j++)
            {
            Console.Write(sortArray[j]);
            }
           Console.ReadKey();
        }

        static void BubbleSort(int[] array){
            bool sorted = false;
            while (!sorted){
                sorted = true;
                for (int i = 1; i < array.Length; i++){
                    if (array[i] < array [i-1]){
                        SwapArray(array, i, i-1);
                        sorted = false;
                    }
                }
            }
        }

 
        static int [] SwapArray(int[] ary_Numbers,int i, int j ) {
            int temp = 0;
            temp = ary_Numbers[i];
            ary_Numbers[i] = ary_Numbers[j];
            ary_Numbers[j] = temp;
            return ary_Numbers;
        }

        static Random rnd = new Random();

        static int [] InitializeArray (int [] random){
            for (int i = 0; i < random.Length -1; i ++)
                { random[i] = rnd.Next(0,2);
            }
            return random;
    }
}
}

