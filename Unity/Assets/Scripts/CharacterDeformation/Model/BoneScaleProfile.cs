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

	private Dictionary<string, Vector3> _scaleLookup;

	private void OnEnable()
	{
		BuildLookup();
	}

	// Generate lookup dictionary for faster per-frame lookups
	private void BuildLookup()
	{
		_scaleLookup = new Dictionary<string, Vector3>(scales.Count);

		foreach (var entry in scales)
		{
			_scaleLookup[entry.boneKey] = entry.scale;
		}
	}

	public Vector3 GetScale(string boneKey)
	{
		return _scaleLookup[boneKey];
	}

	public void SetScale(string boneKey, Vector3 scale)
	{
		_scaleLookup[boneKey] = scale;
	}

}