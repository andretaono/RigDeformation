using Erter.CharacterDeformation;
using Erter.Demo;
using UnityEngine;

namespace Erter
{
	public class Boot : MonoBehaviour
	{
		public void Awake()
		{
			var characterDeformationSystem = new CharacterDeformationSystem();

			var assetsFactory = new AssetsFactory(
				characterDeformationSystem.RigBuilder,
				new BoneScalingDefinitionsData().Data);

			assetsFactory.CreateHumanoidCharacterRig();
			assetsFactory.CreateCamera();
		}
	}
}
