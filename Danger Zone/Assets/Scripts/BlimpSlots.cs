using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlimpSlots : MonoBehaviour {

	public GameObject blank;
	public Vector3 top1;
	public Vector3 top2;
	public Vector3 bottom;
	public Vector3 left;
	public Vector3 right;

	// Use this for initialization
	void Start () {
		Instantiate (blank, top1, Quaternion.identity);
		Instantiate (blank, top2, Quaternion.identity);
		Instantiate (blank, bottom, Quaternion.identity);
		Instantiate (blank, left, Quaternion.identity);
		Instantiate (blank, right, Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
