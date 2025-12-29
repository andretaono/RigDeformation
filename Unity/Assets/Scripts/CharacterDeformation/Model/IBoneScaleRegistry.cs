using System.Collections.Generic;

namespace Assets.Scripts.CharacterDeformation.Model
{
	public interface IBoneScaleRegistry
	{
		BoneKeyDefinition BoneKeyDefinition { get; }
		List<BoneScaleProfile> BoneScaleProfiles { get; }
	}
}
