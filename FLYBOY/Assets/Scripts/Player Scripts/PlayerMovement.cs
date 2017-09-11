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
        Debug.Log("width " + Screen.width);
        Debug.Log("height " + Screen.height);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.eulerAngles.x >= 300 && transform.eulerAngles.x <= 350)
        {
            //MoveUp *= speed * Time.deltaTime;
            transform.Translate(MoveUp);
        }
        if (transform.eulerAngles.x <= 50 && transform.eulerAngles.x >= 0)
        {
            //MoveDown *= speed * Time.deltaTime;
            transform.Translate(MoveDown);
        }
        
        if (transform.eulerAngles.y >= 300 && transform.eulerAngles.y <= 345)
        {
            //MoveLeft *= speed * Time.deltaTime;
            transform.Translate(MoveLeft);
        }
        if (transform.eulerAngles.y <= 80 && transform.eulerAngles.y >= 15)
        {
            //MoveRight *= speed * Time.deltaTime;
            transform.Translate(MoveRight);
        }


        Vector3 pos = Camera.main.WorldToViewportPoint(transform.position);
        pos.x = Mathf.Clamp01(pos.x);
        if (pos.x < 0.1f)
        {
            pos.x = 0.1f;
        }
        if (pos.x > 0.9f)
        {
            pos.x = 0.9f;
        }
        pos.y = Mathf.Clamp01(pos.y);
        if (pos.y < 0.1f)
        {
            pos.y = 0.1f;
        }
        if (pos.y > 0.9f)
        {
            pos.y = 0.9f;
        }
        transform.position = Camera.main.ViewportToWorldPoint(pos);
    }
}
