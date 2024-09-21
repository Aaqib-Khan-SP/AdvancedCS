using AdvancedCS.Concepts;
using AdvancedCS.Core;

namespace AdvancedCS.PatternMatching.BasicPatterns
{
    public class Demo : IRunnable
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