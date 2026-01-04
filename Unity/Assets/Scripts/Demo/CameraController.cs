using UnityEngine;

namespace Andre.Demo
{
	public class CameraController : MonoBehaviour
	{
		private const float DISTANCE = 4f;
		private const float ROTATION_SPEED = 10f;
		private Vector3 axis = Vector3.up;
		private Vector3 target = new Vector3(0, 2.5f, 0);

		private void Start()
		{
			transform.position = target + new Vector3(0, 0, -DISTANCE);
			transform.LookAt(target);
		}

		private void Update()
		{
			transform.RotateAround(target, axis, ROTATION_SPEED * Time.deltaTime);
			transform.LookAt(target);
		}
	}
}
