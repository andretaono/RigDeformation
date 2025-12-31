using System;
using UnityEngine;

namespace Andre.RigDeformation.Model
{
	[Serializable]
	public struct BoneScaleEntry
	{
		// TODO: Private and serializable?
		public string boneKey;
		public Vector3 scale;
	}
}