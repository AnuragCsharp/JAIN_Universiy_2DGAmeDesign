using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
	GameManager _GamManager;
	private void Awake()
	{
		_GamManager  = FindObjectOfType<GameManager>();

	}
	private void OnTriggerEnter2D(Collider2D collision)
	{
		_GamManager.ScoreProp++;

		_GamManager.ScoreText.text = _GamManager.ScoreProp.ToString();
	}
}
