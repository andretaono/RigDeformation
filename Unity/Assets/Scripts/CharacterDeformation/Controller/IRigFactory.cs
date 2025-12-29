using Assets.Scripts.CharacterDeformation.Model;
using System.Collections.Generic;
using UnityEngine;

namespace Erter.CharacterDeformation
{
	public interface IRigFactory
	{
		IRig BuildRig(IRootBoneProvider rootBoneProvider, List<string> allKeys);
	}
}
