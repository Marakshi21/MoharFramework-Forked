using Verse;

namespace Mohar
{
    public class CommonSettings
    {
        public StackSettings stack;
        public FilthSettings filth;
    }
    public class StackSettings
    {
        public IntRange spawnCount = new IntRange(1, 1);
        public bool weightedSpawnCount = false;
    }

    public class FilthSettings
    {
        public ThingDef filthDef = null;
        public IntRange filthNum = new IntRange(1, 1);
        public FloatRange filthRadius = new FloatRange(1, 1);
    }
}