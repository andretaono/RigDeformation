using System.Collections.Generic;
using UnityEngine;

namespace Andre.RigDeformation.Model
{

	[CreateAssetMenu(menuName = "Andre/Rig Deformation/Bone Scale Profile")]
	public class BoneScaleProfile : ScriptableObject
	{
		[SerializeField]
		private BoneKeyDefinition boneKeyDefinition;

		[SerializeField]
		private List<BoneScaleEntry> boneScaleEntries = new List<BoneScaleEntry>();

		public IReadOnlyDictionary<string, Vector3> BoneScaleEntries => scaleLookup;
		public BoneKeyDefinition BoneKeyDefinition => boneKeyDefinition;

		private Dictionary<string, Vector3> scaleLookup;

		private void OnEnable()
		{
			BuildLookup();
		}

		// Generate lookup dictionary for faster per-frame lookups
		private void BuildLookup()
		{
			scaleLookup = new Dictionary<string, Vector3>(boneScaleEntries.Count);

			foreach (var entry in boneScaleEntries)
			{
				scaleLookup[entry.boneKey] = entry.scale;
			}
		}

#if UNITY_EDITOR
		public List<BoneScaleEntry> BoneScaleEntriesEditor => boneScaleEntries;
		public BoneKeyDefinition BoneKeyDefinitionEditor => boneKeyDefinition;
#endif

	}
}