using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tosser : MonoBehaviour {
	
	public int count;
	public GameObject die;
	public GameObject camGhost;
	public ScreenChanger fwoom;
	GameObject[] dices;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space)){
			dices = GameObject.FindGameObjectsWithTag ("dice");
			foreach (GameObject die in dices) {
				Destroy (die);
			}
			for(int i=0; i<count; i++){
				Instantiate(die, new Vector3(Random.Range(-7f, 7f), -1.4f, -9f), Quaternion.identity);
			}
			StartCoroutine (pause());
		}
	}

	IEnumerator pause(){
		yield return new WaitForSecondsRealtime (4);
		Vector3 spot = new Vector3(camGhost.transform.position.x, camGhost.transform.position.y, camGhost.transform.position.z);
		this.StartCoroutine(fwoom.SmoothMove(spot, 0.02f));
	}
}
