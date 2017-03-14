using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snowboarder : MonoBehaviour {
    float x;
    private int sensitivity = 10;
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
      
       // Pressing 'A' will move to the left
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Time.deltaTime*5);
          //  transform.Rotate(Vector3.up * 1 );
        }
        // Pressing 'D' will move to the right
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime*5);
            //transform.Rotate(Vector3.up * -1 );
        }

       if (Input.GetAxis("Mouse X") != 0)
        {
            //transform.eulerAngles.y += turnSpeed * Time.deltaTime;
            var x = Input.GetAxis("Mouse X") * sensitivity;      //The above rotates this object at the speed of "speed" degrees per second in the direction pressed.
            transform.eulerAngles += new Vector3(0, x, 0);
        }
        

        /*  x = Input.mousePosition.x - x;

          transform.Rotate(Vector3.up * Time.deltaTime * x);*/

    }
}
