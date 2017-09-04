using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePla : MonoBehaviour {

    public float speed;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        gameObject.transform.Rotate(Vector3.up * (speed * Time.deltaTime));
    }
}
