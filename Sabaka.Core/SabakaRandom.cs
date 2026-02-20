using SabakaLang;

namespace Sabaka.Core;

[SabakaExport("random")]
public class SabakaRandom
{
    public SabakaRandom() { }

    [SabakaExport("next")]
    public int Next(int min, int max) => new Random().Next(min, max);
}