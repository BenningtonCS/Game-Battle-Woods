using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {

	public Transform track;
	private float moveSpeed = 3;

	void Update () {
		float move = moveSpeed * Time.deltaTime;
		transform.position = Vector3.MoveTowards (transform.position, track.position, move);
	}
}
