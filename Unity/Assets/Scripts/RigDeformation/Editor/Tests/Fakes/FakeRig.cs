using Andre.RigDeformation.Model;
using System.Collections.Generic;

namespace Andre.RigDeformation.Editor.Tests
{
	class FakeRig : IRig
	{
		private readonly Dictionary<string, IBone> _bones = new();

		public List<IBone> Bones => throw new System.NotImplementedException();

		public void AddBone(IBone bone)
		{
			_bones[bone.Key] = bone;
		}

		public IBone GetBone(string key)
		{
			return _bones[key];
		}
	}
}
