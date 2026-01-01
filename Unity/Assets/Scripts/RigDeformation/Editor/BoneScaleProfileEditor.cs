#if UNITY_EDITOR
using Andre.RigDeformation.Model;
using UnityEditor;
using UnityEngine;

namespace Andre.RigDeformation.Editor
{

	[CustomEditor(typeof(BoneScaleProfile))]
	public class BoneScaleProfileEditor : UnityEditor.Editor
	{
		public override void OnInspectorGUI()
		{
			DrawDefaultInspector();

			var profile = (BoneScaleProfile)target;

			if (profile.BoneKeyDefinition.BoneKeys != null &&
				GUILayout.Button("Sync From Bone Keys"))
			{
				profile.BoneScaleEntriesEditor.Clear();

				foreach (var key in profile.BoneKeyDefinitionEditor.BoneKeys)
				{
					profile.BoneScaleEntriesEditor.Add(new BoneScaleEntry
					{
						boneKey = key,
						scale = Vector3.one
					});
				}

				EditorUtility.SetDirty(profile);
			}
		}
	}
}
#endif
