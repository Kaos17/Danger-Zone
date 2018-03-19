using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMove : MonoBehaviour {
	
	public GameObject ship;
	public GameObject node;
	public ScreenChanger fwoom;
	public ScreenChanger fwoom2;
	public GameObject[] neighbors;
	public Tosser hand;
	public GameObject altar;
	public Events events;
	Boomer sharon;
	Vector3 dest;
	float journeyTime = 20.0f;
	float startTime;

	// Use this for initialization
	void Start () {
		fwoom = GameObject.Find ("toDice").GetComponent<ScreenChanger> ();
		fwoom2 = GameObject.Find ("toBuild").GetComponent<ScreenChanger> ();
		sharon = GameObject.Find ("Dice Box").GetComponent<Boomer> ();
		hand = GameObject.Find ("nd4").GetComponent<Tosser> ();
		events = GameObject.Find ("EventPresenter").GetComponent<Events> ();
	}
	
	// Update is called once per frame
	void Update () {
		if(sharon.map && sharon.chief){
			Vector3 place = new Vector3(fwoom2.targetX, fwoom2.targetY, fwoom2.targetZ);
			this.StartCoroutine(fwoom2.SmoothMove(place, 0.02f));
			sharon.chief = false;
		}
	}

	void OnMouseDown(){
		bool valid = false;
		if (hand.unlocked) {
			hand.unlocked = false;
			for (int x = 0; x < hand.moveOptions.Length; x++) {
				if (node == hand.moveOptions [x]) {
					valid = true;
				}
			}
			if (valid) {
				dest = node.transform.position;
				dest.y += 0;
				Cursor.visible = false;
				Cursor.lockState = CursorLockMode.Locked;
				sharon.map = false;
				sharon.chief = true;
				hand.moveOptions = neighbors;
				this.StartCoroutine (SmoothMove (dest, 0.02f));
			}
		}
	}
	
	IEnumerator SmoothMove(Vector3 target, float delta)
     {
         // Will need to perform some of this process and yield until next frames
		startTime = Time.time;
         float closeEnough = 0.2f;
         float distance = (ship.transform.position - target).magnitude;
 
         // GC will trigger unless we define this ahead of time
         WaitForEndOfFrame wait = new WaitForEndOfFrame();
 
         // Continue until we're there
         while(distance >= closeEnough)
         {
             // Confirm that it's moving
             //Debug.Log("Executing Movement");
 
             // Move a bit then  wait until next  frame
			float fracComplete = (Time.time - startTime) / journeyTime;
             ship.transform.position = Vector3.Slerp(ship.transform.position, target, fracComplete);
             yield return wait;
 
             // Check if we should repeat
             distance = (ship.transform.position - target).magnitude;
         }
 
         // Complete the motion to prevent negligible sliding
         ship.transform.position = target;
		Cursor.lockState = CursorLockMode.None;
		Cursor.visible = true;
		if (altar != null) {
			Destroy (altar);
			hand.altars--;
		}
 
         // Confirm  it's ended
         //Debug.Log ("Movement Complete");
		//Vector3 spot = new Vector3(fwoom.targetX, fwoom.targetY, fwoom.targetZ);
		//this.StartCoroutine(fwoom.SmoothMove(spot, 0.01f));
		int chance = Random.Range(1,11);
		if (chance >= 9) {
			events.happening ();
		}
     }
}
