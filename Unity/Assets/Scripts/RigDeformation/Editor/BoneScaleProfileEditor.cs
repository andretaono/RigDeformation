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

				foreach (var key in profile.BoneKeyDefinition.BoneKeys)
				{
					var boneScaleEntry = new BoneScaleEntry(key, Vector3.one);
					profile.BoneScaleEntriesEditor.Add(boneScaleEntry);
				}

				EditorUtility.SetDirty(profile);
			}
		}
	}
}
#endif
