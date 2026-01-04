using Andre.RigDeformation.Model;

namespace Andre.RigDeformation.Controller
{
	public sealed class RigBlender : IRigBlender
	{
		private readonly IScaleInterpolator scaleInterpolator;
		private readonly BoneScaleRegistry boneScaleRegistry;

		public RigBlender(
			IScaleInterpolator scaleInterpolator,
			BoneScaleRegistry boneScaleRegistry)
		{
			this.scaleInterpolator = scaleInterpolator;
			this.boneScaleRegistry = boneScaleRegistry;
		}

		public void BlendProfiles(Rig rig, int startIndex, int endIndex, float t)
		{
			if (!IsAllowedToProceed())
				return;

			var startScales = boneScaleRegistry.BoneScaleProfiles[startIndex].BoneScaleEntries;
			var endScales = boneScaleRegistry.BoneScaleProfiles[endIndex].BoneScaleEntries;

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

		private bool IsAllowedToProceed()
		{
			// TODO: Are these checks necessary?
			if (boneScaleRegistry == null)
				return false;

			if (boneScaleRegistry.BoneScaleProfiles.Count < 2)
				return false;

			return true;
		}
	}
}
