using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Restart : MonoBehaviour {

	public Button butt;

	// Use this for initialization
	void Start () {
		butt.onClick.AddListener (HandleClick);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void HandleClick(){
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
	}
}
