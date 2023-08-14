﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetricoesGenerics.Services
{
    class CalculationServices
    {
        public T Max<T>(List<T> list) where T : IComparable
        {
            if (list.Count == 0)
            {
                throw new ArgumentException("the list can't be empty");
            }
            T max = list[0];
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i].CompareTo(max)==1)
                {
                    max = list[i];
                }
            }
            return max;
        }
    }
}
