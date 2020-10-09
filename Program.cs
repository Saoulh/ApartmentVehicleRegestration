using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace FindUniqueValueFromArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //Delaration and initalization of arrary
            int[] arry = { 1, 4, 2, 2, 3, 3, 1, 1, 0, 0, 5, 8 };

            //Call getUniqueElment
             List<int> uniqueElements = GetUniqueElement(arry);
            if (uniqueElements.Count > 0)
            {
                foreach(var element in uniqueElements)
                {
                    Console.WriteLine(element);
                }
            }
               
            Console.ReadKey();
        }

        private static List<int> GetUniqueElement(int[] arry)
        {
            List<int> nums = new List<int>(); 

            //outer loop

            for (int i = 0; i < arry.Length; i++)
            {
                int uniqueElement = arry[i]; // assume unique;
                bool found = false;
                //Inner loop
                for (int j = 0; j < arry.Length; j++)
                {
                    if (i != j)
                    {
                        if (uniqueElement == arry[j])
                        {
                            found = true;
                            break;
                        }
                    }
                }


                // if not found
                if (!found)
                {
                    nums.Add(uniqueElement);
                }
            }

            return nums;

        }
    }
}
