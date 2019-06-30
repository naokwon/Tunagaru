using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour {

	public AudioClip soundstart;
	AudioSource audioSource;

	// Use this for initialization
	void Start () {
		audioSource = GetComponent<AudioSource>();
	}

	public void OnClick() {

		StartCoroutine ("Sample");
	}
	private IEnumerator Sample(){
		audioSource.PlayOneShot(soundstart);
		yield return new WaitForSeconds(1.0f);
		SceneManager.LoadScene("tunaru");

	}


}