using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTopDown : MonoBehaviour {

	// Use this for initialization

	public GameObject player1;
	public GameObject player2;
	public float camera_x = 0;
	public float camera_y = 0;
	public float camera_z = 40;

	void Start () {
		player1 = GameObject.Find("PLAYER1");
		player2 = GameObject.Find("PLAYER2");
	}
	
	// Update is called once per frame
	void Update () {

		camera_x = (player1.transform.position.x + player2.transform.position.x) / 2;
		camera_y = (player1.transform.position.y + player2.transform.position.y) / 2;
		transform.Translate(camera_x, camera_z, camera_y);
	
	}
}
