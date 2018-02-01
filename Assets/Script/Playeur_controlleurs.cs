using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playeur_controlleurs : MonoBehaviour {

	float speed = 50.0f ;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.UpArrow)){
			transform.position += transform.forward*speed*Time.deltaTime;
		}
		if (Input.GetKey (KeyCode.DownArrow)){
			transform.position -= transform.forward*speed*Time.deltaTime;
		}
		if (Input.GetKey (KeyCode.RightArrow)){
			transform.position += (transform+transform.right)*speed*Time.deltaTime;
		}
		if (Input.GetKey (KeyCode.LeftArrow)){
			transform.position += (transform-transform.right)*speed*Time.deltaTime;
		}
	}
}
