using Assets.Scripts.CharacterDeformation.Model;

namespace Erter.CharacterDeformation
{
	public interface IRigBoneScaler
	{
		void SetScale(IRootBoneProvider rootBoneProvider, IBoneScaleProfile boneScaleProfile);
	}
}
