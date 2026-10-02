using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace ItSchulung.CsharpKurs.ClassLibrary
{
    public class Sorter
    {
        private delegate bool CompareDelegate(int x, int y);

        private static bool CompareAscending(int x, int y)
        {
            bool bResult = false;
            if (x > y)
            {
                bResult = true;
            }
            return bResult;
        }
        private static bool CompareDescending(int x, int y)
        {
            bool bResult = false;
            if (x < y)
            {
                bResult = true;
            }
            return bResult;
        }

        public static void BubbleSort(int[] numbers, SortDirection direction)
        {
            int tempValue;

            CompareDelegate pointer;

            if (direction == SortDirection.Ascending)
            {
                pointer = CompareAscending;
            }
            else
            {
                pointer = CompareDescending;
            }

            int n = numbers.GetUpperBound(0);
            for (int i = 0; i < n - 1; i++)
            {
                tempValue = numbers[i];
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (pointer(tempValue, numbers[j]))
                    {
                        numbers[i] = numbers[j];
                        numbers[j] = tempValue;
                        tempValue = numbers[i];
                    }
                    //if (direction == SortDirection.Ascending   )
                    //{
                    //    if (CompareAscending(numbers[j], numbers[j + 1]))
                    //    {
                    //        // Swap numbers[j] and numbers[j + 1]
                    //        //tempValue = numbers[j];
                    //        //numbers[j] = numbers[j + 1];
                    //        //numbers[j + 1] = tempValue;
                    //        numbers[i] = numbers[j];
                    //        numbers[j] = tempValue;
                    //        tempValue = numbers[i];
                    //    }
                    //}
                    //else
                    //{
                    //    if (CompareDescending(numbers[j], numbers[j + 1]))
                    //    {
                    //        // Swap numbers[j] and numbers[j + 1]
                    //        //tempValue = numbers[j];
                    //        //numbers[j] = numbers[j + 1];
                    //        //numbers[j + 1] = tempValue;
                    //        numbers[i] = numbers[j];
                    //        numbers[j] = tempValue;
                    //        tempValue = numbers[i];
                    //    }
                    //}
                }
            }
        }   
    }
    public enum SortDirection
    {
        Ascending,
        Descending
    }       

}
