using Erter.CharacterDeformation;
using System.Linq;
using UnityEngine;

namespace Erter.Demo
{
	public class RootBoneProvider : MonoBehaviour, IRootBoneProvider
	{
		private Transform rootBone;
		public Transform RootBone => rootBone ??= transform
			.GetComponentsInChildren<Transform>(true)
			.FirstOrDefault(t => t.name.EndsWith("Hips"));
	}
}
