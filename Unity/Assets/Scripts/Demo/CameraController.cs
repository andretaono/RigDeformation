using UnityEngine;

namespace Erter.Demo
{
	public class CameraController : MonoBehaviour
	{
		private float distance = 4f;
		private float rotationSpeed = 10f;
		private Vector3 axis = Vector3.up;
		private Vector3 target = new Vector3(0, 2.5f, 0);

		private void Start()
		{
			transform.position = target + new Vector3(0, 0, -distance);
			transform.LookAt(target);
		}

		private void Update()
		{
			transform.RotateAround(target, axis, rotationSpeed * Time.deltaTime);
			transform.LookAt(target);
		}
	}
}
