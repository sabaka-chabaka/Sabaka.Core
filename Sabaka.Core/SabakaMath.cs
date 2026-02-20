using SabakaLang;

namespace Sabaka.Core;

[SabakaExport("math")]
public class SabakaMath
{
    public SabakaMath() { }
    
    [SabakaExport("pi")]
    public float Pi = (float)Math.PI;
    
    [SabakaExport("e")]
    public float E = (float)Math.E;
    
    [SabakaExport("gold")]
    public float Gold = 1.6180339887f;
    
    [SabakaExport("abs")]
    public float Abs(float value) => (float)Math.Abs(value);
    
    [SabakaExport("round")]
    public float Round(float value) => (float)Math.Round(value);
    
    [SabakaExport("floor")]
    public float Floor(float value) => (float)Math.Floor(value);
    
    [SabakaExport("ceil")]
    public float Ceil(float value) => (float)Math.Ceiling(value);
}