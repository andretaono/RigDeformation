using Andre.RigDeformation.Model;
using UnityEngine;

namespace Andre.RigDeformation.Controller
{
	public class RigFactory : IRigFactory
	{
		private BoneKeyDefinition boneKeyDefinition;
		private RootBoneFinder rootBoneFinder;

		public RigFactory(
			BoneKeyDefinition boneKeyDefinition,
			RootBoneFinder rootBoneFinder) 
		{
			this.boneKeyDefinition = boneKeyDefinition;
			this.rootBoneFinder = rootBoneFinder;
		}

		public Rig CreateRig(Transform transform)
		{
			var rig = new Rig();
			var rootBone = rootBoneFinder.TryFindRootBone(transform);

			foreach (Transform t in rootBone.GetComponentsInChildren<Transform>())
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
