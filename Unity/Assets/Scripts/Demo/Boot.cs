using Andre.RigDeformation;
using UnityEngine;

namespace Andre.Demo
{
	public class Boot : MonoBehaviour
	{
		public void Awake()
		{
			var linearScaleInterpolator = new LinearScaleInterpolator();

			var resourceLoader = new ResourceLoader();

			var boneScaleRegistry = resourceLoader.LoadBoneScaleRegistry();

			var boneScaleDefinition = resourceLoader.LoadBoneKeyDefinition();

			var rigDeformationSystem = new RigDeformationSystem(
				linearScaleInterpolator, 
				boneScaleRegistry,
				boneScaleDefinition,
				new RootBoneKeyProvider());

			var assetFactory = new AssetFactory(
				rigDeformationSystem.RigFactory,
				rigDeformationSystem.RigBlender,
				resourceLoader,
				boneScaleRegistry.BoneScaleProfiles.Count);

			assetFactory.CreateCharacter();
			assetFactory.CreateCamera();
			assetFactory.CreateLight();
		}
	}
}
