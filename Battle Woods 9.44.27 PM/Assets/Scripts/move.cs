using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {


	public Transform track;
	private float moveSpeed = 3;
	Animator enemyAnim;


	void Start(){

		//getting the animator component for the enemy
		enemyAnim = GetComponent<Animator> ();
	}

	void Update () {

<<<<<<< HEAD
		transform.LookAt (track);

=======
>>>>>>> origin/master
		//creating a variable for moving the enemy after spawning from some point
		float move = moveSpeed * Time.deltaTime;

		//transforming the position of the spawn enemy to track the player
		transform.position = Vector3.MoveTowards (transform.position, track.position, move);

		//so animating the enemies so that they'd move as well as animate according to the player position
		if (move != 0) {
			enemyAnim.SetBool ("isWalking", true);
		} else {
			enemyAnim.SetBool ("isWalking", false);
		}
	
	}
}
