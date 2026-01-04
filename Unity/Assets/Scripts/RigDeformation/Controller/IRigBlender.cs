using Andre.RigDeformation.Model;
namespace Andre.RigDeformation.Controller
{
	public interface IRigBlender
	{
		void BlendProfiles(Rig rig, int startIndex, int endIndex, float t);
	}
}
