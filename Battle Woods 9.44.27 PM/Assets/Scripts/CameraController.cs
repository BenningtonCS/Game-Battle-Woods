<<<<<<< HEAD
﻿using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public GameObject Player;

	private Vector3 offset;

	void Start () 
	{
		offset = transform.position - Player.transform.position;
	}

	void Update () 
	{
		transform.position = Player.transform.position + offset;	
	}
}
=======
﻿using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public GameObject Player;

	private Vector3 offset;

	void Start () 
	{
		offset = transform.position - Player.transform.position;
	}

	void Update () 
	{
		transform.position = Player.transform.position + offset;	
	}
}
>>>>>>> origin/master
