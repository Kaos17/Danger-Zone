using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counters : MonoBehaviour {

	public Text self;
	public Tosser hand;
	public bool first;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (first) {
			self.text = hand.count.ToString ();
		} else {
			self.text = hand.fuel.ToString ();
		}
	}
}
