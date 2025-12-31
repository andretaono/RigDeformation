using System.Collections.Generic;
using UnityEngine;

namespace Andre.RigDeformation.Model
{
	public interface IBoneScaleProfile
	{
		Vector3 GetScale(string boneKey);
		void SetScale(string boneKey, Vector3 scale);
		List<BoneScaleEntry> ScaleEntries { get; }
	}
}
