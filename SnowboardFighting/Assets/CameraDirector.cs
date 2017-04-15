﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraDirector : MonoBehaviour {
	public Camera cam1;
	public Camera cam2;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void switchCamera()
	{
		Debug.Log ("Switch cam");
		cam1.gameObject.SetActive (false);
		cam1.enabled = false;
		cam2.gameObject.SetActive (true);
		cam2.enabled = true;
	}
}
