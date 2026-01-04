using Andre.RigDeformation.Model;
using System.Linq;
using UnityEngine;

namespace Andre.RigDeformation.Controller
{

	/// <summary>
	/// Locates the root bone transform within a hierarchy based on a configured key.
	/// </summary>
	/// <remarks>
	/// The root bone key is provided externally to avoid hard-coded naming
	/// assumptions and to support different skeleton conventions.
	/// </remarks>
	public class RootBoneFinder
	{
		private IRootBoneKeyProvider rootBoneKeyProvider;

		public RootBoneFinder(IRootBoneKeyProvider rootBoneKeyProvider)
		{
			this.rootBoneKeyProvider = rootBoneKeyProvider;
		}

		public Transform TryFindRootBone(Transform transform)
		{
			var rootBone = transform
				.GetComponentsInChildren<Transform>(true)
				.FirstOrDefault(t => t.name == rootBoneKeyProvider.RootBoneKey);

			if (rootBone == null)
			{
				Debug.LogError(
					$"{rootBoneKeyProvider.RootBoneKey} not found in {transform.name}.");
			}

			return rootBone;
		}
	}
}
