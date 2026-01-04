using Andre.RigDeformation.Controller;
using UnityEngine;

namespace Andre.Demo
{
	public class AssetFactory
	{
		private IRigFactory rigFactory;
		private IRigBlender rigBlender;
		private ResourceLoader resourceLoader;
		private int boneScaleProfilesCount;

		public AssetFactory(
			IRigFactory rigFactory,
			IRigBlender rigBlender,
			ResourceLoader resourceLoader,
			int boneScaleProfilesCount)
		{
			this.rigFactory = rigFactory;
			this.rigBlender = rigBlender;
			this.resourceLoader = resourceLoader;
			this.boneScaleProfilesCount = boneScaleProfilesCount;
		}

		public void CreateCharacter()
		{
			var characterResource = resourceLoader.LoadCharacter();
			var characterGameObject = GameObject.Instantiate(characterResource);
			var boneScalerUpdate = characterGameObject.AddComponent<BoneScalerUpdate>();
			var rig = rigFactory.CreateRig(characterGameObject.transform);
			var boneScaleRegistry = resourceLoader.LoadBoneScaleRegistry();
			boneScalerUpdate.Init(rig, rigBlender, boneScaleProfilesCount);
		}

		public void CreateCamera()
		{
			var cameraObject = new GameObject("Camera");
			cameraObject.AddComponent<CameraController>();
			var camera = cameraObject.AddComponent<Camera>();
			camera.backgroundColor = Color.black;
		}

		public void CreateLight()
		{
			var lightObject = new GameObject("Point Light");
			lightObject.transform.position = new Vector3(0, 10, 0);
			var light = lightObject.AddComponent<Light>();
			light.range = 50;
		}
	}
}
