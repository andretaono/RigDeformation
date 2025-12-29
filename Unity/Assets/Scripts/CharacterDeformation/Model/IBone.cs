using UnityEngine;

namespace Erter.CharacterDeformation
{
	public interface IBone
	{
		string Key { get; }
		void SetScale(Vector3 scale);
	}
}
