using SnakeGameProject_C_Version;

namespace ExperimentalProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ChangingBackgroundColor();
            //SettingCursorPosition();
            Boundaries.DrawBoundaries();
        }

        private static void SettingCursorPosition()
        {
           // Console.SetCursorPosition(c, r);
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
