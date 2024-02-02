namespace Lab3App
{
    abstract class Tool : Collectable{
        protected Tool(string Description) : base(Description){} //calls the parent class
        void DoAction(){}
        protected override addMe(List<Collectable> list){
            Console.WriteLine(this.Description + " Collected, Congrats!!!!");
            DoAction();
        }
    }
}