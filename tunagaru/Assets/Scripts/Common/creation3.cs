using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class creation3 : MonoBehaviour {

	public GameObject tunagaru;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("drop", 10, 6 + 10 * Random.value);
	}
	
	void drop () {
		Instantiate(tunagaru, new Vector3(-6.5f + 13.5f * Random.value, 6.1f, 0), Quaternion.identity);
	}

}
