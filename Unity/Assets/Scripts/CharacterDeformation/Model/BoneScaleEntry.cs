using System;
using UnityEngine;

[Serializable]
public struct BoneScaleEntry
{
	// TODO: Private and serializable?
	public string boneKey;
	public Vector3 scale;
}