using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float speed;
    private bool alive;
    private GameObject go;

	// Use this for initialization
	void Start () {
		go = 
	}
	
	// Update is called once per frame
	void Update ()
    {
		if (Input.GetKeyDown(KeyCode.A))
        {
           transform.position.x -= 10;
        }
	}
}
