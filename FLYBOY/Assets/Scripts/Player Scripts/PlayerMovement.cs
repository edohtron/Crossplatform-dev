using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed = 10.0f;
    float h;
    float v;
    Vector3 direction = new Vector3();
    public float DashTimer;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        DashTimer -= Time.deltaTime;
        if(DashTimer < 0)
        {
            DashTimer = 0;
        }

        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");
        direction = new Vector3(h, v, 0);
        direction *= speed * Time.deltaTime;

        transform.Translate(direction);



        if (DashTimer == 0)
        {
            if (Input.GetKey(KeyCode.LeftShift) && Input.GetKeyDown(KeyCode.A))
            {
                Vector3 destination = new Vector3(-25, 0, 0);
                transform.Translate(destination);
                DashTimer = 5.0f;
            }

            if (Input.GetKey(KeyCode.LeftShift) && Input.GetKeyDown(KeyCode.D))
            {
                Vector3 destination = new Vector3(25, 0, 0);
                transform.Translate(destination);
                DashTimer = 5.0f;
            }
        }

        //if (Input.GetKey(KeyCode.A))
        //{
        //    if (transform.localRotation.z <= 30)
        //    {
        //        transform.Rotate(0, 0, 1);
        //
        //    }
        //    else if (transform.localRotation.z > 15)
        //    {
        //        Debug.Log(transform.rotation);
        //    }
        //}
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
