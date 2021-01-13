using System;

namespace ChangingSizeOfArray
{
	class Program
	{
        private static int[] original;

        static void Main(string[] args)
		{
          

        }
        public int[] GrowArray(int[] original, int howManyMoreElements)
        {
            int[] newArray = new int[original.Length + howManyMoreElements];

            for (int i = 0; i < original.Length; i++)
            {
                // copy the element at the current index 
                // from original to newArray
                newArray[i] = original[i];
            }

            return newArray;
        }
    }
}
