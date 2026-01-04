using Andre.RigDeformation;
using UnityEngine;

namespace Andre.Demo
{

	/// <summary>
	/// Composition root and entry point for the demo scene.
	/// Sets up the rig deformation system, loads resources, handles DI 
	/// and instantiates key demo objects (character, camera, light).
	/// </summary>
	/// <remarks>
	/// This MonoBehaviour is intended to be attached to a single GameObject
	/// in the scene. It wires together the system and demo domains.
	/// </remarks>
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
