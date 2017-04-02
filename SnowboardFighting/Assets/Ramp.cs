using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ramp : MonoBehaviour {
	public GameObject camDirector;
	CameraDirector cameraDirector;
	// Use this for initialization
	void Start () {
		
	//	cameraDirector = (CameraDirector)camDirector;
	}
	void OnTriggerEnter(Collider other) {
		Debug.Log ("On trigger entered");
		Debug.Break ();
		GameObject gb = other.gameObject;
		cameraDirector.cam1.gameObject.SetActive (false);
		cameraDirector.cam2.gameObject.SetActive (true);

	}
				
	// Update is called once per frame
	void Update () {
		
	}
}
