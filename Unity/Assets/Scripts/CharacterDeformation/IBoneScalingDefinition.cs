using System.Collections.Generic;
using UnityEngine;

namespace Erter.CharacterDeformation
{
	public interface IBoneScalingDefinition
	{
		Dictionary<string, Vector3> ScalingValues { get; }
	}
}
