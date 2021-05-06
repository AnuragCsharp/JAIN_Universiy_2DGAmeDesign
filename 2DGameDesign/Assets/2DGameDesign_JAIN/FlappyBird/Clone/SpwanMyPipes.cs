using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpwanMyPipes : MonoBehaviour
{
    public GameObject Pipes;

	public float maxTime = 1;

	private float _Timer = 0;

	public float _height;

	private void Update()
	{
		if (_Timer > maxTime)
		{
			GameObject NewPipe = Instantiate(Pipes);

			NewPipe.transform.position = transform.position + new Vector3(0, Random.Range(-_height,_height), 0);

			Destroy(NewPipe, 5f);
			_Timer = 0;
		

		}

		_Timer += Time.deltaTime;
	}
}
