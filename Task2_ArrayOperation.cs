namespace ConexusHomework
{
    public static class Task2_ArrayOperation
    {
        public static int[] AllToRightMost(int[] intArray, int number)
        {
            int numberElementsToShove = 0;

            for (int i = 0; i < intArray.Length; i++)
            {
                //when matching item found swap this position with the next unknown num
                if (intArray[i] == number)
                {
                    if (i + numberElementsToShove >= intArray.Length) return intArray;//allow exit if end of arr

                    //swap
                    intArray[i] = intArray[i + numberElementsToShove];
                    intArray[i + numberElementsToShove] = number;

                    while (intArray[i] == number)//still matching, a new instance was encountered
                    {
                        //note 1 new instance detected
                        numberElementsToShove += 1;

                        if (i + numberElementsToShove >= intArray.Length) return intArray;//allow exit if end of arr

                        //swap
                        intArray[i] = intArray[i + numberElementsToShove];
                        intArray[i + numberElementsToShove] = number;
                    }
                }
            }
            return intArray;//no specified number present
        }
    }
}
