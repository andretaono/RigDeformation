using System.Collections.Generic;
using UnityEngine;

namespace Andre.RigDeformation.Model
{
	[CreateAssetMenu(menuName = "Rig Deformation/Bone Key Definition")]
	public class BoneKeyDefinition : ScriptableObject
	{
		public List<string> boneKeys = new List<string>();
		// TODO: make immutable at runtime? : public IReadOnlyList<string> BoneKeys => boneKeys.boneKeys;
	}
}