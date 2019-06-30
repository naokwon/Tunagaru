using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drop2 : MonoBehaviour {

	float dropSpeed;


	// Use this for initialization
	void Start () {
		this.dropSpeed = 0.15f;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(0, -dropSpeed, 0, Space.World);
		if (transform.position.y < -6) {
    		Destroy(this.gameObject);
  		}
	}
}
