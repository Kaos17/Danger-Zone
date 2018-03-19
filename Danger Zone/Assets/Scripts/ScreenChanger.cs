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
	public Tosser hand;
	public Boomer sharon;
	public Button diceDebug;
	public Button mapDebug;
	public Button buildDebug;
	public GameObject camGhost;
	public Text guide;
	float journeyTime = 12.0f;
	float startTime;

	// Use this for initialization
	void Start () {
		butt.onClick.AddListener (HandleClick);
		//augButton.enabled = false;
		//augButton.image.enabled = false;
		diceButton.enabled = false;
		diceButton.image.enabled = false;
		diceButton.GetComponentInChildren<Text> ().enabled = false;
		//diceDebug.enabled = false;
		//diceDebug.image.enabled = false;
		//diceDebug.GetComponentInChildren<Text>().enabled = false;
		//mapDebug.enabled = false;
		//mapDebug.image.enabled = false;
		//mapDebug.GetComponentInChildren<Text> ().enabled = false;
		//buildDebug.enabled = false;
		//buildDebug.image.enabled = false;
		//buildDebug.GetComponentInChildren<Text> ().enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void HandleClick(){
		if (mapwards) {
			Vector3 spot = new Vector3 (camGhost.transform.position.x, camGhost.transform.position.y, camGhost.transform.position.z);
			this.StartCoroutine (SmoothMove (spot, 0.02f));
		} else {
			Vector3 spot = new Vector3 (targetX, targetY, targetZ);
			this.StartCoroutine (SmoothMove (spot, 0.02f));
		}
	}

	public IEnumerator SmoothMove(Vector3 target, float delta)
	{
		guide.enabled = false;
		hand.fuel = hand.reserve;
		Cursor.visible = false;
		Cursor.lockState = CursorLockMode.Locked;
		foreach (Button augButton in hand.augButtons) {
			augButton.enabled = false;
			augButton.image.enabled = false;
		}
		// Will need to perform some of this process and yield until next frames
		startTime = Time.time;
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
			float fracComplete = (Time.time - startTime) / journeyTime;
			cam.transform.position = Vector3.Slerp(cam.transform.position, target, fracComplete);
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
			if (!hand.unlocked) {
				diceButton.enabled = true;
				diceButton.image.enabled = true;
				diceButton.GetComponentInChildren<Text> ().enabled = true;
			}
		} else if (buildwards) {
			if (hand.building) {
				int choice = Random.Range (0, hand.augButtons.Length);
				foreach (Button augButton in hand.augButtons) {
					augButton.transform.position = new Vector3 (1323, -7, 0);
					//augButton.enabled = true;
					//augButton.image.enabled = true;
				}
				hand.augButtons [choice].transform.position = new Vector3 (500, 300, 0);
				hand.augButtons [choice].enabled = true;
				hand.augButtons [choice].image.enabled = true;
				int choices = Random.Range (0, hand.augButtons.Length);
				while (choices == choice) {
					choices = Random.Range (0, hand.augButtons.Length);
				}
				hand.augButtons [choices].transform.position = new Vector3 (900, 300, 0);
				hand.augButtons [choices].enabled = true;
				hand.augButtons [choices].image.enabled = true;
			}
		}
		sharon.fuse = 0;
	}
}
