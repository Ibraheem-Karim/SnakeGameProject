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
    };
}
