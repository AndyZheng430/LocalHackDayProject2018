using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (Input.GetKey(KeyCode.UpArrow)) {
            Physics.gravity = new Vector3(0f, 3f);
        }
        if (Input.GetKey(KeyCode.DownArrow)) {
            Physics.gravity = new Vector3(0f, -3f);
        }
        if (Input.GetKey(KeyCode.LeftArrow)) {
            Physics.gravity = new Vector3(-3f, 0f);
        }
        if (Input.GetKey(KeyCode.RightArrow)) {
            Physics.gravity = new Vector3(3f, 0f);
        }

	}
}
