using UnityEngine;

namespace Erter.CharacterDeformation
{
	public class Bone : IBone
	{
		private readonly Transform boneTransform;
		private readonly string key;

		public Bone(Transform boneTransform, string key)
		{
			this.boneTransform = boneTransform;
			this.key = key;
		}

		public void ApplyScale(IBoneScalingDefinition scalingDefinition)
		{
			if (scalingDefinition.ScalingValues.TryGetValue(key, out var scale))
			{
				boneTransform.localScale = scale;
			}
		}
	}
}
