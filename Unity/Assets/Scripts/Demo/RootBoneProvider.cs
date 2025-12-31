using Andre.RigDeformation.Model;
using System.Linq;
using UnityEngine;

namespace Andre.Demo
{
	public class RootBoneProvider : MonoBehaviour, IRootBoneProvider
	{
		private Transform rootBone;

		// TODO: Are we using linq in update?
		public Transform RootBone => rootBone ??= transform
			.GetComponentsInChildren<Transform>(true)
			.FirstOrDefault(t => t.name.EndsWith("Hips"));
	}
}
