using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ramp : MonoBehaviour {
	//public GameObject camDirector;
	public CameraDirector cameraDirector;
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

	void OnCollisionEnter(Collision collision) {
		Debug.Log ("On collision entered");
		/*if (camDirector.cam1 != null)
			Debug.Log ("cam1: " + cameraDirector.cam1);
		else
			Debug.Log ("cam1 is null");*/

		cameraDirector.switchCamera();
	}
				
	// Update is called once per frame
	void Update () {
		
	}
}
