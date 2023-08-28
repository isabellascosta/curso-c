﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using Delegates.Service;

namespace LambdaDelegatesLinq
{
    
    delegate double BinaryNumericOperation(double n1, double n2);
    class Program
    {
        static void Main(string[] args)
        {
            double a = 10.0;
            double b = 12;

            BinaryNumericOperation op = CalculationService.Max;
            double result = op(a, b); 
            Console.WriteLine(result);
        }
    }
}