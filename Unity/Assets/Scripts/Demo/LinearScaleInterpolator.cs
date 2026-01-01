using Andre.RigDeformation.Controller;
using UnityEngine;

namespace Andre.Demo
{
	public sealed class LinearScaleInterpolator : IScaleInterpolator
	{
		public Vector3 Interpolate(Vector3 start, Vector3 end, float t)
		{
			return Vector3.Lerp(start, end, t);
		}
	}
}
