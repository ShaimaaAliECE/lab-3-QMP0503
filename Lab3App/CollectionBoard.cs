namespace Lab3App
{
    public class CollectionBoard
    {
        public static int TotalScore, TotalValue;
        public CollectionBoard()
        {
            TotalScore = 0;
            TotalValue = 0;
        }
        public CollectionBoard(int score, int value)
        {
            TotalScore = score;
            TotalValue = value;
        }
    }
}