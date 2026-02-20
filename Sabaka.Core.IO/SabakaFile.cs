using SabakaLang;

namespace Sabaka.Core.IO;

[SabakaExport("file")]
public class SabakaFile
{
    public SabakaFile() { }

    [SabakaExport("create")]
    public void CreateFile(string path)
    {
        File.Create(path);
    }
    
    [SabakaExport("remove")]
    public void RemoveFile(string path)
    {
        File.Delete(path);
    }
    
    [SabakaExport("exists")]
    public bool Exists(string path)
    {
        return File.Exists(path);
    }
    
    [SabakaExport("read")]
    public string ReadFile(string path)
    {
        return File.ReadAllText(path);
    }
    
    [SabakaExport("write")]
    public void WriteFile(string path, string content)
    {
        File.WriteAllText(path, content);
    }
}