using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roller : MonoBehaviour {
	
	float xThrust;
	float yThrust;
	float zThrust;
	public Rigidbody rb;
	float torque1;
	float torque2;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
		//xThrust = Random.Range(-10, 10);
		yThrust = Random.Range(4, 6);
		zThrust = Random.Range(4, 10);
		torque1 = Random.Range(-100, 100);
		torque2 = Random.Range(-100, 100);
		/*if(Mathf.Abs(xThrust)<3){xThrust=3;}
		if(Mathf.Abs(yThrust)<3){yThrust=3;}
		if(Mathf.Abs(zThrust)<3){zThrust=3;}*/
		rb.AddForce(0, yThrust, zThrust, ForceMode.Impulse);
		rb.AddTorque(transform.up * torque1, ForceMode.VelocityChange);
		rb.AddTorque(transform.right * torque2, ForceMode.VelocityChange);
		
	}
	
	// Update is called once per frame
	void Update () {
		/*if(Input.GetKeyDown(KeyCode.Space))
		{
			xThrust = Random.Range(-10, 10);
			yThrust = Random.Range(-10, 10);
			zThrust = Random.Range(-10, 10);
			if(Mathf.Abs(xThrust)<3){xThrust=3;}
			if(Mathf.Abs(yThrust)<3){yThrust=3;}
			if(Mathf.Abs(zThrust)<3){zThrust=3;}
			rb.AddForce(xThrust, yThrust, zThrust, ForceMode.Impulse);
		}*/
		
	}
}
