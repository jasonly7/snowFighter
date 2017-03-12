using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snowboarder : MonoBehaviour {
    float x;

	// Use this for initialization
	void Start () {
        x = Input.mousePosition.x;

    }
	
	// Update is called once per frame
	void Update () {
        x = Input.mousePosition.x - x;
        
        transform.Rotate(Vector3.up * x );
	}
}
