using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public AudioSource playerAudio;
	public Animator anim;


	private float speed = 20f;
	private float rotationSpeed = 100f;


	// Use this for initialization
	void Start(){
		anim = GetComponent<Animator> ();
		playerAudio = GetComponent<AudioSource> ();
	}


	// Update is called once per frame
	public void Update(){
		if(Input.GetKeyDown("1")){
			anim.Play ("breakdance_uprock_to_ground", -1, 0f);
		}

		if(Input.GetKeyDown("2")){
			anim.Play ("breakdance_uprock_to_ground_1", -1, 0f);
		}

		if(Input.GetKeyDown("3")){
			anim.Play ("guitar_playing", -1, 0f);
		}

		if(Input.GetKeyDown("4")){
			anim.Play ("butterfly_twirl", -1, 0f);
		}

		if(Input.GetKeyDown("5")){
			anim.Play ("catwalk_walk", -1, 0f);
		}

		if(Input.GetKeyDown("6")){
			anim.Play ("shopping_cart_dance", -1, 0f);
		}

		if(Input.GetKeyDown("7")){
			anim.Play ("tut_hip_hop_dance", -1, 0f);
		}

		if(Input.GetKeyDown("8")){
			anim.Play ("yawn", -1, 0f);
		}

		if(Input.GetMouseButtonDown(1)){

			int n = Random.Range (0,5);

			if (n == 0) {
				anim.Play ("death_from_front_headshot", -1, 0f);
			}else if(n == 1){
				anim.Play ("Standing_React_Death_Bsckward", -1, 0f);
			} else if(n == 2){
				anim.Play ("death", -1, 0f);
			}else if(n == 3){
				anim.Play ("zombie_death", -1, 0f);
			}else if(n == 4){
				anim.Play ("flying_back_death", -1, 0f);
			}else{
				anim.Play ("dying_backwards", -1, 0f);
			}
		
		}

		float translation = Input.GetAxis ("Vertical") * speed;
		float rotation = Input.GetAxis ("Horizontal") * rotationSpeed;

		translation *= Time.deltaTime;
		rotation *= Time.deltaTime;
		transform.Translate (0, 0, translation);
		transform.Rotate (0, rotation, 0);	

		//its working totally opposite of the code so I have no idea why its behaving totally different?
		if ( Input.GetAxis("Vertical") == 0)
			playerAudio.Play();


		if (translation != 0) {
			anim.SetBool ("isRunning", true);
		} else {

			anim.SetBool ("isRunning", false);
		}


		/*if (Input.GetKeyDown(KeyCode.Space)) {


			if (transform.position.y > 0) {
				anim.SetBool ("isJumping", true);
			} else {
				anim.SetBool ("isJumping", false);
			}

			transform.position += new Vector3 (0, speed * Time.deltaTime, 0).normalized;


		}*/


	}
}