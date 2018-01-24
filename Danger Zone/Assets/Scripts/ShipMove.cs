using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMove : MonoBehaviour {
	
	public GameObject ship;
	public GameObject node;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)){
			this.StartCoroutine(SmoothMove(node.transform.position, 0.02f));
		}
	}
	
	IEnumerator SmoothMove(Vector3 target, float delta)
     {
         // Will need to perform some of this process and yield until next frames
         float closeEnough = 0.2f;
         float distance = (ship.transform.position - target).magnitude;
 
         // GC will trigger unless we define this ahead of time
         WaitForEndOfFrame wait = new WaitForEndOfFrame();
 
         // Continue until we're there
         while(distance >= closeEnough)
         {
             // Confirm that it's moving
             Debug.Log("Executing Movement");
 
             // Move a bit then  wait until next  frame
             ship.transform.position = Vector3.Slerp(ship.transform.position, target, delta);
             yield return wait;
 
             // Check if we should repeat
             distance = (ship.transform.position - target).magnitude;
         }
 
         // Complete the motion to prevent negligible sliding
         ship.transform.position = target;
 
         // Confirm  it's ended
         Debug.Log ("Movement Complete");
     }
}
