using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playeur_controlleurs2 : MonoBehaviour {

	float speed = 50.0f ;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Z)){
			transform.position += transform.forward*speed*Time.deltaTime;
		}
		if (Input.GetKey (KeyCode.S)){
			transform.position -= transform.forward*speed*Time.deltaTime;
		}
		if (Input.GetKey (KeyCode.D)){
			transform.position += (transform.right)*speed*Time.deltaTime;
		}
		if (Input.GetKey (KeyCode.Q)){
			transform.position -= (transform.right)*speed*Time.deltaTime;
		}
	}
}
