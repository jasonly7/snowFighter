using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour {
	public CameraDirector cameraDirector;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision collision) {
		Debug.Log ("On collision entered");
		/*if (camDirector.cam1 != null)
			Debug.Log ("cam1: " + cameraDirector.cam1);
		else
			Debug.Log ("cam1 is null");*/

		cameraDirector.switchToCamera1();
	}
}
