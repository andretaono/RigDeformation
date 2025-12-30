#if UNITY_EDITOR
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

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
		if (profile == null || profile.boneKeys == null)
		{
			Debug.LogError($"{profile.name}: Missing assignment.");
			return;
		}

		var definitionKeys = profile.boneKeys.boneKeys;
		var profileKeys = new HashSet<string>();

		foreach (var entry in profile.scales)
		{
			profileKeys.Add(entry.boneKey);
		}

		// Must have the same number of entries...

		if (profile.scales.Count != definitionKeys.Count)
		{
			Debug.LogError(
				$"{profile.name}: Entry count ({profile.scales.Count}) " +
				$"does not match required count ({definitionKeys.Count}).");
			return;
		}

		// ... and all entries must have an id matching the reference...

		foreach (var entry in profile.scales)
		{
			if (!definitionKeys.Contains(entry.boneKey))
			{
				Debug.LogError(
					$"{profile.name}: Invalid key '{entry.boneKey}'.");
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
#endif
