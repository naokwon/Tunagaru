using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UICont : MonoBehaviour {

	public int score = 0;
	GameObject scoreText;

	public void Counter(){
		this.score += 10;
	}

	public void Counter2(){
		this.score += 200;
	}

	// Use this for initialization
	void Start () {
		this.scoreText = GameObject.Find ("Score");
	}
	
	// Update is called once per frame
	void Update () {
		scoreText.GetComponent<Text> ().text = "Score:" + score.ToString("D4");
	}
}
