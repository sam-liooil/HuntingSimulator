using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletHit : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision col){


	//	if(col.gameObject.tag == "Bullet"){
	//		gameObject.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = false;
			Debug.Log ("Collision Detected");

	//	}
	}
}
