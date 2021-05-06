using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePipe : MonoBehaviour
{

	public float speed = 1f;
	private void Update()
	{
		transform.position += Vector3.left * speed * Time.deltaTime;
	}
}
