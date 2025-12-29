using Assets.Scripts.CharacterDeformation.Model;
using Erter.CharacterDeformation;

namespace Assets.Scripts.CharacterDeformation.Controller
{
	public interface IRigBlender
	{
		void BlendProfiles(IRig rig, IBoneScaleProfile start, IBoneScaleProfile end, float t);
	}
}
