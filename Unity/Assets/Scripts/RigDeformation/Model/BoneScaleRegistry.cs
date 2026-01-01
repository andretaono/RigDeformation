using System.Collections.Generic;
using UnityEngine;

namespace Andre.RigDeformation.Model
{

	[CreateAssetMenu(menuName = "Andre/Rig Deformation/Bone Scale Registry")]
	public class BoneScaleRegistry : ScriptableObject
	{
		[SerializeField]
		private List<BoneScaleProfile> boneScaleProfiles;

		public IReadOnlyList<BoneScaleProfile> BoneScaleProfiles => boneScaleProfiles;
	}
}