using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Effects;

public class Boomer : MonoBehaviour {

	int fuse = 0;
	public ParticleSystemMultiplier bomb;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (fuse >= 2) {
			bomb.boom = true;
		}
	}

	void OnTriggerEnter(Collider other){
		fuse++;
	}

	void OnTriggerExit(Collider other){
		fuse--;
	}
}
