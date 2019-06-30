using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndScore : MonoBehaviour {

	public Text finScore;
	public AudioClip soundstart;
	AudioSource audioSource;

	// Use this for initialization
	void Start () {
		audioSource = GetComponent<AudioSource>();
		audioSource.PlayOneShot(soundstart);
	}

	

	void Update(){
		finScore.GetComponent<Text>().text = "Score:" + touch.newScore.ToString("D4");
	}
}
