using UnityEngine;
using System.Collections;

public class FireBallCollisionWithSurroundingThings : MonoBehaviour {



	/*void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag("Enemy")) {
			other.gameObject.SetActive(false);
		}
	}*/

	/*
	// this is the script function which is going to send trigger events
	void OnTriggerEnter(Collider col){

		switch(col.tag)
		{
		case "Enemy":
			Destroy (GameObject.FindWithTag("Enemy"));
			break;
		
		case "Treasure":
			break;

		case "House":
			break;

		case "Trees":
			break;

		case "Girl":
			break;

		case "Bridge":
			break;

		case "Terrains":
			break;
		
			

		}

	}*/

	/*
	//this is the script function which is going to send collision events 
	void OnCollisionEnter(Collider col){

		switch(col.gameObject.tag){

			case "Enemy":
				Destroy (GameObject.FindWithTag("Enemy"));
				break;

			case "Treasure":
				break;

			case "House":
				break;

			case "Trees":
				break;

			case "Girl":
				break;

			case "Bridge":
				break;

			case "Terrains":
				break;
				
		}

	}*/


}
