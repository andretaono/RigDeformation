using UnityEngine;
using UnityEditor;

namespace Andre.Demo
{
	public class StripScaleOnImport : AssetPostprocessor
	{
		void OnPostprocessAnimation(GameObject root, AnimationClip clip)
		{
			var bindings = AnimationUtility.GetCurveBindings(clip);
			foreach (var b in bindings)
			{
				if (b.propertyName.Contains("Scale"))
					AnimationUtility.SetEditorCurve(clip, b, null);
			}
		}
	}
}