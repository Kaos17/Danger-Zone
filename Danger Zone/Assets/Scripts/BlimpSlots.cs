using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlimpSlots : MonoBehaviour {

	public GameObject bloon;
	public GameObject engine;
	public GameObject third;
	public GameObject fourth;
	public Vector3 top1;
	public Vector3 top2;
	public Vector3 bottom;
	public Vector3 left;
	public Vector3 right;

	// Use this for initialization
	void Start () {
		Instantiate (bloon, top1, Quaternion.identity);
		Instantiate (bloon, top2, Quaternion.identity);
		Instantiate (third, bottom, Quaternion.identity);
		Instantiate (engine, left, Quaternion.identity);
		Instantiate (fourth, right, Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
