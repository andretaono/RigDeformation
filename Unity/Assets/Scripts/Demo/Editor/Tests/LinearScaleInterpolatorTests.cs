using NUnit.Framework;
using UnityEngine;

namespace Andre.Demo.Editor.Tests
{
	internal class LinearScaleInterpolatorTests
	{
		[Test]
		public void LinearScaleInterpolator_LerpsCorrectly()
		{
			// Arrange
			var interpolator = new LinearScaleInterpolator();

			var a = Vector3.one;
			var b = Vector3.one * 3f;
			float t = 0.5f;

			// Act
			var result = interpolator.Interpolate(a, b, t);

			// Assert
			Assert.AreEqual(Vector3.one * 2f, result);
		}
	}
}
