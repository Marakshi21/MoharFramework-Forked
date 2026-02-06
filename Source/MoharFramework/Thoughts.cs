using RimWorld;
using Verse;
// Resharper disable all

namespace Mohar
{
    public class GameThoughts
    {
        public List<ThoughtParameter> thoughtOptionPerShot;
        public List<ThoughtParameter> thoughtOptionPlayingTogether;
        
    }

    public class ThoughtParameter
    {
        public List<ThoughtDef> thoughtPool;
        public List<string> iconPool;
        public List<ThingDef> bubblePool;

        public float triggerChance;
        public float minTriggerChance;
        public float rivalryChancePerOpponent;

        public FloatRange distanceThreshold;

        public int numberOfThoughtsPerJob = -1;

        public bool IsUnlimitedThought => numberOfThoughtsPerJob == -1;
        //private Texture2D iconInt;
    }

}
