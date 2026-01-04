using Andre.RigDeformation.Controller;
using Andre.RigDeformation.Model;
using UnityEngine;

namespace Andre.Demo
{
	public class BoneScalerUpdate : MonoBehaviour
	{
		private const float TRANSITION_DURATION = 2f;
		private const float HOLD_DURATION = 2f;

		private Rig rig;
		private IRigBlender rigBlender;
		private float totalSegmentTime;
		private float timer;
		private int boneScaleProfilesCount;

		public void Init(
			Rig rig,
			IRigBlender rigBlender,
			int boneScaleProfilesCount)
		{
			this.rig = rig;
			this.rigBlender = rigBlender;
			this.boneScaleProfilesCount = boneScaleProfilesCount;

			totalSegmentTime = GetTotalSegmentTime();
		}

		private void Update()
		{
			if (!IsFlowAllowedToProceed())
				return;

			UpdateBlending();
		}

		private bool IsFlowAllowedToProceed()
		{
			if (rig == null)
				return false;

			return true;
		}

		private void UpdateBlending()
		{
			UpdateTimer();

			var segmentTime = GetSegmentTime();
			var currentIndex = GetCurrentIndex(totalSegmentTime);
			var nextIndex = GetNextIndex(currentIndex);

			DoBlend(segmentTime, currentIndex, nextIndex);
		}

		private float GetTotalSegmentTime()
		{
			return TRANSITION_DURATION + HOLD_DURATION;
		}

		private float GetSegmentTime()
		{
			return timer % totalSegmentTime;
		}

		private void UpdateTimer()
		{
			timer += Time.deltaTime;
		}

		private int GetCurrentIndex(float totalSegmentTime)
		{
			return (int)(timer / totalSegmentTime) % boneScaleProfilesCount;
		}

		private int GetNextIndex(int currentIndex)
		{
			return (currentIndex + 1) % boneScaleProfilesCount;
		}
		private float GetTime(float segmentTime)
		{
			return Mathf.Clamp01(segmentTime / TRANSITION_DURATION);
		}

		private void DoBlend(float segmentTime, int startIndex, int endIndex)
		{
			var t = GetTime(segmentTime);
			rigBlender.BlendProfiles(rig, startIndex, endIndex, t);
		}
	}
}
