using Assets.Scripts.CharacterDeformation.Model;
using UnityEngine;

namespace Erter.CharacterDeformation
{
	public class Bone : IBone
	{
		private readonly string key;
		private readonly Transform boneTransform;

		public string Key { get { return key; } }

		public Bone(string key, Transform boneTransform)
		{
			this.key = key;
			this.boneTransform = boneTransform;
		}

		public void SetScale(Vector3 scale)
		{
			boneTransform.localScale = scale;
		}
	}
}
