using SabakaLang;

namespace Sabaka.Core.IO;

[SabakaExport("directory")]
public class SabakaDirectory
{
    public SabakaDirectory() { }
    
    [SabakaExport("create")]
    public void MakeDir(string path)
    {
        System.IO.Directory.CreateDirectory(path);
    }

    [SabakaExport("remove")]
    public void RemoveDir(string path)
    {
        System.IO.Directory.Delete(path);
    }

    [SabakaExport("exists")]
    public bool Exists(string path)
    {
        return Directory.Exists(path);
    }

    [SabakaExport("current")]
    public string GetCurrentDirectory() => Directory.GetCurrentDirectory();
}