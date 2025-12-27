using System.Collections.Generic;
using UnityEngine;

namespace Erter.CharacterDeformation
{
	public class BoneScalingDefinition : IBoneScalingDefinition
	{
		public Dictionary<string, Vector3> ScalingValues { get; private set; }

		public BoneScalingDefinition(Dictionary<string, Vector3> scalingValues = null)
		{
			scalingValues ??= new Dictionary<string, Vector3>();
			ScalingValues = scalingValues;
		}
	}
}
