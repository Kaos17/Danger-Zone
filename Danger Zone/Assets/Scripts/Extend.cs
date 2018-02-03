using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Extend : MonoBehaviour {

	public GameObject blank;
	public bool top = false;
	public bool bottom = false;
	public bool left = false;
	public bool right = false;

	// Use this for initialization
	void Start () {
		if (top) {
			Instantiate (blank, new Vector3 (transform.position.x, transform.position.y, transform.position.z + 8f), Quaternion.identity);
		}
		if (bottom) {
			Instantiate (blank, new Vector3 (transform.position.x, transform.position.y, transform.position.z - 8f), Quaternion.identity);
		}
		if (left) {
			Instantiate (blank, new Vector3 (transform.position.x - 6f, transform.position.y, transform.position.z), Quaternion.identity);
		}
		if (right) {
			Instantiate (blank, new Vector3 (transform.position.x + 6f, transform.position.y, transform.position.z), Quaternion.identity);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
