using Verse;

namespace Mohar
{
    public class HediffCompProperties_FootPrinter : HediffCompProperties
    {

        public int period = 15;

        public ThingDef moteFootPrintDef = null;

        public bool debug = false;

        public HediffCompProperties_FootPrinter()
        {
            this.compClass = typeof(HediffComp_FootPrinter);
        }
    }
}