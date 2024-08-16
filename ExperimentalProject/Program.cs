


using SnakeGameProject_C_Version;

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
            //TestingLinkedListExtension();
            //TestingReadKeyFunction();

            TestingCheckingValidKeyFunction();
        }

        private static void TestingCheckingValidKeyFunction()
        {
            var keyInfo = Console.ReadKey(intercept: true);
            char pressedKey = keyInfo.KeyChar;

            if (CheckIfUserPressedAValidKey(pressedKey))
            {
                Console.WriteLine( "True");
            }
            else
            {
                Console.WriteLine("Oh!No!");
            }
        }

        private static bool CheckIfUserPressedAValidKey(char pressedKey)
        {
            int integerValueOfChar = (int)pressedKey;

            return integerValueOfChar switch
            {
                (int)DirectionOfSnakeMovement.LEFT or
                (int)DirectionOfSnakeMovement.RIGHT or
                (int)DirectionOfSnakeMovement.UP or
                (int)DirectionOfSnakeMovement.DOWN => true,
                _ => false
            };
        }

        private static void TestingReadKeyFunction()
        {
            var keyInfo = Console.ReadKey(intercept: true);
            Console.WriteLine(keyInfo.KeyChar);
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




//Old version of that thing:

//else if (_snake.Length > 1)
//{
//    if (CheckIfNewPositionIsNotValid())
//    {
//        UndoHeadPositionUpdate(snakeMovementDirectionInput);
//    }
//    else
//    {
//        _snake.RemoveSnakeTail();

//        _snake.AddANewSnakeHead(_snake.HeadOfSnakeColumnPosition
//    , _snake.HeadOfSnakeRowPosition);
//    }
//    continue;
//}