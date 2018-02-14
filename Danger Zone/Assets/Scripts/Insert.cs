using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Insert : MonoBehaviour {

	public Attach source;
	public string label;
	public Material bright;
	public Material dark;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (source.selectedAug.CompareTag (label)) {
			GetComponent<Renderer> ().material = bright;
		} else {
			GetComponent<Renderer> ().material = dark;
		}
	}

	void OnMouseDown(){
		if (source.selectedAug.CompareTag (label)) {
			source.proceed (this.gameObject);
		}
	}
		
}
