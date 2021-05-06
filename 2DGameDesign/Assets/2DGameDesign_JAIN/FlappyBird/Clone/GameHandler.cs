using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameHandler : MonoBehaviour
{

	public GameObject GameOver_Canvas;
	private void Start()
	{
		Time.timeScale = 1;


	}

	public void GameOver()
	{
		GameOver_Canvas.SetActive(true);

		Time.timeScale = 0;
	}

	public void Replay()
	{
		SceneManager.LoadScene("FlappyCLone");
	}
}
