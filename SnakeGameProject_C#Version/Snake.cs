namespace SnakeGameProject_C_Version
{
    internal class Snake
    {
        private int _headOfSnakeColumnPosition = 20;
        private int _headOfSnakeRowPosition = 8;
        private const char SNAKE_PART = '@';
        private LinkedList<Tuple<int, int>> _listOfSnakePartsPositions = new LinkedList<Tuple<int, int>>();
        private HashSet<Tuple<int, int>> _hashSetOfPositions = new HashSet<Tuple<int, int>>();

        public int HeadOfSnakeRowPosition => _headOfSnakeRowPosition;
        public int HeadOfSnakeColumnPosition => _headOfSnakeColumnPosition;
        public int Length => _listOfSnakePartsPositions.Count;
                

        public void IncrementHeadColumnPosition()
        {
            ++_headOfSnakeColumnPosition;
        }

        public void DecrementHeadColumnPosition()
        {
            --_headOfSnakeColumnPosition;
        }

        public void IncrementHeadRowPosition()
        {
            ++_headOfSnakeRowPosition;
        }

        public void DecrementHeadRowPosition()
        {
            --_headOfSnakeRowPosition;
        }

        public bool ContainsPosition(int column, int row)
        {
            var positionToSearchFor = Tuple.Create(column, row);
            return _hashSetOfPositions.Contains(positionToSearchFor);
        }

        public void AddANewSnakeHead(int column, int row)
        {
            var positionToAdd = Tuple.Create(column, row);
            _listOfSnakePartsPositions.AddLast(positionToAdd);
            _hashSetOfPositions.Add(positionToAdd);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(column, row);
            Console.WriteLine(SNAKE_PART);
        }

        public void RemoveSnakeTail()
        {
            Tuple<int, int> temporary = _listOfSnakePartsPositions.First();
            _listOfSnakePartsPositions.RemoveFirst();
            _hashSetOfPositions.Remove(temporary);

            Console.SetCursorPosition(temporary.Item1, temporary.Item2);
            Console.WriteLine(" ");
        }

        public Tuple<int, int> GetPositionBeforeHead()
        {
            var positionBeforeHead = _listOfSnakePartsPositions.GetSecondToLastElement();

            return positionBeforeHead;
        }
    }
}
