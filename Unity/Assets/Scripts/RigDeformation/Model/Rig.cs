using System.Collections.Generic;

namespace Andre.RigDeformation.Model
{
	public class Rig : IRig
	{
		private readonly List<IBone> _bones = new();
		private Dictionary<string, IBone> _bonesByKey;

		public Rig()
		{
			_bonesByKey = new Dictionary<string, IBone>();
		}

		public void AddBone(IBone bone)
		{
			_bones.Add(bone);
			// Dictionary for faster per-frame lookups
			_bonesByKey[bone.Key] = bone;
		}

		public IBone GetBone(string key)
		{
			return _bonesByKey[key];
		}
	}
}
