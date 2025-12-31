using Andre.RigDeformation.Model;
using System.Collections.Generic;

namespace Andre.RigDeformation.Controller
{
	public interface IRigFactory
	{
		IRig BuildRig(IRootBoneProvider rootBoneProvider, List<string> allKeys);
	}
}
