using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavBunny : MonoBehaviour {
	
	private UnityEngine.AI.NavMeshAgent Internal_Nav_Mesh_Agent;

	public GameObject Object_to_Walk_to;

	// Use this for initialization
	void Start () {
		Internal_Nav_Mesh_Agent = GetComponent<UnityEngine.AI.NavMeshAgent> ();
	}
	
	// Update is called once per frame
	void Update () {
		Internal_Nav_Mesh_Agent.SetDestination (Object_to_Walk_to.transform.position);
	}

	void OnCollisionEnter(Collision col){


		if(col.gameObject.tag == "Bullet"){
			//gameObject.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = false;
			Debug.Log ("Collision Detected");

		}
	}

}
