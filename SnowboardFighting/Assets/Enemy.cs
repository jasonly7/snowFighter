using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
	Rigidbody rb;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other) {
		Debug.Log ("Trigger entered by " + other.name);
	}

	void OnCollisionEnter(Collision collision) {
		if (collision.gameObject.name!="Plane" && collision.gameObject.name!="Cube")
			Debug.Log ("Enemy got hit by " + collision.gameObject.name);
		//rb.AddForce (Vector3.up * rb.mass * 1000);
	}
}
