using System.Collections.Generic;

namespace Andre.RigDeformation.Model
{
	public interface IBoneScaleRegistry
	{
		BoneKeyDefinition BoneKeyDefinition { get; }
		List<BoneScaleProfile> BoneScaleProfiles { get; }
	}
}
