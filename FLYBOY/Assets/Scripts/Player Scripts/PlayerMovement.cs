using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10.0f;
    Vector3 MoveUp = new Vector3(0, 10, 0);
    Vector3 MoveDown = new Vector3(0, -10, 0);
    Vector3 MoveLeft = new Vector3(-10, 0, 0);
    Vector3 MoveRight = new Vector3(10, 0, 0);
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(transform.eulerAngles.x >= 350)
        {
           // MoveUp *= speed * Time.deltaTime;
            transform.Translate(MoveUp);
        }
        if(transform.eulerAngles.x <= 15 && transform.eulerAngles.x >= 10)
        {
            transform.Translate(MoveDown);
        }

        Debug.Log(transform.eulerAngles.y);
        if (transform.eulerAngles.y >= 300)
        {
            // MoveUp *= speed * Time.deltaTime;
            transform.Translate(MoveLeft);
        }
        if (transform.eulerAngles.y <= 20 && transform.eulerAngles.x >= 10)
        {
            transform.Translate(MoveRight);
        }

    }
}
