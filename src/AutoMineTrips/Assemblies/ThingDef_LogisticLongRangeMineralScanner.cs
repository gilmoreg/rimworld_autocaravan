using Verse;

namespace AutoMineTripsMod
{
    [StaticConstructorOnStartup]
    public class ThingDef_LogisticLongRangeMineralScanner : ThingDef
    {
        static ThingDef_LogisticLongRangeMineralScanner()
        {
            Log.Message($"{nameof(ThingDef_LogisticLongRangeMineralScanner)} ctor");
        }
    }
}