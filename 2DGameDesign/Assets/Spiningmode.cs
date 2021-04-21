using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spiningmode : MonoBehaviour
{
	public GameObject Square;


	private void Update()
	{
		Square.transform.RotateAround(Vector3.left, 24f);


	}
}
