namespace Lab3App
{
    public abstract class Collectable : Displayable
    {
        public string Description{
            get;set; //getter, setter method
        }
        void abstract AddMe(List<Collectable> list);
        public CollectionBoard collectionBoard;
    
    }
}