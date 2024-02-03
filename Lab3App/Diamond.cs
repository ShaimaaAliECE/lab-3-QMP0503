using System;

namespace Lab3App
{
    class Diamond : Treasure
    {
        public Diamond(string description, int score): base(description, score){}
        public override void Display()
        {
            Console.WriteLine("Diamond " + this.Description + " is displayed");
        }
    }
}