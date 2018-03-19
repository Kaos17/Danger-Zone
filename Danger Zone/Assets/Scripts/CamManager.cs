using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamManager : MonoBehaviour {

	public Camera cam1;
	public Camera cam2;
	public bool go;

	// Use this for initialization
	void Start () {
		cam1.enabled = true;
		cam2.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.C) || go) {
			cam1.enabled = !cam1.enabled;
			cam2.enabled = !cam2.enabled;
			go = false;
		}
	}
}
