using System;
using UnityEngine;

namespace Andre.RigDeformation.Model
{
	[Serializable]
	public class BoneScaleEntry
	{
		[SerializeField]
		private string boneKey;

		[SerializeField]
		private Vector3 scale;

		public string BoneKey => boneKey;
		public Vector3 Scale => scale;

		public BoneScaleEntry(string boneKey, Vector3 scale)
		{
			this.boneKey = boneKey;
			this.scale = scale;
		}
	}
}