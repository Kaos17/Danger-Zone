using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScreenChanger : MonoBehaviour {

	public Button butt;
	public GameObject cam;
	public float targetX;
	public float targetY;
	public float targetZ;
	public bool mapwards;
	public bool dicewards;
	public bool buildwards;
	public Button diceButton;
	public Button augButton;
	public Boomer sharon;
	public Button diceDebug;
	public Button mapDebug;
	public Button buildDebug;

	// Use this for initialization
	void Start () {
		butt.onClick.AddListener (HandleClick);
		augButton.enabled = false;
		augButton.image.enabled = false;
		diceButton.enabled = false;
		diceButton.image.enabled = false;
		diceButton.GetComponentInChildren<Text> ().enabled = false;
		diceDebug.enabled = false;
		diceDebug.image.enabled = false;
		diceDebug.GetComponentInChildren<Text>().enabled = false;
		mapDebug.enabled = false;
		mapDebug.image.enabled = false;
		mapDebug.GetComponentInChildren<Text> ().enabled = false;
		buildDebug.enabled = false;
		buildDebug.image.enabled = false;
		buildDebug.GetComponentInChildren<Text> ().enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void HandleClick(){
		Vector3 spot = new Vector3(targetX, targetY, targetZ);
		this.StartCoroutine(SmoothMove(spot, 0.02f));
	}

	public IEnumerator SmoothMove(Vector3 target, float delta)
	{
		Cursor.visible = false;
		Cursor.lockState = CursorLockMode.Locked;
		augButton.enabled = false;
		augButton.image.enabled = false;
		// Will need to perform some of this process and yield until next frames
		float closeEnough = 0.2f;
		float distance = (cam.transform.position - target).magnitude;

		// GC will trigger unless we define this ahead of time
		WaitForEndOfFrame wait = new WaitForEndOfFrame();

		// Continue until we're there
		while(distance >= closeEnough)
		{
			// Confirm that it's moving
			//Debug.Log("Executing Movement");

			// Move a bit then  wait until next  frame
			cam.transform.position = Vector3.Slerp(cam.transform.position, target, delta);
			yield return wait;

			// Check if we should repeat
			distance = (cam.transform.position - target).magnitude;
		}

		// Complete the motion to prevent negligible sliding
		cam.transform.position = target;

		// Confirm  it's ended
		//Debug.Log ("Movement Complete");
		Cursor.lockState = CursorLockMode.None;
		Cursor.visible = true;
		if (sharon.fuse >= 2) {
			sharon.bomb.boom = true;
		} else if (mapwards) {
			sharon.map = true;
		} else if (dicewards) {
			diceButton.enabled = true;
			diceButton.image.enabled = true;
			diceButton.GetComponentInChildren<Text> ().enabled = true;
		} else if (buildwards) {
			augButton.enabled = true;
			augButton.image.enabled = true;
		}
		sharon.fuse = 0;
	}
}
