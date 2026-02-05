using Verse;

namespace MoharBlood
{
    public static class StaticCollections
    {
        public static Dictionary<Thing, MappedDamageFlash> DamageFlashCache = new Dictionary<Thing, MappedDamageFlash>();
        public static Dictionary<int, MappedHealthCard> HealthCardCache = new Dictionary<int, MappedHealthCard>();
    }
}
