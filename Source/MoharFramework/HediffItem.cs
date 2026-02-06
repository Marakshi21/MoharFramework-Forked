using Verse;
// Resharper disable all

namespace Mohar
{
    public class HediffItemToRemove
    {
        public HediffDef hediffDef;
        public HediffKeepingCondition specificCondition;

        public bool HasSpecificCondition => specificCondition != null;
    }
}
