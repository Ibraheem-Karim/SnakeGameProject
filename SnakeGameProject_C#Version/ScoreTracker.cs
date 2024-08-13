namespace SnakeGameProject_C_Version
{
    internal class ScoreTracker
    {
        private int _score = 0;

        public int Score => _score;

	    public void IncreaseScoreByOne()
        {
            ++_score;
        }
        
        public void PrintScore() 
        {
            var aConsolePositionLocatedBesidesRightBoundary
                = (Boundaries.RIGHT_BOUNDARY + 3, 1);

            Console.SetCursorPosition
                (aConsolePositionLocatedBesidesRightBoundary.Item1,
                aConsolePositionLocatedBesidesRightBoundary.Item2);

            Console.ResetColor();
            Console.Write($"Your current score is: {Score}");
        }
    };
}
