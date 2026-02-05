using RimWorld;
using Verse;

namespace MoharBlood
{
    [DefOf]
    public static class MyEffecterDefOf
    {
        public static EffecterDef Surgery;
        public static EffecterDef ButcherFlesh;

        static MyEffecterDefOf()
        {
            DefOfHelper.EnsureInitializedInCtor(typeof(MyEffecterDefOf));
        }
    }


}
