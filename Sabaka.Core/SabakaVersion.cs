using SabakaLang;

namespace Sabaka.Core;

[SabakaExport("version")]
public class SabakaVersion
{
    [SabakaExport("major")] 
    public int Major;
    
    [SabakaExport("minor")] 
    public int Minor;
    
    [SabakaExport("build")] 
    public int Build;
    
    [SabakaExport("revision")] 
    public int Revision;
}
