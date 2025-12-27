using System.Collections.Generic;
using UnityEngine;

namespace Erter.CharacterDeformation
{
	public interface IRigBuilder
	{
		IBone BuildRig(IRootBoneProvider rootBoneProvider, List<string> allKeys);
	}
}
