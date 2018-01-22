using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMove : MonoBehaviour {
	
	public GameObject ship;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnMouseOver(){
		if(Input.GetMouseButtonDown(0)){
			while(ship.transform.position.x != transform.position.x){
				if(ship.transform.position.x < transform.position.x){ship.transform.Translate(Vector3.right * Time.deltaTime);}
				else{ship.transform.Translate(Vector3.left * Time.deltaTime);}
			}
			while(ship.transform.position.z != transform.position.z){
				if(ship.transform.position.z < transform.position.z){ship.transform.Translate(Vector3.forward * Time.deltaTime);}
				else{ship.transform.Translate(Vector3.back * Time.deltaTime);}
			}
		}
	}
}
