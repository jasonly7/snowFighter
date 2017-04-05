using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snowboarder : MonoBehaviour {
    float x;
	public float thrust = 10;
	public float torque = 300;
    private int sensitivity = 10;
	public Rigidbody rb;
	public GameObject snowboard;
	//Camera cam;


	// Use this for initialization
	void Start () {
        x = Input.mousePosition.x;
		rb = GetComponent<Rigidbody> ();
	//	cam.transform.position = 
    }


    // Update is called once per frame
    /*void Update()
    {
        x = Input.mousePosition.x - x;

        transform.Rotate(Vector3.up * x);
    }*/
    // Update is called once per frame
    void Update () {
		rb.isKinematic = false;
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

		if (Input.GetKey (KeyCode.W)) {
			rb.AddRelativeForce (Vector3.forward * thrust);

		} 

		if (Input.GetKey (KeyCode.S)) {
			Debug.Log ("velocity: " + rb.velocity.magnitude);
			float stop = (rb.velocity.magnitude / Time.deltaTime);//20;//rb.velocity.magnitude;
			Debug.Log ("stop: " + stop);
			rb.AddRelativeForce (Vector3.forward * -stop);
			rb.drag +=0.02f;
			//rb.isKinematic = true;
		} else {
			rb.drag = 0;
		}

       if (Input.GetAxis("Mouse X") != 0)
        {
            //transform.eulerAngles.y += turnSpeed * Time.deltaTime;
            var x = Input.GetAxis("Mouse X") * sensitivity;      //The above rotates this object at the speed of "speed" degrees per second in the direction pressed.
            transform.eulerAngles += new Vector3(0, x, 0);
        }
		
		/*if (Input.GetAxis ("Mouse Y") != 0) {
			Debug.Log ("y axis: " + Input.GetAxis ("Mouse Y"));
			var y = Input.GetAxis ("Mouse Y") * sensitivity;
			transform.eulerAngles += new Vector3 (y, 0, 0);
			rb.AddRelativeTorque (Vector3.left * torque * y);
		}*/
        
		if (Input.GetKeyUp(KeyCode.Space)) {
			Debug.Log ("Jump");
			rb.AddRelativeForce (Vector3.up * thrust);
		}
        /*  x = Input.mousePosition.x - x;

          transform.Rotate(Vector3.up * Time.deltaTime * x);*/
		
    }

	void FixedUpdate() {
		
			//rb.AddRelativeForce (Vector3.up * thrust);
		

	}
}
