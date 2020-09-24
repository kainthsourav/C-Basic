namespace CSharpIntermediate
{
    public class ChildClass : interhertiaceDemo
    {
        public int FontSize { get; set; }
        public string FontName { get; set; }

        public void AddHyperLink(string url)
        {
            System.Console.WriteLine("Url is "+url);
        }
    }
}
