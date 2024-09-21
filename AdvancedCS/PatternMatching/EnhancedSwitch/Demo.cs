
using Core.Interfaces;

namespace AdvancedCS.PatternMatching.EnhancedSwitch
{
    internal class Demo : IRunnable
    {
        public static string ShapeToString(object shape) => shape switch
        {
            "Circle" => "This is a standard circle",
            "Square" => "This is a standard square"
        };

        public void Run()
        {
            Console.WriteLine(ShapeToString("Circle"));
        }
    }
}
