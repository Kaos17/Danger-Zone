﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Effects;

public class Boomer : MonoBehaviour {

	public int fuse = 0;
	public ParticleSystemMultiplier bomb;
	public bool chief = false;
	public bool map = true;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		/*if (fuse >= 2) {
			bomb.boom = true;
		}*/
		//Debug.Log (fuse);
	}

	void OnTriggerEnter(Collider other){
		fuse++;
	}

	void OnTriggerExit(Collider other){
		fuse--;
	}
}
