using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class emergencyScript : MonoBehaviour {

	public Button butt;
	public Events events;

	// Use this for initialization
	void Start () {
		butt.onClick.AddListener (HandleClick);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void HandleClick(){
		events.description.enabled = false;
		events.box.enabled = false;
		events.title.enabled = false;
		butt.enabled = false;
		butt.image.enabled = false;
		butt.GetComponentInChildren<Text> ().enabled = false;
	}
}
