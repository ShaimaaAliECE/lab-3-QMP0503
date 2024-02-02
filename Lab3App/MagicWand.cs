namespace Lab3App
{
    class MagicWand : Tool
    {
        protected MagicWand(string Description): base(Description){}
        protected override DoAcion(){
            Console.WriteLine("MagicWand is Used")
        }
        protected override Display()
        {
            Console.WriteLine("MagicWand"+this.Description + "is displayed")
        }
    }
}