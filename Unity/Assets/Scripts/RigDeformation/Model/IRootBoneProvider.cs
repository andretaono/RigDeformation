using UnityEngine;

namespace Andre.RigDeformation.Model
{
	public interface IRootBoneProvider
	{
		Transform RootBone { get; }
	}
}
