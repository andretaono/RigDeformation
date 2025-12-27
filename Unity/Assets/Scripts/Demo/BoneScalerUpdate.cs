using Erter.CharacterDeformation;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

namespace Erter.Demo
{
	public class BoneScalerUpdate : MonoBehaviour
	{
		private IRootBoneProvider rootBoneProvider;
		private IRigBuilder rigBuilder;
		private List<IBoneScalingDefinition> boneScalingDefinitions;

		private float transitionDuration = 2f;
		private float holdDuration = 2f;
		private float timer;
		private int currentIndex = 0;

		// ---

		public Transform rootBone;

		private IBone rig;

		public void Init(
			IRootBoneProvider rootBoneProvider,
			IRigBuilder rigBuilder,
			List<IBoneScalingDefinition> boneScalingDefinitions)
		{
			this.rootBoneProvider = rootBoneProvider;
			this.rigBuilder = rigBuilder;
			this.boneScalingDefinitions = boneScalingDefinitions;

			// Build composite tree containing only the bones you care about
			// TODO: Store this data in a better way
			List<string> boneKeys = new List<string>
			{
					"Hips",
					"LeftUpLeg",
					"LeftLeg",
					"LeftFoot",
					"RightUpLeg",
					"RightLeg",
					"RightFoot",
					"Spine",
					"Spine1",
					"Spine2",
					"LeftShoulder",
					"LeftArm",
					"LeftForeArm",
					"LeftHand",
					"Neck",
					"Head",
					"RightShoulder",
					"RightArm",
					"RightForeArm",
					"RightHand"
			};


			rig = rigBuilder.BuildRig(rootBoneProvider, boneKeys);
		}

		private void Update()
		{
			if (boneScalingDefinitions == null || rig == null)
				return;

			IBoneScalingDefinition currentDefinition = GetDefinitionFromBlend();
			rig.ApplyScale(currentDefinition);
		}

		private IBoneScalingDefinition GetDefinitionFromBlend()
		{
			timer += Time.deltaTime;

			float totalSegmentTime = transitionDuration + holdDuration;
			float segmentTime = timer % totalSegmentTime;

			currentIndex = (int)(timer / totalSegmentTime) % boneScalingDefinitions.Count;
			int nextIndex = (currentIndex + 1) % boneScalingDefinitions.Count;

			IBoneScalingDefinition start = boneScalingDefinitions[currentIndex];
			IBoneScalingDefinition end = boneScalingDefinitions[nextIndex];

			float t = Mathf.Clamp01(segmentTime / transitionDuration);

			IBoneScalingDefinition current = LerpScaling(start, end, t);

			return current;
		}

		private IBoneScalingDefinition LerpScaling(IBoneScalingDefinition start, IBoneScalingDefinition end, float t)
		{
			var blended = new BoneScalingDefinition();

			foreach (var bone in start.ScalingValues.Keys)
			{
				if (end.ScalingValues.TryGetValue(bone, out Vector3 endScale))
				{
					Vector3 blendedScale = Vector3.Lerp(start.ScalingValues[bone], endScale, t);
					blended.ScalingValues.Add(bone, blendedScale);
				}
			}

			return blended;
		}
	}
}
