using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class drop : MonoBehaviour {

	float dropSpeed;
	public int count = 0;

	// Use this for initialization
	void Start () {
		this.dropSpeed = 0.007f + 0.04f * Random.value;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(0, -dropSpeed, 0, Space.World);
		if (transform.position.y < -6.1f) {
			SceneManager.LoadScene("EndTitile");
    		Destroy(this.gameObject);
  		}
	}

}
