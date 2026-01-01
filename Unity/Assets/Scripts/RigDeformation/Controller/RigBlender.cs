using Andre.RigDeformation.Model;
using System.Collections.Generic;
using UnityEngine;

namespace Andre.RigDeformation.Controller
{
	public sealed class RigBlender : IRigBlender
	{
		private readonly IScaleInterpolator scaleInterpolator;

		public RigBlender(IScaleInterpolator scaleInterpolator)
		{
			this.scaleInterpolator = scaleInterpolator;
		}

		public void BlendProfiles(
			Rig rig,
			IReadOnlyDictionary<string, Vector3> startScales,
			IReadOnlyDictionary<string, Vector3> endScales,
			float t)
		{
			foreach (var (boneKey, startScale) in startScales)
			{
				// TODO: Is this check needed? Better to just let it fail?
				if (!endScales.TryGetValue(boneKey, out var endScale))
					continue;

				var blended = scaleInterpolator.Interpolate(startScale, endScale, t);
				var bone = rig.GetBone(boneKey);
				bone.localScale = blended;
			}
		}
	}
}
