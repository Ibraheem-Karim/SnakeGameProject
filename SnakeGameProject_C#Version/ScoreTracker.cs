namespace SnakeGameProject_C_Version
{
    internal class ScoreTracker
    {
        private int _score = 0;

        public int Score => _score;

	    private void IncreaseScore(int value)
        {
            _score += value;
        }
        
        private void PrintScore() 
        {
            var aConsolePositionLocatedBesidesRightBoundary
                = (Boundaries.RIGHT_BOUNDARY + 3, 1);

            Console.SetCursorPosition
                (aConsolePositionLocatedBesidesRightBoundary.Item1,
                aConsolePositionLocatedBesidesRightBoundary.Item2);

            Console.ResetColor();
            Console.Write($"Your current score is: {Score}");
        }

        public void UpdateScore(int value)
        {
            IncreaseScore(value);
            PrintScore();
        }
    };
}
