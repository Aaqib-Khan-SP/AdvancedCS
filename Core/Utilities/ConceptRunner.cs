namespace Core.Utilities
{
    public static class ConceptRunner
    {
        public static void Run<TEnum>(TEnum concept) where TEnum : Enum
        {
            string conceptName = concept.ToString();

            string categoryName = typeof(TEnum).Name;

            string fullClassName = $"AdvancedCS.{categoryName}.{conceptName}.Demo";

            Type demoType = Type.GetType(fullClassName);

            if (demoType != null)
            {
                var demoInstance = Activator.CreateInstance(demoType);

                var method = demoType.GetMethod("Run");

                if (method != null)
                {
                    method.Invoke(demoInstance, null);
                }
                else
                {
                    Console.WriteLine($"Method 'Run' not found in {fullClassName}");
                }
            }
            else
            {
                Console.WriteLine($"Class '{fullClassName}' not found.");
            }
        }
    }
}
