using Assets.Scripts.CharacterDeformation.Model;
using Erter.CharacterDeformation;
using System.Collections.Generic;

class FakeRig : IRig
{
	private readonly Dictionary<string, IBone> _bones = new();

	public List<IBone> Bones => throw new System.NotImplementedException();

	public void AddBone(string key, IBone bone)
	{
		_bones[key] = bone;
	}

	public IBone GetBone(string key)
	{
		return _bones[key];
	}
}
