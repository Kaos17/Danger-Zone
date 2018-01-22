using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tosser : MonoBehaviour {
	
	public int count;
	public GameObject die;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if(Input.GetKeyDown(KeyCode.Space)){
			for(int i=0; i<count; i++){
				Instantiate(die, new Vector3(Random.Range(-7f, 7f), 3.5f, -7f), Quaternion.identity);
			}
		}
	}
}
