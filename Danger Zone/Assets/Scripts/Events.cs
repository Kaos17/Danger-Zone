using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Events : MonoBehaviour {

	public string[][] eventQueue = new string[10][];
	public Text description;
	public Text title;
	public Text bubble1;
	public Text bubble2;
	public Text bubble3;
	public Button choice1;
	public Button choice2;
	public Button choice3;

	// Use this for initialization
	void Start () {
		for (int x = 0; x < eventQueue.Length; x++) {
			eventQueue [x] = new string[41];
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
