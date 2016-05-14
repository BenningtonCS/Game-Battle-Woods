using UnityEngine;
using System.Collections;

public class FireBallShooter : MonoBehaviour {


	GameObject prefab;
	float speedOfFireBall = 40;
	PlayerController playerController;
	public static int numberOfFireBalls = 10;

	// Use this for initialization
	void Start () {
		//loading that fireball as prefab
		prefab = Resources.Load ("fireBall") as GameObject;
		playerController = GetComponent<PlayerController> ();
	}

	// Update is called once per frame
	void Update () {

		//using left mouse button to through fireball into the enemies
		if(Input.GetMouseButtonDown(0)){
			if(numberOfFireBalls > 0){
				StartCoroutine(ThrowBall ());
			};
			numberOfFireBalls = numberOfFireBalls - 1;
		}


		//if(prefab.transform.position.y < 500){
		//	prefab.SetActive (false);
		//}

	}
		
	IEnumerator ThrowBall() {
		//using the class called PlayerController for playing the animation
		//to play the animation of zombie attacking
		playerController.anim.Play("zombie_attack", -1, 0f);

		yield return new WaitForSeconds (1f);

		//moving the fireball according to the position of the player and the camera position and little bit above
		Vector3 fireBallPosition = transform.position + transform.forward * 2 + (transform.up * 9);

		//instantiating the fireball from the prefab resources folder
		GameObject fireBall = Instantiate (prefab, fireBallPosition, Quaternion.identity) as GameObject;

		Rigidbody rb = fireBall.GetComponent<Rigidbody> ();

		//giving this fireball a velosity of forward movement along with the speed
		rb.velocity = transform.forward * speedOfFireBall;
	}



}
