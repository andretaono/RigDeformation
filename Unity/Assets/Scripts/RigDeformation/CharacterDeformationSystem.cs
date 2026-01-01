using Andre.RigDeformation.Controller;
using Andre.RigDeformation.Model;

namespace Andre.RigDeformation
{
	public class CharacterDeformationSystem
	{
		public IRigFactory RigFactory { get; private set; }
		public IRigBlender RigBlender { get; private set; }
		public BoneScaleRegistry BoneScaleRegistry { get; private set; }

		public CharacterDeformationSystem(
			IScaleInterpolator scaleInterpolator, 
			BoneScaleRegistry boneScaleRegistry) 
		{
			RigFactory = new RigFactory();
			RigBlender = new RigBlender(scaleInterpolator);
			BoneScaleRegistry = boneScaleRegistry;
		}
	}
}
