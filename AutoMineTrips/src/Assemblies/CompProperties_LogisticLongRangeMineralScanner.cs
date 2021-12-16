using RimWorld;
using System;
using Verse;

namespace AutoMineTrips
{
    public class CompProperties_LogisticLongRangeMineralScanner : CompProperties_LongRangeMineralScanner
    {
        public CompProperties_LogisticLongRangeMineralScanner()
        {
            compClass = typeof(CompLogisticLongRangeMineralScanner);
            Log.Message($"{nameof(CompProperties_LogisticLongRangeMineralScanner)} default ctor");
        }

        public CompProperties_LogisticLongRangeMineralScanner(Type _)
        {
            compClass = typeof(CompLogisticLongRangeMineralScanner);
            Log.Message($"{nameof(CompProperties_LogisticLongRangeMineralScanner)} custom type ctor");
        }
    }
}