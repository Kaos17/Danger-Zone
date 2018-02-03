using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Insert : MonoBehaviour {

	public Attach source;
	bool overlap = false;

	// Use this for initialization
	void Start () {
		if (overlap) {
			Destroy (this);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown(){
		source.proceed (this.gameObject);
	}

	void OnTriggerEnter(Collider other){
		overlap = true;
		Destroy (this);
	}
}
