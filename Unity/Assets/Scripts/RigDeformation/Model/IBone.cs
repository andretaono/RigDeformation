using UnityEngine;

namespace Andre.RigDeformation.Model
{
	public interface IBone
	{
		string Key { get; }
		void SetScale(Vector3 scale);
	}
}
