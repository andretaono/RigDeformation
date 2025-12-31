using Andre.RigDeformation.Controller;
using Andre.RigDeformation.Model;
using UnityEngine;

namespace Andre.Demo
{
	public class BoneScalerUpdate : MonoBehaviour
	{
		private IBoneScaleRegistry boneScaleRegistry;
		private IRigBlender rigBlender;

		private float transitionDuration = 2f;
		private float holdDuration = 2f;
		private float timer;
		private int currentIndex = 0;

		// ---

		public Transform rootBone;

		private IRig rig;

		public void Init(
			IBoneScaleRegistry boneScaleRegistry,
			IRig rig,
			IRigBlender rigBlender)
		{
			this.boneScaleRegistry = boneScaleRegistry;
			this.rig = rig;
			this.rigBlender = rigBlender;
		}

		private void Update()
		{
			if (boneScaleRegistry == null || rig == null)
				return;

			BlendProfiles();
		}

		private void BlendProfiles()
		{
			timer += Time.deltaTime;

			float totalSegmentTime = transitionDuration + holdDuration;
			float segmentTime = timer % totalSegmentTime;

			currentIndex = (int)(timer / totalSegmentTime) % boneScaleRegistry.BoneScaleProfiles.Count;
			int nextIndex = (currentIndex + 1) % boneScaleRegistry.BoneScaleProfiles.Count;

			IBoneScaleProfile start = boneScaleRegistry.BoneScaleProfiles[currentIndex];
			IBoneScaleProfile end = boneScaleRegistry.BoneScaleProfiles[nextIndex];

			float t = Mathf.Clamp01(segmentTime / transitionDuration);

			rigBlender.BlendProfiles(rig, start, end, t);
		}
	}
}
