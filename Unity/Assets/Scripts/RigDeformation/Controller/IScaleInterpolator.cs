using UnityEngine;

namespace Andre.RigDeformation.Controller
{
	public interface IScaleInterpolator
	{
		Vector3 Interpolate(Vector3 start, Vector3 end, float t);
	}
}
