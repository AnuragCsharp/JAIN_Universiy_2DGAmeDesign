using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpwannerPipe : MonoBehaviour
{
    public float maxTime = 1;
    private float _Timer = 0;
    public GameObject pipe;
	public float height;

	private void Update()
	{
		if (_Timer> maxTime)
		{
			GameObject newPipe = Instantiate(pipe);

			newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height,height), 0);
			Destroy(newPipe, 5f);

			_Timer = 0;
		}

		_Timer += Time.deltaTime;
	}
}
