using System.Collections.Generic;
using System.Linq;

namespace Lab1.BussinessLogic.Helpers
{
    public static class Validation
    {
        /// <summary>
        /// Проверяет одинаковая ли у массивов длина
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array1"></param>
        /// <param name="array2"></param>
        /// <returns>Возвращает true, если одинаковая</returns>
        public static bool IsArraysLengthEqual<T>(IEnumerable<T> array1, IEnumerable<T> array2)
        {
            return array1.Count() == array2.Count() ? true : false;
        }

        /// <summary>
        /// Проверяет пустой ли массив
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        /// <returns>Возвращает true, если пусткой</returns>
        public static bool IsArrayEmpty<T>(IEnumerable<T> array)
        {
            return array.Count() == 0 ? true : false;
        }

        /// <summary>
        /// Проверяет состоит ли массив только из 0 и 1
        /// </summary>
        /// <param name="array"></param>
        /// <returns>Возвращает true, если состоит</returns>
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
