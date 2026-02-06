using Verse;
// Resharper disable all

namespace Mohar
{
    public class IndexEngine
    {
        public enum TickEngine
        {
            [Description("synced")]
            synced = 0,
            [Description("moteLifespan")]
            moteLifespan = 1,
            [Description("relativeMoteLifespan")]
            relativeMoteLifespan = 2,
            [Description("anotherLifespan")]
            anotherLifespan = 3,
        }
    }
}
