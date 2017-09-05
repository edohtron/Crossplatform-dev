using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10.0f;
    Vector3 MoveUp = new Vector3(0, 1, 0);
    Vector3 MoveDown = new Vector3(0, -1, 0);
    Vector3 MoveLeft = new Vector3(-1, 0, 0);
    Vector3 MoveRight = new Vector3(1, 0, 0);
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.eulerAngles.x >= 300 && transform.eulerAngles.x <= 350)
        {
            //MoveUp *= speed * Time.deltaTime;
            transform.Translate(MoveUp);
        }
        if (transform.eulerAngles.x <= 15 && transform.eulerAngles.x >= 10)
        {
            //MoveDown *= speed * Time.deltaTime;
            transform.Translate(MoveDown);
        }
        
        if (transform.eulerAngles.y >= 300 && transform.eulerAngles.y <= 350)
        {
            //MoveLeft *= speed * Time.deltaTime;
            transform.Translate(MoveLeft);
        }
        if (transform.eulerAngles.y <= 20 && transform.eulerAngles.x >= 10)
        {
            //MoveRight *= speed * Time.deltaTime;
            transform.Translate(MoveRight);
        }

    }
}
