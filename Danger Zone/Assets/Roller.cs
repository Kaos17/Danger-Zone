using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roller : MonoBehaviour {
	
	public float xThrust;
	public float yThrust;
	public float zThrust;
	public Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space))
		{
			xThrust = Random.Range(-6, 6);
			yThrust = Random.Range(-6, 6);
			zThrust = Random.Range(-6, 6);
			rb.AddForce(xThrust, yThrust, zThrust, ForceMode.Impulse);
		}
	}
}
