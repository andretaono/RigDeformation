using Erter.CharacterDeformation;
using NUnit.Framework;
using System.Collections.Generic;

namespace Assets.Scripts.CharacterDeformation.Model
{
	public interface IRig
	{
		List<IBone> Bones { get; } // TODO: Encapsulate this in Add function
		IBone GetBone(string key);
	}
}
