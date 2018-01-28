using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlimpSlots : MonoBehaviour {

	public GameObject blank;
	public Vector3 top;
	public Vector3 bottom;
	public Vector3 left;
	public Vector3 right;

	// Use this for initialization
	void Start () {
		Instantiate (blank, top, Quaternion.identity);
		Instantiate (blank, bottom, Quaternion.identity);
		Instantiate (blank, left, Quaternion.identity);
		Instantiate (blank, right, Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
