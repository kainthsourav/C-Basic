using System.Collections.Generic;
namespace CSharpIntermediate
{
    public class HttpCoookie
    {
        private readonly Dictionary<string, string> _dict;
        public HttpCoookie()
        {
            _dict = new Dictionary<string, string>();
        }
        public string this[string key]
        {
            get { return _dict[key]; }
            set { _dict[key] = value; }
        }
    }
}
