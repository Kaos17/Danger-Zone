using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContinueScript : MonoBehaviour {

	public ScreenChanger woosh;
	public GameObject camGhost;
	public Button self;
	public Text guide;

	// Use this for initialization
	void Start () {
		self.onClick.AddListener (HandleClick);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void HandleClick(){
		Vector3 spot = new Vector3 (camGhost.transform.position.x, camGhost.transform.position.y, camGhost.transform.position.z);
		this.StartCoroutine (woosh.SmoothMove (spot, 0.02f));
		self.enabled = false;
		self.image.enabled = false;
		self.GetComponentInChildren<Text> ().enabled = false;
		guide.enabled = false;
	}
}
