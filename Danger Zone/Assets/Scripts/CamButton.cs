using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CamButton : MonoBehaviour {

	public CamManager hand;
	public Button self;

	// Use this for initialization
	void Start () {
		self.onClick.AddListener (HandleClick);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void HandleClick(){
		hand.go = true;
	}
}
