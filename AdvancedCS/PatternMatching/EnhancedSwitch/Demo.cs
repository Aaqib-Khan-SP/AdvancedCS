using Core.Interfaces;
using Core.Models.Shapes;

namespace AdvancedCS.PatternMatching.EnhancedSwitch
{
    internal class Demo : IRunnable
    {
        public static string ShapeToString(object shape) => shape switch
        {
            Circle { Radius: var r } when r < 10 => "This is a small circle",
            Circle { Radius: var r } when r > 10 && r < 20 => "This is a standard circle",
            Circle { Radius: var r } when r > 20 => "This is a big circle",
            Square { } => "This is a standard square",
            _ => throw new ArgumentException("Provided shape doesn't exist")
        };

        public void Run()
        {
            Console.WriteLine(ShapeToString(new Circle() { Radius = 8 }));
            Console.WriteLine(ShapeToString(new Circle() { Radius = 12 }));
            Console.WriteLine(ShapeToString(new Circle() { Radius = 25 }));
        }
    }
}
