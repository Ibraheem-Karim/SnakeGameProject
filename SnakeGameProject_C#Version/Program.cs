namespace SnakeGameProject_C_Version
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShowWelcomingMessage();

            Console.Clear();
            
            Background background = new Background(new Snake(), new ScoreTracker());
            //Console console = new Console();
            int finalScore;

            finalScore = background.startGame();
            Console.Clear();
            //c->chooseColor('w');

            ShowExitingMessage(finalScore);
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
            Console.WriteLine("\"Game over!!");
            Console.WriteLine($"Your final score is: {finalScore}");
            Console.ReadKey(intercept: true);
        }

        
    }
}
