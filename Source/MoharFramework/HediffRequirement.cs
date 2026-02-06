using Verse;
// Resharper disable all

namespace Mohar
{
    public class HediffRequirementSettings
    {
        public HediffDef hediffDef;
        public FloatRange severity = new FloatRange(0,1);

        public bool HasHediffDef => hediffDef != null;
    }
}