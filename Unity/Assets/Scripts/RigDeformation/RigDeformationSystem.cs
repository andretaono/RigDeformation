using Andre.RigDeformation.Controller;
using Andre.RigDeformation.Model;

namespace Andre.RigDeformation
{
	public class RigDeformationSystem
	{
		public IRigFactory RigFactory { get; private set; }
		public IRigBlender RigBlender { get; private set; }

		public RigDeformationSystem(
			IScaleInterpolator scaleInterpolator, 
			BoneScaleRegistry boneScaleRegistry,
			BoneKeyDefinition boneKeyDefinition,
			IRootBoneKeyProvider rootBoneKeyProvider) 
		{
			RigFactory = new RigFactory(boneKeyDefinition, new RootBoneFinder(rootBoneKeyProvider));
			RigBlender = new RigBlender(scaleInterpolator, boneScaleRegistry);
		}
	}
}
