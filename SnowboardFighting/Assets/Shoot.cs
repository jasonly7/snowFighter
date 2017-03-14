using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {
    public Bullet bulletPrefab;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Mouse0))
            {
  
            Bullet clone = (Bullet)Instantiate(bulletPrefab, transform.position, transform.rotation);
        }
	}
}
