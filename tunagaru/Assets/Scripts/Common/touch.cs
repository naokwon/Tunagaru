using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class touch : MonoBehaviour {

	public GameObject tuna;
	public GameObject ru;
	public GameObject tunagaru;
	public static int newScore = 0;
	public AudioClip tunaSound;
	public AudioClip tunaSound2;
	AudioSource audioSource;


	// Use this for initialization
	void Start () {
		newScore = 0;
		audioSource = GetComponent<AudioSource>();
		this.tuna = GetComponent<GameObject>();

	}

	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0)){
			Vector2 tapPoint = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			Collider2D collider = Physics2D.OverlapPoint (tapPoint);
			if(collider != null){
				if(collider.name == "tuna_can(Clone)"){
					this.tuna = collider.transform.gameObject;
					
					audioSource.PlayOneShot(tunaSound);
					Destroy(this.tuna);
					
					newScore = newScore + 10;
					GameObject.Find ("Canvas").GetComponent<UICont> ().Counter();
					Instantiate(ru, tapPoint, Quaternion.identity);
				}
				if(collider.name == "tunagaru(Clone)"){
					this.tunagaru = collider.transform.gameObject;
					audioSource.PlayOneShot(tunaSound2);
					Destroy(this.tunagaru);
					newScore = newScore + 200;
					GameObject.Find ("Canvas").GetComponent<UICont> ().Counter2();
					Instantiate(ru, tapPoint, Quaternion.identity);
				}
			}
        }
	}
}
