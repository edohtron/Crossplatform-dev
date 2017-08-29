using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float speed = 10.0f;
    private bool alive;
    private GameObject go;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update ()
    {
		if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-speed, 0.0f, 0.0f);
        }

        if(Input.GetKey(KeyCode.D))
        {
            transform.Translate(speed, 0.0f, 0.0f);
        }
        if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, speed, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, -speed, 0);
        }
    }
}
