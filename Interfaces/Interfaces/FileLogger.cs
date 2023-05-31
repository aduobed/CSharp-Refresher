public class FileLogger : ILogger

{
    private readonly string _path;

    public FileLogger(string path)
    {
        _path = path;
    }

    public void Error(string message)
    {
        log(message, "Error");
    }

    public void Info(string message)
    {
        log(message, "Info");
    }

    public void log(string message, string messageType)
    {
        using (var streamWriter = new StreamWriter(_path, true))
        {
            streamWriter.WriteLine(messageType + " : " + message);
        }
    }
}
