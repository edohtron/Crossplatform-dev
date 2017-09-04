using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float speed = 10.0f;
    private bool alive;
    private GameObject go;
    float h;
    float v;
    Vector3 direction = new Vector3();

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update ()
    {
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");
        direction = new Vector3(h, v, 0);
        direction *= speed * Time.deltaTime;


        transform.Translate(direction);
		//if (Input.GetKey(KeyCode.A))
        //{
        //    transform.Translate(-speed, 0.0f, 0.0f);
        //}
        //
        //if(Input.GetKey(KeyCode.D))
        //{
        //    transform.Translate(speed, 0.0f, 0.0f);
        //}
        //if(Input.GetKey(KeyCode.W))
        //{
        //    transform.Translate(0, speed, 0);
        //}
        //if (Input.GetKey(KeyCode.S))
        //{
        //    transform.Translate(0, -speed, 0);
        //}
    }
}
