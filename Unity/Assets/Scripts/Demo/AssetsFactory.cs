using Erter.CharacterDeformation;
using System.Collections.Generic;
using UnityEngine;

namespace Erter.Demo
{
	public class AssetsFactory
	{
		private IRigBuilder rigBuilder;
		private List<IBoneScalingDefinition> boneScalingDefinitions;

		public AssetsFactory(
			IRigBuilder rigBuilder,
			List<IBoneScalingDefinition> boneScalingDefinitions)
		{
			this.rigBuilder = rigBuilder;
			this.boneScalingDefinitions = boneScalingDefinitions;
		}

		public void CreateHumanoidCharacterRig()
		{
			// TODO: Add string constants class
			GameObject humanoidCharacterRigResource = Resources.Load<GameObject>("Animations/WalkingSkinnedPrefab");
			var humanoidCharacterRig = GameObject.Instantiate(humanoidCharacterRigResource);
			humanoidCharacterRig.AddComponent<BoneScalerUpdate>();
			var boneScalerUpdate = humanoidCharacterRig.AddComponent<BoneScalerUpdate>();
			var rig = humanoidCharacterRig.AddComponent<RootBoneProvider>();
			boneScalerUpdate.Init(rig, rigBuilder, boneScalingDefinitions);
		}

		public void CreateCamera()
		{
			GameObject cameraObject = new GameObject("Camera");
			var cameraController = cameraObject.AddComponent<CameraController>();
			cameraObject.AddComponent<Camera>();
		}
	}
}
