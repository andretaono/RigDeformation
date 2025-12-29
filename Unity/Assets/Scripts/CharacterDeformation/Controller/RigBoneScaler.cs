using Assets.Scripts.CharacterDeformation.Model;
using UnityEngine;

namespace Erter.CharacterDeformation
{
	public class RigBoneScaler : IRigBoneScaler
	{

		public void SetScale(IRootBoneProvider rootBoneProvider, IBoneScaleProfile boneScaleProfile)
		{
			// TODO: Optimize - cache lookup?

			foreach (var boneScaleEntry in boneScaleProfile.ScaleEntries)
			{
				TraverseBoneHierarchy(rootBoneProvider.RootBone, boneScaleEntry.boneKey, boneScaleEntry.scale);
			}
		}

		private void TraverseBoneHierarchy(Transform bone, string key, Vector3 value)
		{
			foreach (Transform child in bone)
			{
				if (child.name.EndsWith(key))
				{
					child.localScale = value;
					break;
				}

				TraverseBoneHierarchy(child, key, value);
			}
		}
	}
}
