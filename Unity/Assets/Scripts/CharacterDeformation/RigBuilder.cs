using System.Collections.Generic;
using UnityEngine;

namespace Erter.CharacterDeformation
{
	public class RigBuilder : IRigBuilder
	{
		public IBone BuildRig(IRootBoneProvider rootBoneProvider, List<string> allKeys)
		{
			return BuildNode(rootBoneProvider.RootBone, allKeys);
		}

		private IBone BuildNode(Transform bone, List<string> allKeys)
		{
			var composite = new BoneComposite();

			AddBoneIfMatchesAnyKey(bone, allKeys, composite);
			AddChildBones(bone, allKeys, composite);

			return composite;
		}

		private void AddBoneIfMatchesAnyKey(Transform bone, List<string> allKeys, BoneComposite composite)
		{
			// Find a key the Transform name ends with
			string matchedKey = allKeys.Find(k => bone.name.EndsWith(k));

			if (matchedKey != null)
			{
				composite.Add(new Bone(bone, matchedKey));
			}
		}

		private void AddChildBones(Transform bone, List<string> allKeys, BoneComposite composite)
		{
			foreach (Transform child in bone)
			{
				composite.Add(BuildNode(child, allKeys));
			}
		}
	}
}
