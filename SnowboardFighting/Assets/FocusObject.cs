using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FocusObject : MonoBehaviour {
	public GameObject player;
	public float zDist = 5;
	public float yDist = 1;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Camera cam2 = GetComponentInChildren<Camera> ();
		if (cam2!=null) {
			if (cam2.enabled) {
				transform.position = player.transform.position;
				cam2.transform.position = transform.position - Vector3.forward * zDist + Vector3.up * yDist;
			}
		}
	}
}
