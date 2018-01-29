using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Insert : MonoBehaviour {

	public Attach source;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown(){
		source.proceed (this.gameObject);
	}
}
