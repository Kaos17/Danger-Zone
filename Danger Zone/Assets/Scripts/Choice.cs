using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Choice : MonoBehaviour {

	public bool explosive;
	public bool reserve;
	public bool other;
	public bool person;
	public Button self;
	public int number;
	public Events events;
	public Tosser hand;

	// Use this for initialization
	void Start () {
		self.onClick.AddListener (HandleClick);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void HandleClick(){
		if (person) {
			events.suggest (number);
		} else {
			if (explosive) {
				hand.count += 2;
			} else if (reserve) {
				hand.reserve -= 1;
			}
			events.result (number);
		}
	}
}
