using Verse;
// Resharper disable all

namespace Mohar
{
    public static class HediffGiverUtility
    {
        public static bool RetrieveItem(this HediffComp_DataHediff hdDH, HediffDef inputHediff, out ReplaceHediffItem RHI)
        {
            List<ReplaceHediffItem> Pool = hdDH.Props.replaceHediffs;
            RHI = Pool.Where(r => r.inputH == inputHediff).SingleOrDefault();
            return RHI != null;
        }
    }
}
