using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{

  public void ChangetheScene(string SceneName)
	{
		SceneManager.LoadScene(SceneName);
	}
}