using System.IO;

namespace InterfaceDemo
{
    public class FileLogger : ILogger
    {
        private readonly string _path;
        public FileLogger(string path)
        {
            _path = path;
        }
        public void LogError(string msg)
        {
            Log("ERROR", msg);
        }

        public void LogInfo(string msg)
        {
            Log("INFO",msg);
        }

        public void Log(string msgType, string msg)
        {
            using (var streamwriter = new StreamWriter(_path, true))
            {
                streamwriter.WriteLine(msgType+" : " + msg);
            }
        }
    }
}
