namespace Lab3App
{
    public abstract class CollectionBoard
    {
        public int TotalScore, TotalValue;
        public CollectionBoard(){
            TotalScore = 0;
            TotalValue = 0;
        }
        public CollectionBoard(score, value){
            TotalScore = score;
            TotalValue = value;
        }
    }
}