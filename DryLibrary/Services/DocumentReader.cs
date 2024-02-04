namespace DryLibrary.Services;

public class DocumentReader
{
    public static string Load(string filePath)
    {
        var content = string.Empty;
        StreamReader reader = new(filePath);
        while (!reader.EndOfStream)
        {
            content += reader.ReadLine();
        }
        reader.Dispose();

        return content;
    }
}