using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Rig Deformation/Bone Key Definition")]
public class BoneKeyDefinition : ScriptableObject
{
	public List<string> boneKeys = new List<string> ();
}