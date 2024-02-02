namespace Lab3App
{
    public class Coin:Treasure
    {
        protected int Value
        {
            get;set;
        }
        public Coin(int value, int score, string description): base(description,score)
        {
            Value = value;
        }
        public void UpdateTotalValue()
        {
            int currentValue = Value + CollectionBoard.TotalValue;
            Console.WriteLine("Total Value is updated to: "+currentValue);
        }
        protected override void Display()
        {
            Console.WriteLine("Coin "+ this.Description+ " is displayed")
        }
        public override void AddMe(List<Collectable> collectable) { 
            base.AddMe(collectable);
            UpdateTotalValue(); 
        }
    }
}