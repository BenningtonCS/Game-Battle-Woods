using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	private float speed = 20f;
	private float rotationSpeed = 100f;
	static Animator anim;

	void Start() {
		anim = GetComponent <Animator> ();
	}
	// Update is called once per frame
	void Update () {

		float translation = Input.GetAxis ("Vertical") * speed;
		float rotation = Input.GetAxis ("Horizontal") * rotationSpeed;

		translation *= Time.deltaTime;
		rotation *= Time.deltaTime;
		transform.Translate (0, 0, translation);
		transform.Rotate (0, rotation, 0);	

		if (Input.GetButtonDown ("Jump")) {
			
			anim.SetTrigger("isJumping");
		}

		if (translation != 0) {

			anim.SetBool ("isRunning", true);
		} else {
			
			anim.SetBool ("isRunning", false);
		}
	}
}