using System;
using System.Collections.Generic;


namespace Lab3App
{
     class Coin:Treasure
    {
        protected int value
        {
            get;set;
        }
        public Coin(string description, int score, int value) : base(description,score)
        {
            this.value = value;
        }
        public void UpdateTotalValue()
        {
            CollectionBoard.TotalValue += value;
            Console.WriteLine("Total Value is updated to: "+CollectionBoard.TotalValue);
        }
        public override void Display()
        {
            Console.WriteLine("Coin " + this.Description + " is displayed");
        }
        public override void AddMe(List<Collectable> collectable) { 
            base.AddMe(collectable);
            UpdateTotalValue(); 
        }
    }
}