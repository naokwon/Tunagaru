using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class backTitle : MonoBehaviour {

	public AudioClip soundstart;
	AudioSource audioSource;

	// Use this for initialization
	void Start () {
		audioSource = GetComponent<AudioSource>();
	}

	public void OnClick2() {
		StartCoroutine ("Sample");
	}

	private IEnumerator Sample(){
		audioSource.PlayOneShot(soundstart);
		yield return new WaitForSeconds(0.5f);
		SceneManager.LoadScene("Title");

	}
}
