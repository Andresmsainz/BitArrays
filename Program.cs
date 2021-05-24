using System;
using System.Collections;

namespace BitArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BitArrays!");

            // Creating
            Console.WriteLine("In Creating");

            bool[] boolArray = new bool[4];
            boolArray[0] = false;
            boolArray[1] = false;
            boolArray[2] = false;
            boolArray[3] = true;


            BitArray firstArray = new BitArray(4); //Need to specify size
            BitArray secondArray = new BitArray(boolArray); //Use array as size spec
            Console.WriteLine("--------------");

            // Setting Value

            Console.WriteLine("Inside Setting Value");
            firstArray.Set(0, false);
            firstArray.Set(1, true);
            firstArray.Set(2, false);
            firstArray.Set(3, true);

            Console.WriteLine("First Array Values");
            foreach (var item in firstArray)
            {
                Console.WriteLine("Item = " + item);
            }

            Console.WriteLine();
            Console.WriteLine("Second Array Values");
            foreach (var item in secondArray)
            {
                Console.WriteLine("Item = " + item);
            }

            Console.WriteLine("--------------");

            // And or Not
            BitArray oresult = new BitArray(4);
            oresult = firstArray.Or(secondArray);
            Console.WriteLine("Or Results");
            foreach (var item in oresult)
            {
                Console.WriteLine("Result = " + item);
            }

            BitArray result = new BitArray(4);
            result = firstArray.And(secondArray);
            Console.WriteLine("And Results");
            foreach (var item in result)
            {
                Console.WriteLine("Result = " + item);
            }

            BitArray notresult = new BitArray(4);
            notresult = firstArray.Not();
            Console.WriteLine("Not Results");
            foreach (var item in notresult)
            {
                Console.WriteLine("Result = " + item);
            }


        }
    }
}
