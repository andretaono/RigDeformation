#if UNITY_EDITOR
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[InitializeOnLoad]
public static class BoneKeyDefinitionValidator
{
	static BoneKeyDefinitionValidator()
	{
		EditorApplication.delayCall += ValidateAll;
	}

	private static void ValidateAll()
	{
		var guids = AssetDatabase.FindAssets("t:BoneKeyDefinition");

		foreach (var guid in guids)
		{
			var path = AssetDatabase.GUIDToAssetPath(guid);
			var definition = AssetDatabase.LoadAssetAtPath<BoneKeyDefinition>(path);
			Validate(definition);
		}
	}

	public static void Validate(BoneKeyDefinition definition)
	{
		if (definition == null)
			return;

		if (definition.boneKeys == null || definition.boneKeys.Count == 0)
		{
			Debug.LogError($"{definition.name}: List is null or empty.", definition);
			return;
		}

		var seenKeys = new HashSet<string>();

		for (int i = 0; i < definition.boneKeys.Count; i++)
		{
			var key = definition.boneKeys[i];

			// Empty / whitespace
			if (string.IsNullOrWhiteSpace(key))
			{
				Debug.LogError(
					$"{definition.name}: Index {i} is null, empty, or whitespace.",
					definition);
				continue;
			}

			// Duplicate
			if (!seenKeys.Add(key))
			{
				Debug.LogError(
					$"{definition.name}: Duplicate entry '{key}'.",
					definition);
			}
		}
	}
}
#endif
