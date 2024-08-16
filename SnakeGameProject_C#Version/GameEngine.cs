namespace SnakeGameProject_C_Version
{
    internal class GameEngine
    {
        private const char PIECE_OF_FOOD = 'O';
        private int _randomFoodColumn;
        private int _randomFoodRow;
        private Snake _snake;
        private ScoreTracker _scoreTracker;
        private bool _snakeHitItself = false;
        private bool _snakeAteFood = false;

        public GameEngine(Snake snake, ScoreTracker scoreTracker)
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

        private bool CheckIfSnakeHitBoundaries()
        {
            return _snake.HeadOfSnakeColumnPosition == Boundaries.LEFT_BOUNDARY ||
                _snake.HeadOfSnakeColumnPosition == Boundaries.RIGHT_BOUNDARY ||
                 _snake.HeadOfSnakeRowPosition == Boundaries.UPPER_BOUNDARY ||
                _snake.HeadOfSnakeRowPosition == Boundaries.LOWER_BOUNDARY;
        }

        public void startGame()
        {
            Boundaries.DrawBoundaries();
            this.GenerateAPieceOfFoodWithinBoundaries();

            while(true)
            {
                DirectionOfSnakeMovement snakeMovementDirectionInput
                    = GetSnakeDirectionInput();

                moveSnake(snakeMovementDirectionInput);

                if(CheckIfSnakeAteFood())
                {
                    _snakeAteFood = true;
                    _scoreTracker.UpdateScore(1);
                }
                else if(CheckIfSnakeHitBoundaries() || _snakeHitItself)
                {
                    return;
                }
            }
        }

        private void moveSnake(DirectionOfSnakeMovement movementDirectionInput)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            switch (movementDirectionInput)
            {
                case DirectionOfSnakeMovement.UP: _snake.DecrementHeadRowPosition();
                    break;
                case DirectionOfSnakeMovement.DOWN: _snake.IncrementHeadRowPosition();
                    break;
                case DirectionOfSnakeMovement.LEFT: _snake.DecrementHeadColumnPosition();
                    break;
                case DirectionOfSnakeMovement.RIGHT:_snake.IncrementHeadColumnPosition();
                    break;
                default:
                    break;
            }

            if (CheckIfMovementIsNotValid())
            {
                UndoMove(movementDirectionInput);
                return;
            }



            bool CheckIfMovementIsNotValid()
            {
                return _snake.HeadOfSnakeColumnPosition == _snake.GetPositionBeforeHead().Item1
                    && _snake.HeadOfSnakeRowPosition == _snake.GetPositionBeforeHead().Item2;
            }  
            bool CheckIfSnakeHitItself()
            {

            }
        }

        private void UndoMove(DirectionOfSnakeMovement movementDirectionInput)
        {
            switch (movementDirectionInput)
            {
                case DirectionOfSnakeMovement.UP:
                    _snake.IncrementHeadRowPosition();
                    break;
                case DirectionOfSnakeMovement.DOWN:
                    _snake.DecrementHeadRowPosition();
                    break;
                case DirectionOfSnakeMovement.LEFT:
                    _snake.IncrementHeadColumnPosition();
                    break;
                case DirectionOfSnakeMovement.RIGHT:
                    _snake.DecrementHeadColumnPosition();
                    break;
                default:
                    break;
            }
        }

    }
}