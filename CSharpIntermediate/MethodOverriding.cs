namespace CSharpIntermediate
{
    public class MethodOverriding
    {
        public virtual void Add(int x,int y)
        {
            System.Console.WriteLine("Base class  {0}", x+y);
        }
    }
}
