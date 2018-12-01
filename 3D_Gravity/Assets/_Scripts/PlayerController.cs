using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        /*
         Gravity change in a single direction for all objects including player
         */
        if (Input.GetKey(KeyCode.UpArrow)) {
            Physics.gravity = new Vector3(0f, 3f, 0f);
        }
        if (Input.GetKey(KeyCode.DownArrow)) {
            Physics.gravity = new Vector3(0f, -3f, 0f);
        }
        if (Input.GetKey(KeyCode.LeftArrow)) {
            Physics.gravity = new Vector3(-3f, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.RightArrow)) {
            Physics.gravity = new Vector3(3f, 0f, 0f);
        }
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("shrink")) {
            gameObject.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        }
        if (other.gameObject.CompareTag("expand")) {
            gameObject.transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
        }
        if (other.gameObject.CompareTag("regular")) {
            gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
        }
    }
}
