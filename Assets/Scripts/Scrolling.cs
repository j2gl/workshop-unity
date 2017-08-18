using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scrolling : MonoBehaviour {

	public Vector3 initialPosition;
	public float speed;
	public float zPosition;
	bool shouldUpdate;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (!shouldUpdate) {
			return;
		}
			
		transform.Translate(Vector3.back * speed * Time.deltaTime);
		if (transform.position.z <= zPosition) {
			transform.position = initialPosition;
		}
	}

	public void Init() {
		shouldUpdate = true;
	}

	public void Stop() {
		shouldUpdate = false;
	}

}
