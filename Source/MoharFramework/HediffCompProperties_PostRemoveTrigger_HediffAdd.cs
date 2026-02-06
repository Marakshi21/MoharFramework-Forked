using Verse;
// Resharper disable all

namespace Mohar
{
	public class HediffCompProperties_PostRemoveTrigger_HediffAdd : HediffCompProperties
	{
        //what
        public List<HediffDef> triggeredHediff;

        public bool debug = false;

        public HediffCompProperties_PostRemoveTrigger_HediffAdd()
		{
			this.compClass = typeof(HediffComp_PostRemoveTrigger_HediffAdd);
		}
	}
}
