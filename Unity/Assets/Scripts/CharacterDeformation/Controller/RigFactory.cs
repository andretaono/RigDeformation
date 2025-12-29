using Assets.Scripts.CharacterDeformation.Model;
using System.Collections.Generic;
using UnityEngine;

namespace Erter.CharacterDeformation
{
	public class RigFactory : IRigFactory
	{
		public IRig BuildRig(IRootBoneProvider rootBoneProvider, List<string> allKeys)
		{
			var rig = new Rig();


			foreach (Transform t in rootBoneProvider.RootBone.GetComponentsInChildren<Transform>())
			{
				if (allKeys.Contains(t.name))
				{
					rig.Bones.Add(new Bone(t.name, t));
				}
			}

			return rig;
		}
	}
}
