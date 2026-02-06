using Verse;
// Resharper disable all

namespace Mohar
{
    public class HediffCompProperties_Filther : HediffCompProperties
    {

        public int MinTicksBetweenSprays = 60;
        public int MaxTicksBetweenSprays = 120;

        public ThingDef filthDef = null;

        public bool debug = false;

        public HediffCompProperties_Filther()
        {
            this.compClass = typeof(HediffComp_Filther);
        }
    }
}