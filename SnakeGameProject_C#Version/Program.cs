namespace SnakeGameProject_C_Version
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShowWelcomingMessage();

            Console.Clear();
            
            var scoreTracker = new ScoreTracker();
            var snake = new Snake();
            
            GameEngine gameEngine = new GameEngine(snake, scoreTracker);

            gameEngine.startGame();
            Console.Clear();
            Console.ResetColor();

            ShowExitingMessage(scoreTracker.Score);
        }

        private static void ShowWelcomingMessage()
        {
            Console.WriteLine("Welcome to the thrilling snake game, here're the instructions for playing the game:");
            Console.WriteLine("Once the game starts, press the key 'a' to move left, 'd' to move right \n" +
                " , 's' to move downward, and 'w' to move upward... \n");
            Console.WriteLine("Now, press any key to start the game:");
            Console.ReadKey(intercept: true);
        }

        private static void ShowExitingMessage(int finalScore)
        {
            Console.WriteLine("Game over!!");
            Console.WriteLine($"Your final score is: {finalScore}");
            Console.ReadKey(intercept: true);
        }

        
    }
}
