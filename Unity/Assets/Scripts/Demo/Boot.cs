using Andre.RigDeformation;
using Andre.RigDeformation.Model;
using UnityEngine;

namespace Andre.Demo
{
	public class Boot : MonoBehaviour
	{
		public void Awake()
		{
			var boneScaleRegistry = Resources.Load("BoneScaleRegistry") as IBoneScaleRegistry;

			var characterDeformationSystem = new CharacterDeformationSystem(boneScaleRegistry);

			var assetsFactory = new AssetsFactory(
				characterDeformationSystem.RigFactory,
				boneScaleRegistry,
				characterDeformationSystem.RigBlender);

			assetsFactory.CreateHumanoidCharacterRig();
			assetsFactory.CreateCamera();
		}
	}
}
