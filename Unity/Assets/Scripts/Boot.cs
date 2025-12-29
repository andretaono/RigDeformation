using Assets.Scripts.CharacterDeformation.Model;
using Erter.CharacterDeformation;
using Erter.Demo;
using UnityEngine;

namespace Erter
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
