using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
       
        static void Main(string[] args)
        {
            int[] arr = new int[4];
            string[] array = new string[3];

            arr[0] = 0;
            arr[1] = 10;
            arr[3] = 100;
            arr[2] = 125;
            array[0] = "Madhav";
            array[1] = "Gajalwar";
            array[2] = "XYZ";
            Console.Write(arr[2] );
            Console.Write(array[0]);
            Console.ReadLine();

        }
    }
}
