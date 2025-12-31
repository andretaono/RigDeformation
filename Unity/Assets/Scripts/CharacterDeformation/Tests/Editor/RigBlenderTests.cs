using Assets.Scripts.CharacterDeformation.Controller;
using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;
public class RigBlenderTests
{
	[Test]
	public void BlendProfiles_LerpsScaleAndAppliesItToBone()
	{
		// ---------- ARRANGE ----------

		var rig = new FakeRig();
		var bone = new FakeBone();
		const string boneKey = "Spine";

		rig.AddBone(bone);

		var startScale = new Vector3(1f, 1f, 1f);
		var endScale = new Vector3(2f, 2f, 2f);
		float t = 0.5f;

		var startProfile = new FakeBoneScaleProfile(new Dictionary<string, Vector3>
		{
			{ boneKey, startScale }
		});

		var endProfile = new FakeBoneScaleProfile(new Dictionary<string, Vector3>
		{
			{ boneKey, endScale }
		});

		var blender = new RigBlender();
		var expected = Vector3.Lerp(startScale, endScale, t);

		// ---------- ACT ----------

		blender.BlendProfiles(rig, startProfile, endProfile, t);

		// ---------- ASSERT ----------

		Assert.AreEqual(expected, bone.LastAppliedScale);
	}
}
