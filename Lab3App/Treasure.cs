namespace Lab3App
{
    public abstract class Treasure : Collectable{
        public int Score
        {
            get;set;
        }
        public void UpdateTotalScore()
        {
            int currentScore = CollectionBoard.TotalScore + Score;
            Console.WriteLine("Total Score is updated to: "+currentScore);
        }
        protected override void AddMe(List<Collectable> list){
            Console.WriteLine(this.Description + " Collected, Congrats!!!!");
            UpdateTotalScore();
        }   
    }

}