using System;
using UnityEngine;

namespace Andre.RigDeformation.Model
{
	// TODO: Should this be a struct?
	[Serializable]
	public struct BoneScaleEntry
	{
		public string boneKey;
		public Vector3 scale;
	}
}