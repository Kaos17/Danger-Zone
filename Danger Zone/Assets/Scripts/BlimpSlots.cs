using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlimpSlots : MonoBehaviour {

	public GameObject bloon;
	public GameObject engine;
	public GameObject gondola;
	public GameObject tail;
	public Vector3 top1;
	public Vector3 top2;
	public Vector3 bottom;
	public Vector3 left;
	public Vector3 right;

	// Use this for initialization
	void Start () {
		Instantiate (bloon, top1, Quaternion.identity);
		Instantiate (bloon, top2, Quaternion.identity);
		Instantiate (gondola, bottom, Quaternion.identity);
		Instantiate (tail, left, Quaternion.identity);
		Instantiate (engine, right, Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
