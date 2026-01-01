using System.Collections.Generic;
using UnityEngine;

namespace Andre.RigDeformation.Model
{
	[CreateAssetMenu(menuName = "Andre/Rig Deformation/Bone Key Definition")]
	public class BoneKeyDefinition : ScriptableObject
	{
		[SerializeField]
		private List<string> boneKeys = new();

		public IReadOnlyList<string> BoneKeys => boneKeys;

		public bool Contains(string key)
		{
			return boneKeys.Contains(key);
		}
	}
}