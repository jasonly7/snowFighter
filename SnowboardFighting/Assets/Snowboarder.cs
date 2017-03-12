using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snowboarder : MonoBehaviour {
    float x;
    private int turnSpeed = 200;
	// Use this for initialization
	void Start () {
        x = Input.mousePosition.x;

    }


    // Update is called once per frame
    /*void Update()
    {
        x = Input.mousePosition.x - x;

        transform.Rotate(Vector3.up * x);
    }*/
    // Update is called once per frame
    void Update () {
      
       
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Time.deltaTime*5);
          //  transform.Rotate(Vector3.up * 1 );
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime*5);
            //transform.Rotate(Vector3.up * -1 );
        }

        if (Input.GetAxis("Mouse X") != 0)
        {
            //transform.eulerAngles.y += turnSpeed * Time.deltaTime;
            var x = Input.GetAxis("Mouse X") * Time.deltaTime * turnSpeed;      //The above rotates this object at the speed of "speed" degrees per second in the direction pressed.
            transform.eulerAngles += new Vector3(0, x, 0);
        }
        /*  x = Input.mousePosition.x - x;

          transform.Rotate(Vector3.up * Time.deltaTime * x);*/

    }
}
