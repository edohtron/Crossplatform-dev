using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AimScript : MonoBehaviour {

    public float speed = 10.0f;
    float h;
    float v;
    Vector3 direction = new Vector3();
    public Image targeting;

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

        Vector3 pos = Camera.main.WorldToViewportPoint(transform.position);
        pos.x = Mathf.Clamp01(pos.x);
        pos.y = Mathf.Clamp01(pos.y);
        transform.position = Camera.main.ViewportToWorldPoint(pos);


        Vector3 imagePos = Camera.main.WorldToScreenPoint(transform.position);
        targeting.transform.position = imagePos;
    }
}
