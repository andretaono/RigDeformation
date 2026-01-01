using Andre.RigDeformation.Model;
using UnityEngine;

namespace Andre.RigDeformation.Controller
{
	public class RigFactory : IRigFactory
	{
		public Rig CreateRig(IRootBoneProvider rootBoneProvider, BoneKeyDefinition boneKeyDefinition)
		{
			var rig = new Rig();

			foreach (Transform t in rootBoneProvider.RootBone.GetComponentsInChildren<Transform>())
			{
				if (boneKeyDefinition.Contains(t.name))
				{
					rig.AddBone(t.name, t);
				}
			}

			return rig;
		}
	}
}
