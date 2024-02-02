namespace Lab3App
{
    class Axe: Tool
    {
        protected Axe(string Description):base(Description){}
        //grabbing description from parent
        protected override DoAction()
        {
            Console.WriteLine("Axe is Used");
        }
        protected override Display()
        {
            Console.WriteLine("Axe "+ this.Description + " is displayed");
        }
    }
}