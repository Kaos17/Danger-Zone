using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roller : MonoBehaviour {
	
	float xThrust;
	float yThrust;
	float zThrust;
	public Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
		xThrust = Random.Range(-10, 10);
		yThrust = Random.Range(-10, 10);
		zThrust = Random.Range(-10, 10);
		if(Mathf.Abs(xThrust)<3){xThrust=3;}
		if(Mathf.Abs(yThrust)<3){yThrust=3;}
		if(Mathf.Abs(zThrust)<3){zThrust=3;}
		rb.AddForce(xThrust, yThrust, zThrust, ForceMode.Impulse);
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space))
		{
			xThrust = Random.Range(-10, 10);
			yThrust = Random.Range(-10, 10);
			zThrust = Random.Range(-10, 10);
			if(Mathf.Abs(xThrust)<3){xThrust=3;}
			if(Mathf.Abs(yThrust)<3){yThrust=3;}
			if(Mathf.Abs(zThrust)<3){zThrust=3;}
			rb.AddForce(xThrust, yThrust, zThrust, ForceMode.Impulse);
		}
	}
}
