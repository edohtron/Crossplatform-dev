using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using CnControls;

public class WeaponChanger : MonoBehaviour
{

    bool Super;
    public float SuperTimer = 5.0f;
    public float SuperCD = 0.0f;
    LaserBeam beamScript;
    BulletShootScript bulletScript;
    public Image superpower;

    // Use this for initialization
    void Awake()
    {
        beamScript = gameObject.GetComponent<LaserBeam>();
        bulletScript = gameObject.GetComponent<BulletShootScript>();
    }

    void Start()
    {
        beamScript.enabled = false;
        bulletScript.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {

        SuperCD -= Time.deltaTime;
        if(SuperCD < 0)
        {
            SuperCD = 0;
        }
        if(SuperCD == 0)
        {
            superpower.enabled = true;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift) || CnInputManager.GetButtonDown("SuperPower") && SuperCD == 0)
        {
            Super = true;
            //SuperTimer = 5.0f;
        }
       if(Super)
        {
            superpower.enabled = false;
            beamScript.enabled = true;
            bulletScript.enabled = false;
            SuperTimer -= Time.deltaTime;
        }
       if(SuperTimer <= 0)
        {
            SuperTimer = 0;
            Super = false;
            SuperCD = 30.0f;
            SuperTimer = 5.0f;
        }
       if(!Super)
        {
            beamScript.enabled = false;
            bulletScript.enabled = true;
        }
    }
}
