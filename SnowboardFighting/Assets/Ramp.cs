using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ramp : MonoBehaviour {

	public CameraDirector cameraDirector;
	// Use this for initialization
	void Start () {
		
	}


	void OnCollisionEnter(Collision collision) {
		Debug.Log ("Ramp: On collision entered");
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
