using System;

namespace Lab3App
{
    class Axe: Tool
    {
        public Axe(string Description): base(Description) { }
        //grabbing description from parent
        public override void DoAction()
        {
            Console.WriteLine("Axe is Used");
        }
        public override void Display()
        {
            Console.WriteLine("Axe "+ this.Description + " is displayed");
        }
    }
}