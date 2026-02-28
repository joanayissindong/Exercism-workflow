using System;
using System.Collections.Generic;

public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max)
    {
        HashSet<int> uniqueMultiples = new HashSet<int>();

        foreach (int baseValue in multiples)
        {
            if (baseValue == 0) { continue; }

            for (int i = baseValue; i < max; i += baseValue)
            {
                uniqueMultiples.Add(i);
            }
        }
        
        int sum = 0;
        foreach (int value in uniqueMultiples)
        {
            sum += value;
        }
        return sum;
    }
}