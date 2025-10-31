using System.ComponentModel.DataAnnotations;
using System.Text;

static void SaveString(string path, string content)
{
    if (!path.EndsWith(".txt"))
    {
        throw new FormatException("the file name didn't end in '.txt'");
    }
    File.WriteAllText(path, content);
}

static string ReadText(string path)
{
    if (!path.EndsWith(".txt"))
    {
        throw new FormatException("the file name didn't end in '.txt'");
    }

    using (var fs = new FileStream(path, FileMode.Open, FileAccess.Read))
    {
        byte[] buffer = new byte[fs.Length];
        fs.Read(buffer, 0, buffer.Length);
        return Encoding.UTF8.GetString(buffer);
    }
}
string content = "This is indeed, a string.";
string path = "./output.txt";

SaveString(path, content);

Console.WriteLine(ReadText(path));