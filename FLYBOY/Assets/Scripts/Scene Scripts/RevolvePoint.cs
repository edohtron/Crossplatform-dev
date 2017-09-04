using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RevolvePoint : MonoBehaviour {

    public float rotateSpeed = 30;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        gameObject.transform.Rotate(Vector3.up * (-rotateSpeed * Time.deltaTime));
    }
}
