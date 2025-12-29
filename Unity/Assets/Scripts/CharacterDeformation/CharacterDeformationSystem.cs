using Assets.Scripts.CharacterDeformation.Controller;
using Assets.Scripts.CharacterDeformation.Model;

namespace Erter.CharacterDeformation
{
	public class CharacterDeformationSystem
	{
		public IRigFactory RigFactory { get; private set; }
		public IRigBlender RigBlender { get; private set; }
		public IBoneScaleRegistry BoneScaleRegistry { get; private set; }

		public CharacterDeformationSystem(IBoneScaleRegistry boneScaleRegistry) {
			RigFactory = new RigFactory();
			RigBlender = new RigBlender();
			BoneScaleRegistry = boneScaleRegistry;
		}
	}
}
