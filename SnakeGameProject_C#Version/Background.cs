namespace SnakeGameProject_C_Version
{
    internal class Background
    {
        private const char PIECE_OF_FOOD = 'O';
        private int _randomFoodColumn;
        private int _randomFoodRow;
        private Snake _snake;
        private ScoreTracker _scoreTracker;
        private bool SnakeHitItself = false;

        private bool _snakeAteFood = false;

        public Background(Snake snake, ScoreTracker scoreTracker)
        {
            this._snake = snake;
            this._scoreTracker = scoreTracker;
        }

        private void GenerateAPieceOfFoodWithinBoundaries()
        {
            var random = new Random();
            Console.ForegroundColor = ConsoleColor.Yellow;
            do
            {
                _randomFoodColumn = random.Next(Boundaries.LEFT_BOUNDARY + 1, Boundaries.RIGHT_BOUNDARY - 1);
                _randomFoodRow = random.Next(Boundaries.UPPER_BOUNDARY + 1, Boundaries.LOWER_BOUNDARY - 1);
            } while (_snake.ContainsPosition(_randomFoodColumn, _randomFoodRow));

            Console.SetCursorPosition(_randomFoodColumn, _randomFoodRow);
            Console.WriteLine(PIECE_OF_FOOD);
        }

        private void moveSnake()
        { }

        private DirectionOfSnakeMovement GetSnakeDirectionInput()
        {
            char pressedKey;
            do
            {
                var keyInfo = Console.ReadKey(intercept: true);
                pressedKey = keyInfo.KeyChar;
            } while (CheckIfUserPressedAValidKey(pressedKey));

            return (DirectionOfSnakeMovement)pressedKey;
        }

        private bool CheckIfUserPressedAValidKey(char pressedKey)
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

        private bool CheckIfSnakeAteFood()
        {
            return _snake.HeadOfSnakeColumnPosition == _randomFoodColumn &&
                _snake.HeadOfSnakeRowPosition == _randomFoodRow &&
                !_snakeAteFood;
        }

        internal int startGame()
        {
            throw new NotImplementedException();
        }
    }
}