using Verse;
using UnityEngine;
using System.Linq;
using System.Collections.Generic;

namespace MoharAiJob
{
    public static class RetrieveDefs
    {
        public static CorpseJobDef RetrieveCorpseJobDef(this Pawn p, out bool outDebug, bool MyDebug = false)
        {
            string myDebugStr = MyDebug ? p.ThingID + " MoharAiJob.RetrieveDefs.RetrieveCorpseJobDef - " : string.Empty;
            CorpseJobDef DefToUse = DefDatabase<CorpseJobDef>.AllDefs.Where(cjd => cjd.workerPawnKind.Contains(p.kindDef)).FirstOrFallback(null);
            outDebug = false;
            if (DefToUse == null || DefToUse.IsEmpty)
            {
                if (MyDebug) Log.Warning(myDebugStr + "found no CorpseJobDef for " + p.kindDef + "; exit");
                return null;
            }
            outDebug = DefToUse.debug;

            //if (MyDebug) Log.Warning(myDebugStr + "found CJD for " + p.kindDef + ", debug is now:" + outDebug + "; OK");

            return DefToUse;
        }
        
        public static IEnumerable<CorpseRecipeSettings> RetrieveCorpseRecipeSettings(this Pawn p, CorpseJobDef CJD, bool MyDebug = false)
        {
            string myDebugStr = MyDebug ? p.ThingID + " MoharAiJob.RetrieveDefs.RetrieveCorpseRecipeSettings " : string.Empty;

            IEnumerable <CorpseRecipeSettings> CRSList = p.WorkerFulfillsRequirements(CJD, MyDebug);
            if (CRSList.EnumerableNullOrEmpty())
            {
                if (MyDebug) Log.Warning(myDebugStr + "pawns does not fulfil requirements; exit");
                return null;
            }

            if (!CRSList.Any(c => c.HasTargetSpec))
            {
                if (MyDebug) Log.Warning(myDebugStr + "CRS has no Corpse category def; exit");
                return null;
            }

            //if (MyDebug) Log.Warning(myDebugStr + "found CRS ("+CRSList.Count()+") OK");

            return CRSList;
        }

    }
}
