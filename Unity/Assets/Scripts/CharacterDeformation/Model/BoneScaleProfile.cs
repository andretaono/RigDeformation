using Assets.Scripts.CharacterDeformation.Model;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Rig Deformation/Bone Scale Profile")]
public class BoneScaleProfile : ScriptableObject, IBoneScaleProfile
{
	public BoneKeyDefinition boneKeys;

	public List<BoneScaleEntry> scales = new List<BoneScaleEntry>();
	public List<BoneScaleEntry> ScaleEntries => scales;

	// Optional runtime lookup cache TODO: is this needed?
	//private Dictionary<string, Vector3> _lookup;

	public Vector3 GetScale(string boneKey)
	{
		return scales.Find((e) => e.boneKey == boneKey).scale;
	}

	public void SetScale(string boneKey, Vector3 scale)
	{
// TODO: optimize - this could the dictionary lookup might be good to add back here.
		var entry = scales.Find((e) => e.boneKey == boneKey);

		entry.scale = scale;
	}
}