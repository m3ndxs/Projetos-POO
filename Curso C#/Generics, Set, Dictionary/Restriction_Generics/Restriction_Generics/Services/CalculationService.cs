﻿namespace Restriction_Generics.Services
{
    public class CalculationService
    {
        public T Max<T>(List<T> list) where T : IComparable
        {
            if(list.Count == 0)
            {
                throw new ArgumentException("The list can not be empty!");
            }

            var max = list[0];

            for(int i = 1;  i < list.Count; i++)
            {
                if(list[i].CompareTo(max) > 0)
                {
                    max = list[i];
                }
            }

            return max;
        }
    }
}
