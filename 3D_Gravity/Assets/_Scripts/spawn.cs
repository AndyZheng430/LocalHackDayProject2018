using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour {
    public GameObject obstacle;

	// Use this for initialization
	void Start () {
        int i = 0;
        while (i < 11) {
            Instantiate(obstacle, transform);
            i++;
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
