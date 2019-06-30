using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class creation : MonoBehaviour {

	public GameObject tuna;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("drop", 2, 0.75f);
	}

	
	void drop () {
		Instantiate(tuna, new Vector3(-6.5f + 13.5f * Random.value, 6.1f, 0), Quaternion.identity);
	}
}
