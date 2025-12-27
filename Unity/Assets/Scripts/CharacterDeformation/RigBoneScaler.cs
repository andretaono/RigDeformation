using UnityEngine;

namespace Erter.CharacterDeformation
{
	public class RigBoneScaler : IRigBoneScaler
	{

		public void SetScale(IRootBoneProvider rootBoneProvider, IBoneScalingDefinition scalingDefinition)
		{
			// TODO: Optimize - cache lookup?
			foreach (var keyValuePair in scalingDefinition.ScalingValues)
			{
				TraverseBoneHierarchy(rootBoneProvider.RootBone, keyValuePair.Key, keyValuePair.Value);
			}
		}

		private void TraverseBoneHierarchy(Transform bone, string key, Vector3 value)
		{
			foreach (Transform child in bone)
			{
				if (child.name.EndsWith(key))
				{
					child.localScale = value;
					break;
				}

				TraverseBoneHierarchy(child, key, value);
			}
		}
	}
}
