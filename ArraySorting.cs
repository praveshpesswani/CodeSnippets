using System;
using System.Collections.Generic;
using System.Text;

namespace CodeSnippets
{
    public class ArraySorting
    {

        public int[] SortedArray(int[] arraysOfZeroAndOne)
        {

            for(int i=0; i<arraysOfZeroAndOne.Length; i++)
            {
                for(int j=i+1; j< arraysOfZeroAndOne.Length; j++)
                {
                    if(arraysOfZeroAndOne[i] > arraysOfZeroAndOne[j])
                    {
                        int valueToShiftRight = arraysOfZeroAndOne[i];
                        arraysOfZeroAndOne[i] = arraysOfZeroAndOne[j];
                        arraysOfZeroAndOne[j] = valueToShiftRight;
                        break;
                    }
                }
            }


            return arraysOfZeroAndOne;
        }

    }
}
