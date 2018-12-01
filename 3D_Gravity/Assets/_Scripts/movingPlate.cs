using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingPlate : MonoBehaviour {
    public float speed = 0.25f;
    public Vector3 start;
    public Vector3 end;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (gameObject.transform.localPosition.x >= start.x && gameObject.transform.localPosition.y >= start.y) {
            speed = -0.25f;
        }
        if (gameObject.transform.localPosition.x <= end.x && gameObject.transform.localPosition.y <= end.y) {
            speed = 0.25f;
        }
        transform.Translate(Vector3.up * speed);
	}
}
