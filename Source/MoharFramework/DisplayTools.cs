using UnityEngine;
using Verse;

namespace Mohar
{
	public static class DisplayTools
    {
        public static Texture GetRealMaterial(this Thing thing)
        {
            return thing.Graphic.ExtractInnerGraphicFor(thing).MatAt(thing.def.defaultPlacingRot).mainTexture;
        }
	}
}