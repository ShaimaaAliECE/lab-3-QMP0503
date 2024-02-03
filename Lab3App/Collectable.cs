using System.Collections.Generic;
using System;

namespace Lab3App
{
    abstract class Collectable : Displayable
    {
        public Collectable(string Description)
        {
            this.Description = Description;
        }
        public string Description{
            get;set; //getter, setter method
        }
        public virtual void AddMe(List<Collectable> list)
        {
            list.Add(this);
            Console.WriteLine($"{Description} Collected, Congrats!!!!");
        }
        
        public CollectionBoard Board
        {
            get;set;
        }
        public abstract void Display();
    
    }
}