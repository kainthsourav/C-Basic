namespace AbstractsClasses
{
    public abstract class Shape
    {
        public int width { get; set; }
        public int height { get; set; }

        public abstract void Draw();

        public void Copy()  //non abstract method
        {
            System.Console.WriteLine("Copy Shape");
        }

        public void select()
        {
            System.Console.WriteLine("Select Shape");
        }
    }
}
