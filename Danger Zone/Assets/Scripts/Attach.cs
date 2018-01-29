using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Attach : MonoBehaviour {

	public GameObject selectedAug;
	public Button butt;
	public GameObject associated;

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
	}
}
