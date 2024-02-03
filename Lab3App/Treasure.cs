using System;
using System.Collections.Generic;

namespace Lab3App
{
     abstract class Treasure : Collectable{
        public int Score
        {
            get;set;
        }
        public Treasure(string Description, int Score) : base(Description)
        {
            this.Score = Score;
        }
        public void UpdateTotalScore()
        {
            CollectionBoard.TotalScore += Score;
            Console.WriteLine("Total Score is updated to: "+CollectionBoard.TotalScore);
        }
        public override void AddMe(List<Collectable> list){
            Console.WriteLine(this.Description + " Collected, Congrats!!!!");
            UpdateTotalScore();
        }   
    }

}