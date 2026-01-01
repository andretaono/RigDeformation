using Andre.RigDeformation.Model;

namespace Andre.RigDeformation.Controller
{
	public interface IRigFactory
	{
		Rig CreateRig(IRootBoneProvider rootBoneProvider, BoneKeyDefinition boneKeyDefinition);
	}
}
