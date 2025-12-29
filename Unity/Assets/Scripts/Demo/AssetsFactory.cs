using Assets.Scripts.CharacterDeformation.Controller;
using Assets.Scripts.CharacterDeformation.Model;
using Erter.CharacterDeformation;
using System.Collections.Generic;
using UnityEngine;

namespace Erter.Demo
{
	public class AssetsFactory
	{
		private IRigFactory rigFactory;
		private IBoneScaleRegistry boneScaleRegistry;
		private IRigBlender rigBlender;

		public AssetsFactory(
			IRigFactory rigFactory,
			IBoneScaleRegistry boneScaleRegistry,
			IRigBlender rigBlender)
		{
			this.rigFactory = rigFactory;
			this.boneScaleRegistry = boneScaleRegistry;
			this.rigBlender = rigBlender;
		}

		public void CreateHumanoidCharacterRig()
		{
			// TODO: Add string constants class
			GameObject humanoidCharacterRigResource = Resources.Load<GameObject>("Animations/WalkingSkinnedPrefab");
			var humanoidCharacterRig = GameObject.Instantiate(humanoidCharacterRigResource);
			humanoidCharacterRig.AddComponent<BoneScalerUpdate>();
			var boneScalerUpdate = humanoidCharacterRig.AddComponent<BoneScalerUpdate>();
			var rootBoneProvider = humanoidCharacterRig.AddComponent<RootBoneProvider>();
			var rig = rigFactory.BuildRig(rootBoneProvider, boneScaleRegistry.BoneKeyDefinition.boneKeys);
			boneScalerUpdate.Init(boneScaleRegistry, rig, rigBlender);
		}

		public void CreateCamera()
		{
			GameObject cameraObject = new GameObject("Camera");
			var cameraController = cameraObject.AddComponent<CameraController>();
			cameraObject.AddComponent<Camera>();
		}
	}
}
