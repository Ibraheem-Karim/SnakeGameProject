


namespace ExperimentalProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ChangingBackgroundColor();
            //SettingCursorPosition();
            //Boundaries.DrawBoundaries();
            //APairTuple();
            TestingLinkedListExtension();

        }

        private static void TestingLinkedListExtension()
        {
            var someList = new LinkedList<float>();

            try
            {
                Console.WriteLine(someList.GetSecondToLastElement());

                Console.WriteLine( "hello");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

        }

        private static void APairTuple()
        {
            var pair = (1, "one");
            Console.WriteLine($"First: {pair.Item1}, Second: {pair.Item2}");
        }

        private static void SettingCursorPosition()
        {
            Console.SetCursorPosition(50, 5);
            Console.WriteLine( "hello");
        }

        private static void ChangingBackgroundColor()
        {
            Console.WriteLine("Hello, World!");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Hello, World!");
            Console.ResetColor();
            Console.WriteLine("Hello, World!");
        }
    }
}
