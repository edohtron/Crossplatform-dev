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
        if(gameObject.tag == "Skybox")
        {
            gameObject.transform.Rotate(-Vector3.left * (speed * Time.deltaTime));
        }
        else
        {
        gameObject.transform.Rotate(Vector3.left * (speed * Time.deltaTime));

        }
    }
}
