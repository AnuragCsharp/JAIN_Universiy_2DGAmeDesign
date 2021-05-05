using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubblePop : MonoBehaviour
{
	 private Animator _Anim;

	private AudioSource _audio;


	private void Start()
	{
		_Anim = this.GetComponent<Animator>();

		_audio = this.GetComponent<AudioSource>();
	}


	private void OnMouseDown()
	{
		_Anim.SetBool("PopAnimation", true);

		_audio.Play();

		Invoke("DestroyBubble", 0.75f);
	}

	private void DestroyBubble()
	{
		Destroy(gameObject);
	}

	public void QuitTheGame()
	{
		Application.Quit();
	}
}
