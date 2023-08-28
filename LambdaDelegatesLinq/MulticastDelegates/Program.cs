using System;
using System.Collections.Generic;
using System.ComponentModel;
using MulticastDelegates.Services;


namespace LambdaDelegatesLinq
{
    delegate void BinaryNumericOperation(double n1, double n2);
    class Program
    {
        static void Main(string[] args)
        {
            double a = 10.0;
            double b = 12;

            BinaryNumericOperation op = CalculationService.ShowSum;
            op += CalculationService.ShowMax;

            op(a, b);
        }
    }
}