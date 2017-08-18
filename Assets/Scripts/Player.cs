using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	CharacterController controller;
	Animator animator;
	public float jumpImpulse;
	public float gravity;
	Vector3 velocity;
	bool shouldUpdate;

	// Use this for initialization
	void Start () {
		controller = GetComponent<CharacterController>();
		animator = GetComponent<Animator>();
		animator.Play ("Salute");
	}
	
	// Update is called once per frame
	void Update () {
		if (!shouldUpdate) {
			return;
		}

		if (controller.isGrounded && Input.anyKeyDown) {
			velocity.y = jumpImpulse;
		}
		velocity.y -= gravity * Time.deltaTime;
		controller.Move(velocity * Time.deltaTime);
	}

	private void OnControllerColliderHit(ControllerColliderHit hit) {

		if (hit.collider.CompareTag ("Fence")) {
			Debug.Log (hit.collider.tag);
			FindObjectOfType<GameManager>().Stop();
			animator.Play ("Damaged@loop");
		}
	}

	public void Init() {
		shouldUpdate = true;
		animator.Play ("Running@loop");
	}

	public void Stop() {
		shouldUpdate = false;
	}

}
