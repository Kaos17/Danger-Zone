using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Attach : MonoBehaviour {

	public GameObject selectedAug;
	public GameObject fake;
	public Button butt;
	public GameObject associated;
	public GameObject camGhost;
	public ScreenChanger fwoom;

	// Use this for initialization
	void Start () {
		butt.onClick.AddListener (HandleClick);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void HandleClick(){
		selectedAug = associated;
	}

	public void proceed(GameObject other){
		Instantiate (selectedAug, other.transform.position, Quaternion.identity);
		Destroy (other);
		selectedAug = fake;
		StartCoroutine (pause());
	}

	IEnumerator pause(){
		yield return new WaitForSecondsRealtime (1);
		Vector3 spot = new Vector3(camGhost.transform.position.x, camGhost.transform.position.y, camGhost.transform.position.z);
		this.StartCoroutine(fwoom.SmoothMove(spot, 0.02f));
	}
}
