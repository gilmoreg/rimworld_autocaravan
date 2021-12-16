using RimWorld;
using System.Collections.Generic;
using Verse;

namespace AutoMineTrips
{
    public class CompLogisticLongRangeMineralScanner : CompLongRangeMineralScanner
    {
        private ThingDef targetMineable;

        public new CompProperties_LogisticLongRangeMineralScanner Props => this.props as CompProperties_LogisticLongRangeMineralScanner;

        public override void CompTickLong()
        {
            base.CompTickLong();
            Log.Message($"{nameof(CompLogisticLongRangeMineralScanner)} {nameof(CompTickLong)} {nameof(CanUseNow)}:{CanUseNow} {nameof(CompInspectStringExtra)}:{CompInspectStringExtra()}");
        }

        public override void PostExposeData()
        {
            Log.Message($"{nameof(CompLogisticLongRangeMineralScanner)} {nameof(PostExposeData)}");

            base.PostExposeData();
        }

        public override void Initialize(CompProperties props)
        {
            Log.Message($"{nameof(CompLogisticLongRangeMineralScanner)} {nameof(Initialize)}");
            base.Initialize(props);
            this.SetDefaultTargetMineral();
        }

        private void SetDefaultTargetMineral() => this.targetMineable = ThingDefOf.MineableGold;

        protected override void DoFind(Pawn worker)
        {
            Log.Message($"{nameof(CompLogisticLongRangeMineralScanner)} {nameof(DoFind)} {nameof(CanUseNow)}:{CanUseNow} {nameof(CompInspectStringExtra)}:{CompInspectStringExtra()}");

            base.DoFind(worker);
        }

        public override IEnumerable<Gizmo> CompGetGizmosExtra()
        {
            // Log.Message($"{nameof(CompLogisticLongRangeMineralScanner)} {nameof(CompGetGizmosExtra)}");

            return base.CompGetGizmosExtra();
        }
    }
}