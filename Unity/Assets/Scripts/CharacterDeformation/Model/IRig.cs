using Erter.CharacterDeformation;
using NUnit.Framework;
using System.Collections.Generic;

namespace Assets.Scripts.CharacterDeformation.Model
{
	public interface IRig
	{
		void AddBone(IBone bone);
		IBone GetBone(string key);

	}
}
