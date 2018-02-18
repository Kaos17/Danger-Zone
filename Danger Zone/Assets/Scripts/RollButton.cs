using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RollButton : MonoBehaviour {

	public Tosser hand;
	public Button self;

	// Use this for initialization
	void Start () {
		self.onClick.AddListener (HandleClick);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void HandleClick(){
		hand.toss = true;
		self.enabled = false;
		self.image.enabled = false;
		self.GetComponentInChildren<Text> ().enabled = false;
	}
}
