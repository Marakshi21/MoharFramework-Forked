using RimWorld;
using Verse;
// Resharper disable all

namespace Mohar
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
