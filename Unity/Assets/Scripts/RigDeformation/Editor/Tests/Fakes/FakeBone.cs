using Andre.RigDeformation.Model;
using UnityEngine;

namespace Andre.RigDeformation.Editor.Tests
{
	class FakeBone : IBone
	{
		public Vector3 LastAppliedScale { get; private set; }

		public string Key => throw new System.NotImplementedException();

		public void SetScale(Vector3 scale)
		{
			LastAppliedScale = scale;
		}
	}
}
