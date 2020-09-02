using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Utils
{
	public static class UtilsClass
	{
		public static Vector3 GetVectorFromAngle(int angle)
		{
			// angle = 0 -> 360
			float angleRad = angle * (Mathf.PI / 180f);
			return new Vector3(Mathf.Cos(angleRad), Mathf.Sin(angleRad));
		}
	}

}
