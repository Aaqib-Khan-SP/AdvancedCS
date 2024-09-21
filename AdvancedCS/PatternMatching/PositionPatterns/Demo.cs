using Core.Interfaces;

namespace AdvancedCS.PatternMatching.PositionPatterns
{
    internal class Demo : IRunnable
    {
        public void Run()
        {
            Console.WriteLine("NotImplemented");
            foreach (var (groupSize, date) in GetData())
            {
                Console.WriteLine($"Discount offered for {groupSize} on {date}({date.DayOfWeek}) is " + GetDiscount(groupSize, date));
            }
        }

        decimal GetDiscount(int groupSize, DateTime dateOfVisit) => (groupSize, dateOfVisit.DayOfWeek) switch
        {
            (2, DayOfWeek.Wednesday) => 0.30M,
            (_, DayOfWeek.Sunday) => 0.05M,
            _ => 0.0M,
        };

        private (int, DateTime)[] GetData()
        {
            return
            [
                (1,new DateTime(2024,12,1)),
                (2,new DateTime(2024,12,4)),
                (6,new DateTime(2024,12,5)),
            ];
        }
    }
}
