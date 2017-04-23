using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
	public Rigidbody rb;
	public int speed = 10;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}

	void OnCollisionEnter(Collision collision) {
		Debug.Log ("bullet hit something");
		Debug.Break ();
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 velocity;
        //transform.Translate(Vector3.up * Time.deltaTime * 100);
		velocity = transform.TransformDirection(Vector3.up) * speed;
        //transform.LookAt(Vector3.forward * Time.deltaTime * 100);
		rb.AddForce(velocity, ForceMode.VelocityChange);
		//rb.AddRelativeForce( rb.mass * Vector3.up * Time.deltaTime*100000000);
	}
}
