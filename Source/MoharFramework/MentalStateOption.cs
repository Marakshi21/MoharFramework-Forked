using Verse;

namespace Mohar
{
    public class MentalStateOption
    {
        public MentalStateDef mentalDef;
        public float weight = 1;

        public void Dump()
        {
            Log.Warning(
                "MentalStateDef:" + mentalDef.defName + "; " +
                "weight:" + weight + "; "
            );
        }
    }
}