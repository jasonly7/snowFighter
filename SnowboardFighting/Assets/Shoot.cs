using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {
    public Bullet bulletPrefab;
	public float sensitivity = 10;

	public Texture2D crosshairImage;

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

	void OnGUI()
	{
		float xMin = (Screen.width / 2) - (crosshairImage.width / 4 / 2) - 32;
		float yMin = (Screen.height / 2) - (crosshairImage.height / 4 / 2);
		GUI.DrawTexture(new Rect(xMin, yMin, crosshairImage.width/4, crosshairImage.height/4), crosshairImage);
	}
}
