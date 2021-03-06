﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CnControls;

public class LaserBeam : MonoBehaviour {

    LineRenderer line;
    public float maxDist = 500;
    //private AudioSource aud;

    void Start()
    {
        //aud = GameObject.FindGameObjectWithTag("laserSound").GetComponent<AudioSource>();
        //gets the linerenderer component on the weapon
        line = gameObject.GetComponent<LineRenderer>();
        //turns the renderer off
        line.enabled = false;
        //turns the light component off
        gameObject.GetComponent<Light>().enabled = false;
    }


    void Update()
    {
        if (Time.timeScale != 0)
        {
            if (Input.GetButtonDown("Jump") || CnInputManager.GetButton("Jump"))
            {
                //aud.Play();
                StopCoroutine("FireLaser");
                StartCoroutine("FireLaser");
            }
        }
        if (Input.GetButtonUp("Jump") || CnInputManager.GetButton("Jump"))
        {
            //aud.Stop();
        }
    }

    IEnumerator FireLaser()
    {
        line.enabled = true;
        gameObject.GetComponent<Light>().enabled = true;

        while (Input.GetButton("Jump") || CnInputManager.GetButton("Jump"))
        {
            //makes the texture spin while the button is being held
            //line.GetComponent<Renderer>().material.mainTextureOffset = new Vector2(0, Time.time);

            Ray ray = new Ray(transform.position, transform.forward);
            //sets a hit variable for where the raycast ends
            RaycastHit hit;

            line.SetPosition(0, ray.origin);

            if (Physics.Raycast(ray, out hit, maxDist))
                //stops the line at whatever it hits
                line.SetPosition(1, hit.point);
            if (hit.rigidbody)
            {
                if (hit.rigidbody.gameObject.tag == "Enemy")
                {
                    //line.SetPosition(1, (hit.rigidbody.gameObject.transform.position));
                    hit.rigidbody.gameObject.SetActive(false);
                }

            }
            else
                //if the line doesn't hit anything it automatically stops 100 points forward
                line.SetPosition(1, ray.GetPoint(maxDist));

            yield return null;
        }

        //turns the line and light off when Fire1 is released
        line.enabled = false;
        gameObject.GetComponent<Light>().enabled = false;
    }
}
