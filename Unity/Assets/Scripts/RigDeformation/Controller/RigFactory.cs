using Andre.RigDeformation.Model;
using System.Collections.Generic;
using UnityEngine;

namespace Andre.RigDeformation.Controller
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
					rig.AddBone(new Bone(t.name, t));
				}
			}

			return rig;
		}
	}
}
