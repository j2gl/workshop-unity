using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Return)) {
			Init();
		}
	}

	public void Init() {
		Scrolling[] blocks = FindObjectsOfType<Scrolling> ();
		foreach (Scrolling block in blocks) {
			block.Init();
		}
		FindObjectOfType<Player>().Init();
	}

	public void Stop() {
		Scrolling[] blocks = FindObjectsOfType<Scrolling> ();
		foreach (Scrolling block in blocks) {
			block.Stop();
		}
		FindObjectOfType<Player>().Stop();
	}

}
