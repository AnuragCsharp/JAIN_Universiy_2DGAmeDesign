using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuddyFly : MonoBehaviour
{
	private Rigidbody2D _rb;

	public float velocity =1;
	public GameHandler Gamehandler;

	private void Start()
	{
		_rb = GetComponent<Rigidbody2D>();

	
	}


	private void Update()
	{
		if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
		{
			_rb.velocity = Vector2.up * velocity;
		}
	}

	private void OnCollisionEnter2D(Collision2D CollidedObject)
	{
		Gamehandler.GameOver();
	}
}
