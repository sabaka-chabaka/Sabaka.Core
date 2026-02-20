using SabakaLang;

namespace Sabaka.Core;

[SabakaExport("console")]
public class SabakaConsole
{
    public SabakaConsole() { }
    
    [SabakaExport("setColor")]
    public void SetColor(int color) => Console.ForegroundColor = (ConsoleColor)color;
    
    [SabakaExport("setBackgroundColor")]
    public void SetBackgroundColor(int color) => Console.BackgroundColor = (ConsoleColor)color;
}
