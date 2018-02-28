using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Attach : MonoBehaviour {

	public GameObject fake;
	public Button butt;
	public GameObject associated;
	public GameObject camGhost;
	public ScreenChanger fwoom;
	public int explosive;
	public int reserve;
	public Tosser hand;

	// Use this for initialization
	void Start () {
		butt.onClick.AddListener (HandleClick);
		butt.enabled = false;
		butt.image.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void HandleClick(){
		hand.selectedAug = associated;
		butt.enabled = false;
		butt.image.enabled = false;
	}

	public void proceed(GameObject other){
		Instantiate (hand.selectedAug, other.transform.position, Quaternion.identity);
		Destroy (other);
		hand.selectedAug = fake;
		hand.count += explosive;
		hand.reserve += reserve;
		StartCoroutine (pause());
	}

	IEnumerator pause(){
		yield return new WaitForSecondsRealtime (1);
		Vector3 spot = new Vector3(camGhost.transform.position.x, camGhost.transform.position.y, camGhost.transform.position.z);
		this.StartCoroutine(fwoom.SmoothMove(spot, 0.02f));
	}
}
