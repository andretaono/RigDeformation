using Assets.Scripts.CharacterDeformation.Model;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Rig Deformation/Bone Scale Registry")]
public class BoneScaleRegistry : ScriptableObject, IBoneScaleRegistry
{
// TODO: Add validators to make sure bone names are correct and no empty fields

	[SerializeField]
	private BoneKeyDefinition boneKeyDefinition;

	[SerializeField]
	private List<BoneScaleProfile> boneScaleProfiles;

	public BoneKeyDefinition BoneKeyDefinition => boneKeyDefinition;
	public List<BoneScaleProfile> BoneScaleProfiles => boneScaleProfiles;

	//public BoneScaleProfile Get(string id) => boneScaleProfiles.Find(p => p.name == id);
// TODO: Just expose the whole list in the getter and get by index?
}