using AdvancedCS.Core;

namespace AdvancedCS.PatternMatching.EnhancedSwitch
{
    public class Demo : IRunnable
    {
        public static string ShapeToString(object shape) => shape switch
        {
            "circle" => "sdfsd",
            "add" => "fdfdf"
        };

        public void Run()
        {
            Console.WriteLine(ShapeToString("circle"));
        }
    }
}
