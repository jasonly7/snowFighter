using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraDirector : MonoBehaviour {
	public Camera cam1;
	public Camera cam2;
	public GameObject focusObj;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void switchToCamera1()
	{
		cam1.gameObject.SetActive (true);
		cam1.enabled = true;
		cam2.gameObject.SetActive (false);
		cam2.enabled = false;

	}

	public void switchCamera()
	{
		
		//cam2.transform.forward = focusObj.transform.position - cam2.transform.position;
		cam1.gameObject.SetActive (false);
		cam1.enabled = false;
		cam2.gameObject.SetActive (true);
		cam2.enabled = true;
		Debug.Log ("Switch cam");
	}
}
