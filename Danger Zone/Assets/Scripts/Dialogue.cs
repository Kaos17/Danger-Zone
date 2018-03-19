using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialogue : MonoBehaviour {

	public bool next;
	public bool before;
	public bool after;
	public bool close;
	public Button self;
	public Events events;

	// Use this for initialization
	void Start () {
		self.onClick.AddListener (HandleClick);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void HandleClick(){
		if (next) {
			events.choose ();
		} else if (before) {
			events.choose ();
		} else if (after) {
			events.response ();
		} else if (close) {
			events.end ();
		}
		self.enabled = false;
		self.image.enabled = false;
		self.GetComponentInChildren<Text> ().enabled = false;
	}
}
