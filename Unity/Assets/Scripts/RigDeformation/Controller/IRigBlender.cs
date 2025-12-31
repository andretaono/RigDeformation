using Andre.RigDeformation.Model;

namespace Andre.RigDeformation.Controller
{
	public interface IRigBlender
	{
		void BlendProfiles(IRig rig, IBoneScaleProfile start, IBoneScaleProfile end, float t);
	}
}
