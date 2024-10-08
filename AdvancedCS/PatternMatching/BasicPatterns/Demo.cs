﻿using Core.Interfaces;

namespace AdvancedCS.PatternMatching.BasicPatterns
{
    internal class Demo : IRunnable
    {
        public void Run()
        {
            IsSuccess(23);
        }

        public void IsSuccess(object value)
        {
            if (value is int l || value is string str && int.TryParse(str, out l))
            {
                Console.WriteLine(l);
            }
        }
        
    }
}