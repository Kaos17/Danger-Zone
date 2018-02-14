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
	public Boomer sharon;

	// Use this for initialization
	void Start () {
		butt.onClick.AddListener (HandleClick);
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
		if (sharon.fuse >= 2) {
			sharon.bomb.boom = true;
		}
		Cursor.lockState = CursorLockMode.None;
		Cursor.visible = true;
	}
}
