using Andre.RigDeformation.Model;
using System.Collections.Generic;
using UnityEngine;

namespace Andre.RigDeformation.Controller
{
	public interface IRigBlender
	{
		void BlendProfiles(Rig rig,
			IReadOnlyDictionary<string, Vector3> startScales,
			IReadOnlyDictionary<string, Vector3> endScales,
			float t);
	}
}
