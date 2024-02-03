using System;

namespace Lab3App
{
     class MagicWand : Tool
     {
        public MagicWand(string Description) : base(Description) { }
        public override void DoAction(){
            Console.WriteLine($"MagicWand is Used");
        }
        public override void Display()
        {
            Console.WriteLine($"MagicWand" + this.Description + "is displayed");
        }
     }
}