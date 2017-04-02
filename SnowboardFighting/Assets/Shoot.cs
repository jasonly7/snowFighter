using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {
    public Bullet bulletPrefab;
	private int sensitivity = 10;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
  
            Bullet clone = (Bullet)Instantiate(bulletPrefab, transform.position, transform.rotation);
        }

		if (Input.GetAxis ("Mouse Y") != 0) {
			var y = Input.GetAxis ("Mouse Y") * sensitivity;
			transform.eulerAngles -= new Vector3 (0, 0, y);
		}
	}
}
