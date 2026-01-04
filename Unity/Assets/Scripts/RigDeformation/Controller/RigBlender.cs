using Andre.RigDeformation.Model;

namespace Andre.RigDeformation.Controller
{

	/// <summary>
	/// Applies blended bone scale data from two <see cref="BoneScaleProfile"/>s
	/// onto a runtime <see cref="Rig"/>.
	/// </summary>
	/// <remarks>
	/// The blending logic is agnostic of interpolation math and delegates
	/// value interpolation to an injected <see cref="IScaleInterpolator"/>.
	/// Bone scale data is sourced from a shared <see cref="BoneScaleRegistry"/>.
	/// </remarks>
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
			var startScales = boneScaleRegistry.BoneScaleProfiles[startIndex].BoneScaleEntries;
			var endScales = boneScaleRegistry.BoneScaleProfiles[endIndex].BoneScaleEntries;

			foreach (var (boneKey, startScale) in startScales)
			{
				var endScale = endScales[boneKey];
				var blended = scaleInterpolator.Interpolate(startScale, endScale, t);
				var bone = rig.GetBone(boneKey);
				bone.localScale = blended;
			}
		}
	}
}
