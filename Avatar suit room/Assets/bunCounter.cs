using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bunCounter : MonoBehaviour {

	private int counter = 0;

	// Use this for initialization
	void OnCollisionenter(Collision col){

		Debug.Log ("Collision Detected");

		if(col.gameObject.tag == "Bun"){
			counter++;
			Debug.Log ("got one! " + counter);
		}
	}
}
