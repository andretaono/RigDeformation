using Andre.RigDeformation.Model;
using UnityEngine;

namespace Andre.Demo
{
	public class ResourceLoader
	{
		private const string PATH_BONESCALEREGISTRY = "Data/BoneScaleRegistry";
		private const string PATH_BONEKEYDEFINITION = "Data/BoneKeyDefinition";
		private const string PATH_CHARACTER = "Animations/WalkingSkinnedPrefab";

		public BoneScaleRegistry LoadBoneScaleRegistry()
		{
			return Load<BoneScaleRegistry>(PATH_BONESCALEREGISTRY);
		}

		public BoneKeyDefinition LoadBoneKeyDefinition()
		{
			return Load<BoneKeyDefinition>(PATH_BONEKEYDEFINITION);
		}

		public GameObject LoadCharacter()
		{
			return Load<GameObject>(PATH_CHARACTER);
		}

		private T Load<T>(string path) where T : Object
		{
			var resource = Resources.Load<T>(path);

			if (resource == null)
				Debug.LogError($"Resource not found at path: {path} ({typeof(T).Name})");

			return resource;
		}
	}
}
