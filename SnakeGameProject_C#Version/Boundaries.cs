namespace SnakeGameProject_C_Version
{
    internal static class Boundaries
    {
        public const int LEFT_BOUNDARY = 0;
        public const int RIGHT_BOUNDARY = 41;
        public const int UPPER_BOUNDARY = 0;
        public const int LOWER_BOUNDARY = 17;

        public static void DrawBoundaries()
        {
            Console.SetCursorPosition(0, 0);

            for (int i = UPPER_BOUNDARY; i <= LOWER_BOUNDARY; i++)
            {
                for (int j = LEFT_BOUNDARY; j <= RIGHT_BOUNDARY; j++)
                {
                    if (i == UPPER_BOUNDARY)
                    {                        
                        Console.Write((j == LEFT_BOUNDARY || j == RIGHT_BOUNDARY) ? " " : "_");
                    }
                    else if (i == LOWER_BOUNDARY)
                    {
                        Console.Write('^');
                    }
                    else
                    {                        
                        Console.Write((j == LEFT_BOUNDARY || j == RIGHT_BOUNDARY) ? "|" : " ");
                    }
                }
                Console.WriteLine();
            }
        }

    }

}
