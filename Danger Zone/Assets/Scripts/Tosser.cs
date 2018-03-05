using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tosser : MonoBehaviour {
	
	public int count;
	public int reserve;
	public GameObject die;
	public GameObject camGhost;
	public ScreenChanger fwoom;
	public Text rollGuide;
	public Button advance;
	public bool toss = false;
	GameObject[] dices;
	public GameObject selectedAug;
	public Button[] augButtons;

	// Use this for initialization
	void Start () {
		rollGuide.enabled = false;
		advance.enabled = false;
		advance.image.enabled = false;
		advance.GetComponentInChildren<Text> ().enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space) || toss){
			dices = GameObject.FindGameObjectsWithTag ("dice");
			foreach (GameObject die in dices) {
				Destroy (die);
			}
			for(int i=0; i<count; i++){
				Instantiate(die, new Vector3(Random.Range(-7f, 7f), -1.4f, -9f), Quaternion.identity);
			}
			//StartCoroutine (pause());
			rollGuide.enabled = true;
			advance.enabled = true;
			advance.image.enabled = true;
			advance.GetComponentInChildren<Text> ().enabled = true;
			toss = false;
		}
	}

	IEnumerator pause(){
		yield return new WaitForSecondsRealtime (4);
		Vector3 spot = new Vector3(camGhost.transform.position.x, camGhost.transform.position.y, camGhost.transform.position.z);
		this.StartCoroutine(fwoom.SmoothMove(spot, 0.02f));
	}
}
