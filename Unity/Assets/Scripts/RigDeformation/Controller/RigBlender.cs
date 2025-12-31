using Andre.RigDeformation.Model;
using UnityEngine;

namespace Andre.RigDeformation.Controller
{
	public class RigBlender : IRigBlender
	{
		public void BlendProfiles(
			IRig rig,
			IBoneScaleProfile start,
			IBoneScaleProfile end,
			float t)
		{

			foreach (var boneScaleEntry in start.ScaleEntries)
			{
				var endBoneScale = end.GetScale(boneScaleEntry.boneKey);
				var lerpValue = Vector3.Lerp(start.GetScale(boneScaleEntry.boneKey), endBoneScale, t);
				var bone = rig.GetBone(boneScaleEntry.boneKey);
				bone.SetScale(lerpValue);
			}
		}
	}
}
