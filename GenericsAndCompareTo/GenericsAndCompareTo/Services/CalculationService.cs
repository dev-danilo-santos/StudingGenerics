﻿using GenericsAndCompareTo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAndCompareTo.Services
{
    internal class CalculationService 
    {
        public T Max<T>(List<T> list) where T : IComparable
        {   
            if ((list.Count==0))
            {
               throw new ArgumentNullException("List is empty.");
            }
            T Max = list[0];
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i].CompareTo(Max)>0)
                {
                    Max = list[i];
                }
            }
            return Max;
        }

    }
}
