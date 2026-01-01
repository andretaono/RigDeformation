using System.Collections.Generic;
using UnityEngine;

namespace Andre.RigDeformation.Model
{
	public class Rig
	{
		private Dictionary<string, Transform> bones;

		public Rig()
		{
			bones = new Dictionary<string, Transform>();
		}

		public void AddBone(string key, Transform transform)
		{
			// Dictionary for faster per-frame lookups
			bones[key] = transform;
		}

		public Transform GetBone(string key)
		{
			return bones[key];
		}
	}
}
