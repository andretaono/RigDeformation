using Assets.Scripts.CharacterDeformation.Model;
using System.Collections.Generic;
using UnityEngine;

class FakeBoneScaleProfile : IBoneScaleProfile
{
	private readonly Dictionary<string, Vector3> _scales;

	public FakeBoneScaleProfile(Dictionary<string, Vector3> scales)
	{
		_scales = scales;
		ScaleEntries = BuildEntries(scales);
	}

	public List<BoneScaleEntry> ScaleEntries { get; }

	public Vector3 GetScale(string boneKey)
	{
		return _scales[boneKey];
	}

	private static List<BoneScaleEntry> BuildEntries(
		Dictionary<string, Vector3> scales)
	{
		var list = new List<BoneScaleEntry>();
		foreach (var key in scales.Keys)
		{
			list.Add(new BoneScaleEntry { boneKey = key });
		}
		return list;
	}

	public void SetScale(string boneKey, Vector3 scale)
	{
		throw new System.NotImplementedException();
	}
}
