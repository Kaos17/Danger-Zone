using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Insert : MonoBehaviour {

	public Attach source;
	public string label;
	public Material bright;
	public Material dark;
	public Tosser hand;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (hand.selectedAug.CompareTag (label)) {
			GetComponent<Renderer> ().material = bright;
		} else {
			GetComponent<Renderer> ().material = dark;
		}
	}

	void OnMouseDown(){
		if (hand.selectedAug.CompareTag (label)) {
			foreach (Button augButton in hand.augButtons) {
				Attach skin = augButton.GetComponent<Attach> ();
				if (skin.associated == hand.selectedAug) {
					source = skin;
				}
			}
			source.proceed (this.gameObject);
		}
	}
		
}
