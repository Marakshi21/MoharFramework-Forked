using Verse;
using HarmonyLib;
using System.Reflection;

namespace Mohar.Core
{
    [StaticConstructorOnStartup]
    public class HediffAddedPatch
    {
        public static bool TryPatch_HediffAdded(Harmony myPatch)
        {
            try
            {
                //MethodBase MyMethod = AccessTools.Method(typeof(Pawn_HealthTracker), "AddHediff", new Type[] { typeof(Hediff), typeof(BodyPartRecord), typeof(DamageInfo?), typeof(DamageWorker.DamageResult) });
                MethodBase MyMethod = AccessTools.Method(typeof(Hediff), "PostAdd");
                HarmonyMethod Postfix = new HarmonyMethod(typeof(ApplyPatch_HediffAdded), "Postfix_PostAdd");

                myPatch.Patch(MyMethod, null, Postfix);
            }
            catch (Exception e)
            {
                Log.Warning("MFW YAHA failed ApplyPatch_HediffAdded: " + e);
                return false;
            }

            return true;
        }

        static class ApplyPatch_HediffAdded
        {
            static void Postfix_PostAdd(Pawn ___pawn)
            {
                //Log.Warning("This is PostAdd(Hediff); p=" + ___pawn.Name );
                YahaUtility.UpdateDependingOnTriggerEvent(___pawn, TriggerEvent.hediff);
            }
        }
    }

}
