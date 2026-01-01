using Andre.RigDeformation.Controller;
using Andre.RigDeformation.Model;
using UnityEngine;

namespace Andre.Demo
{
	public class AssetsFactory
	{
		private IRigFactory rigFactory;
		private BoneKeyDefinition boneKeyDefinition;
		private BoneScaleRegistry boneScaleRegistry;
		private IRigBlender rigBlender;

		public AssetsFactory(
			IRigFactory rigFactory,
			BoneKeyDefinition boneKeyDefinition,
			BoneScaleRegistry boneScaleRegistry,
			IRigBlender rigBlender)
		{
			this.rigFactory = rigFactory;
			this.boneKeyDefinition = boneKeyDefinition;
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
			var rig = rigFactory.CreateRig(rootBoneProvider, boneKeyDefinition);
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
