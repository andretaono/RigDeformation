using Erter.CharacterDeformation;
using System.Collections.Generic;
using UnityEngine;

namespace Erter.Demo
{
	internal class BoneScalingDefinitionsData
	{
		public List<IBoneScalingDefinition> Data { get; private set; }

		public BoneScalingDefinitionsData()
		{
			var boneScalingDefinitionHuman = new BoneScalingDefinition(
				new Dictionary<string, Vector3>() {
					{ "Hips", new Vector3(1, 1, 1) },
					{ "LeftUpLeg",  new Vector3(1, 1, 1) },
					{ "LeftLeg", new Vector3(1, 1, 1) },
					{ "LeftFoot", new Vector3(1, 1, 1) },
					{ "RightUpLeg",  new Vector3(1, 1, 1) },
					{ "RightLeg", new Vector3(1, 1, 1) },
					{ "RightFoot", new Vector3(1, 1, 1) },
					{ "Spine", new Vector3(1, 1, 1) },
					{ "Spine1", new Vector3(1, 1, 1) },
					{ "Spine2", new Vector3(1, 1, 1) },
					{ "LeftShoulder", new Vector3(1, 1, 1) },
					{ "LeftArm", new Vector3(1, 1, 1) },
					{ "LeftForeArm", new Vector3(1, 1, 1) },
					{ "LeftHand", new Vector3(1, 1, 1) },
					{ "Neck", new Vector3(1, 1, 1) },
					{ "Head", new Vector3(1, 1, 1) },
					{ "RightShoulder", new Vector3(1, 1, 1) },
					{ "RightArm", new Vector3(1, 1, 1) },
					{ "RightForeArm", new Vector3(1, 1, 1) },
					{ "RightHand", new Vector3(1, 1, 1) }
			});

			var boneScalingDefinitionSeal = new BoneScalingDefinition(
				new Dictionary<string, Vector3>() {
					{ "Hips", new Vector3(1, 1.2f, 1) },
					{ "LeftUpLeg",  new Vector3(0.5f, 0.5f, 0.5f) },
					{ "LeftLeg", new Vector3(0.5f, 0.5f, 0.5f) },
					{ "LeftFoot", new Vector3(1, 1, 1) },
					{ "RightUpLeg",  new Vector3(0.5f, 0.5f, 0.5f) },
					{ "RightLeg", new Vector3(0.5f, 0.5f, 0.5f) },
					{ "RightFoot", new Vector3(1, 1, 1) },
					{ "Spine", new Vector3(1, 2, 1) },
					{ "Spine1", new Vector3(1, 1, 1) },
					{ "Spine2", new Vector3(1.4f, 1.4f, 2) },
					{ "LeftShoulder", new Vector3(1.4f, 1, 1) },
					{ "LeftArm", new Vector3(1, 0.2f, 0.2f) },
					{ "LeftForeArm", new Vector3(1, 0.5f, 0.5f) },
					{ "LeftHand", new Vector3(1, 0.5f, 0.5f) },
					{ "Neck", new Vector3(0.8f, 0.5f, 0.8f) },
					{ "Head", new Vector3(1.4f, 1, 1) },
					{ "RightShoulder", new Vector3(1.4f, 1, 1) },
					{ "RightArm", new Vector3(1, 0.2f, 0.2f) },
					{ "RightForeArm", new Vector3(1, 0.5f, 0.5f) },
					{ "RightHand", new Vector3(1, 0.5f, 0.5f) },
			});

			var boneScalingDefinitionBird = new BoneScalingDefinition(
				new Dictionary<string, Vector3>() {
					{ "Hips", new Vector3(0.8f, 0.8f, 0.8f) },
					{ "LeftUpLeg",  new Vector3(0.5f, 0.5f, 0.5f) },
					{ "LeftLeg", new Vector3(0.6f, 0.6f, 0.6f) },
					{ "LeftFoot", new Vector3(1, 1, 1) },
					{ "RightUpLeg",  new Vector3(0.5f, 0.5f, 0.5f) },
					{ "RightLeg", new Vector3(0.6f, 0.6f, 0.6f) },
					{ "RightFoot", new Vector3(1, 1, 1) },
					{ "Spine", new Vector3(1, 1, 1) },
					{ "Spine1", new Vector3(1, 1, 1) },
					{ "Spine2", new Vector3(1, 1, 1) },
					{ "LeftShoulder", new Vector3(1.4f, 1.4f, 1.4f) },
					{ "LeftArm", new Vector3(1.5f, 1, 1) },
					{ "LeftForeArm", new Vector3(1.5f, 1, 0.7f) },
					{ "LeftHand", new Vector3(0.5f, 2, 0.7f) },
					{ "Neck", new Vector3(1, 1, 1) },
					{ "Head", new Vector3(1, 1, 1.5f) },
					{ "RightShoulder", new Vector3(1.4f, 1.4f, 1.4f) },
					{ "RightArm", new Vector3(1.5f, 1, 1) },
					{ "RightForeArm", new Vector3(1.5f, 1, 0.7f) },
					{ "RightHand", new Vector3(0.5f, 2, 0.7f) },
			});

			var boneScalingDefinitionBear = new BoneScalingDefinition(
				new Dictionary<string, Vector3>() {
					{ "Hips", new Vector3(1.2f, 1.2f, 1.2f) },
					{ "LeftUpLeg",  new Vector3(1, 1, 1) },
					{ "LeftLeg", new Vector3(1, 1, 1) },
					{ "LeftFoot", new Vector3(1, 1, 1) },
					{ "RightUpLeg",  new Vector3(1, 1, 1) },
					{ "RightLeg", new Vector3(1, 1, 1) },
					{ "RightFoot", new Vector3(1, 1, 1) },
					{ "Spine", new Vector3(1.4f, 1.5f, 1.4f) },
					{ "Spine1", new Vector3(1.2f, 1, 1.2f) },
					{ "Spine2", new Vector3(1.2f, 1.2f, 1.2f) },
					{ "LeftShoulder", new Vector3(1.2f, 1.6f, 1) },
					{ "LeftArm", new Vector3(1, 0.8f, 1) },
					{ "LeftForeArm", new Vector3(0.8f, 1, 0.8f) },
					{ "LeftHand", new Vector3(1.4f, 1.4f, 1.4f) },
					{ "Neck", new Vector3(1, 1, 1) },
					{ "Head", new Vector3(0.5f, 0.5f, 0.5f) },
					{ "RightShoulder", new Vector3(1.2f, 1.6f, 1) },
					{ "RightArm", new Vector3(1, 0.8f, 1) },
					{ "RightForeArm", new Vector3(0.8f, 1, 0.8f) },
					{ "RightHand", new Vector3(1.4f, 1.4f, 1.4f) }
			});

			Data = new List<IBoneScalingDefinition>();
			Data.Add(boneScalingDefinitionHuman);
			Data.Add(boneScalingDefinitionBird);
			Data.Add(boneScalingDefinitionSeal);
			Data.Add(boneScalingDefinitionBear);

		}
	}
}
