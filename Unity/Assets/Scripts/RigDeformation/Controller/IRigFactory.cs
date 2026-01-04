using Andre.RigDeformation.Model;
using UnityEngine;

namespace Andre.RigDeformation.Controller
{
	public interface IRigFactory
	{
		Rig CreateRig(Transform transform);
	}
}
