using System.Collections.Generic;
using System.Linq;

namespace Lab1.BussinessLogic.Helpers
{
    public static class Validation
    {
        public static bool IsArraysLengthEqual<T>(IEnumerable<T> array1, IEnumerable<T> array2)
        {
            return array1.Count() == array2.Count() ? true : false;
        }

        public static bool IsArrayEmpty<T>(IEnumerable<T> array)
        {
            return array.Count() == 0 ? true : false;
        }

        public static bool DoesArrayContainOnly0and1Numbers(int[] array) 
        {
            var result = true;
            foreach(var a in array)
            {
                if(a != 0 && a != 1)
                {
                    result = false;
                }
            }
            return result;
        }
    }
}
