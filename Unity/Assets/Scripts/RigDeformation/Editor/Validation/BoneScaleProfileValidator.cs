#if UNITY_EDITOR
using Andre.RigDeformation.Model;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;

namespace Andre.RigDeformation.Editor.Validation
{

	[InitializeOnLoad]
	public static class BoneScaleProfileValidator
	{
		static BoneScaleProfileValidator()
		{
			EditorApplication.delayCall += ValidateAll;
		}

		private static void ValidateAll()
		{
			var profiles = AssetDatabase.FindAssets("t:BoneScaleProfile");

			foreach (var guid in profiles)
			{
				var path = AssetDatabase.GUIDToAssetPath(guid);
				var profile = AssetDatabase.LoadAssetAtPath<BoneScaleProfile>(path);
				Validate(profile);
			}
		}

		public static void Validate(BoneScaleProfile profile)
		{
			if (profile == null || profile.BoneKeyDefinition == null)
			{
				Debug.LogError($"{profile.name}: Missing assignment.");
				return;
			}

			var definitionKeys = profile.BoneKeyDefinition.BoneKeys;
			var profileKeys = new HashSet<string>();

			foreach (var entry in profile.BoneScaleEntries)
			{
				profileKeys.Add(entry.Key);
			}

			// Must have the same number of entries...

			if (profile.BoneScaleEntries.Count != definitionKeys.Count)
			{
				Debug.LogError(
					$"{profile.name}: Entry count ({profile.BoneScaleEntries.Count}) " +
					$"does not match required count ({definitionKeys.Count}).");
				return;
			}

			// ... and all entries must have an id matching the reference...

			foreach (var entry in profile.BoneScaleEntries)
			{
				if (!definitionKeys.Any(k => k == entry.Key))
				{
					Debug.LogError(
						$"{profile.name}: Invalid key '{entry.Key}'.");
					return;
				}
			}

			// ... and all keys from the reference must be present.

			foreach (var key in definitionKeys)
			{
				if (!profileKeys.Contains(key))
				{
					Debug.LogError(
						$"{profile.name}: Missing key '{key}'",
						profile);
				}
			}
		}
	}
}
#endif
