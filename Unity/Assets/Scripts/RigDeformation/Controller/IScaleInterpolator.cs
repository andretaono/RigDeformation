using UnityEngine;

namespace Andre.RigDeformation.Controller
{

	/// <summary>
	/// Defines a strategy for interpolating between two scale values.
	/// </summary>
	/// <remarks>
	/// This abstraction separates interpolation math from rig traversal logic,
	/// allowing different interpolation behaviors (e.g. linear, eased, custom)
	/// to be injected into the deformation system.
	/// </remarks>
	public interface IScaleInterpolator
	{
		Vector3 Interpolate(Vector3 start, Vector3 end, float t);
	}
}
