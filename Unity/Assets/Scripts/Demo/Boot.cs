using Andre.RigDeformation;
using Andre.RigDeformation.Model;
using UnityEngine;

namespace Andre.Demo
{
	public class Boot : MonoBehaviour
	{
		public void Awake()
		{
			var boneScaleRegistry = Resources.Load("Data/BoneScaleRegistry") as BoneScaleRegistry;

			var linearScaleInterpolator = new LinearScaleInterpolator();

			var characterDeformationSystem = new CharacterDeformationSystem(
				linearScaleInterpolator, 
				boneScaleRegistry);

			// TODO: Make Resources loader class
			var boneKeyDefinition = Resources.Load("Data/BoneKeyDefinition") as BoneKeyDefinition;

			var assetsFactory = new AssetsFactory(
				characterDeformationSystem.RigFactory,
				boneKeyDefinition,
				boneScaleRegistry,
				characterDeformationSystem.RigBlender);

			assetsFactory.CreateHumanoidCharacterRig();
			assetsFactory.CreateCamera();
		}
	}
}
