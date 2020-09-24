using System;

namespace CSharpIntermediate
{
    public class MethodDemo
    {
        public int x;
        public int y;
        public MethodDemo(int x,int y)
        {
            this.x = x;
            this.y = y;
        }

        //Method overloading

        public void Move(int x,int y)
        {
            this.x = x;
            this.y = y;
        }
        public void Move(MethodDemo newmethodDemo)
        {
            if (newmethodDemo == null)
                throw new ArgumentNullException("newmethodDemo");
            else
            {
                Move(newmethodDemo.x, newmethodDemo.y);
            }
        }

        
    }
}
