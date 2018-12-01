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
            
            Physics2D.gravity = new Vector2(0f, 3f);
        }
        if (Input.GetKey(KeyCode.DownArrow)) {
            Physics2D.gravity = new Vector2(0f, -3f);
        }
        if (Input.GetKey(KeyCode.LeftArrow)) {
            Physics2D.gravity = new Vector2(-3f, 0f);
        }
        if (Input.GetKey(KeyCode.RightArrow)) {
            Physics2D.gravity = new Vector2(3f, 0f);
        }
	}
    private void OnTriggerEnter2D(Collider2D other)
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
