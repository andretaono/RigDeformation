using System.Collections.Generic;

namespace Erter.CharacterDeformation
{
	public class BoneComposite : IBone
	{

		private readonly List<IBone> children = new();

		public void Add(IBone bone)
		{
			children.Add(bone);
		}

		public void ApplyScale(IBoneScalingDefinition scalingDefinition)
		{
			foreach (var child in children)
			{
				child.ApplyScale(scalingDefinition);
			}
		}
	}
}
