﻿namespace _70_483.EventsAndCallBacks
{
    public delegate int GetValues(int a, int b);

    public class DelegateExamples
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Mul(int a, int b)
        {
            return a * b;
        }
    }
}