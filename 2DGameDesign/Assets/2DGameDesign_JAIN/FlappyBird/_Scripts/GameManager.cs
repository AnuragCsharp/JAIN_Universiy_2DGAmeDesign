using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject gameCanvas;
	public GameObject Environment;
	public TMP_Text ScoreText;


	private int _Score=0;

	public int ScoreProp { get { return _Score; }set { _Score = value; } }

	[SerializeField]
	private SpriteRenderer[] Sprites;



	private void Start()
	{
		
		Time.timeScale = 1;

		Sprites = Environment.GetComponentsInChildren<SpriteRenderer>();

		ScoreText.text = ScoreProp.ToString();
	}


	private void Update()
	{
		if (ScoreProp == 10)
		{
			Sprites[1].sortingOrder = -11;
		}
	}


	public void GameOver()
	{
		gameCanvas.SetActive(true);
		Color newColor = new Color(0.3f, 0.4f, 0.6f,0.5f);

		foreach (var item in Sprites)
		{
			item.color = Color.red;
		}

		Time.timeScale = 0;
	}

	public void Replay()
	{
		SceneManager.LoadScene("MenuScene_Flappy");

		
	}
}
