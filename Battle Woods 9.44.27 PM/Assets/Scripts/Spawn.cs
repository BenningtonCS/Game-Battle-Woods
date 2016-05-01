using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour {


	public GameObject[] enemies;

	public int numberOfEnemies;

	private Vector3 spawnPoint;

	void Update () {
		enemies = GameObject.FindGameObjectsWithTag ("Enemy");
		numberOfEnemies = enemies.Length;


		if(numberOfEnemies != 100){

			InvokeRepeating ("spawnEnemy", 1, 5f);
		}




	}


	void spawnEnemy()
	{

		spawnPoint.x = Random.Range (62,1901);
		spawnPoint.y = 520f;
		spawnPoint.z = Random.Range (1617,3100);

		Instantiate (enemies[UnityEngine.Random.Range(0,enemies.Length - 1)],spawnPoint,Quaternion.identity);

		CancelInvoke ();
	}


}
