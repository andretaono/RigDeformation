using Erter.CharacterDeformation;
using System.Collections.Generic;

namespace Assets.Scripts.CharacterDeformation.Model
{
	public class Rig : IRig
	{
		public List<IBone> Bones { get; }

		public Rig() {
			Bones = new List<IBone>();
			// TODO: Cache in dict for faster lookups
			//_bonesByKey = Bones.ToDictionary(b => b.Key);
		}

		public IBone GetBone(string key) {
			return Bones.Find(b => b.Key == key);
		}
	}
}
