using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimScript : MonoBehaviour {

    public float speed = 10.0f;
    float h;
    float v;
    Vector3 direction = new Vector3();

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");
        direction = new Vector3(h, v, 0);
        direction *= speed * Time.deltaTime;

        transform.Translate(direction);

    }
}
